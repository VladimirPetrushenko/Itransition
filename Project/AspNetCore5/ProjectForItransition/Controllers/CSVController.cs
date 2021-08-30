using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Repository.Interface;

namespace ProjectForItransition.Controllers
{
    public class CSVController : Controller
    {
        private readonly ICollectionRepo _collectionRepo;
        private readonly IWebHostEnvironment _appEnvironment;
        public CSVController(ICollectionRepo collectionRepo, IWebHostEnvironment appEnvironment)
        {
            _collectionRepo = collectionRepo;
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CreateCSVFile(int collectionId, string returnUrl, string queryStr)
        {
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, "CSVFile/CSVCollection.txt");
            
            byte[] buffer = System.Text.Encoding.Default.GetBytes(CSVString(collectionId));

            return File(buffer, "application/txt", "CSVCollection.txt");
        }

        public string CSVString(int collectionId)
        {
            var collection = _collectionRepo.GetCollectionById(collectionId);
            var select = collection.SelectElements.ToList();
            string row = SCVFirstLine(collection, select);
            foreach (var item in collection.Items)
            {
                row = CSVItem(collection, select, row, item);
            }
            return row;
        }

        private static string CSVItem(ContentCollection collection, List<SelectElement> select, string row, Models.Item.ContentItem item)
        {
            row = CSVCollectionDescription(collection, row);
            row = CSVItemNameAndTags(row, item);
            row = CSVNameElementsItems(collection, row, item);
            row = CSVSelectElementsItem(select, row, item);
            row += "\n";
            return row;
        }

        private static string CSVCollectionDescription(ContentCollection collection, string row)
        {
            row += collection.Name;
            row += ", " + collection.Topic;
            row += ", " + collection.Description;
            return row;
        }

        private static string CSVItemNameAndTags(string row, Models.Item.ContentItem item)
        {
            row += ", " + item.Name + ", ";
            if (item.Tags != null)
                foreach (var tag in item?.Tags)
                {
                    row += tag.Name + " ";
                }

            return row;
        }

        private static string CSVSelectElementsItem(List<SelectElement> select, string row, Models.Item.ContentItem item)
        {
            if (select.Count > 0)
            {
                int i = 0;
                foreach (var name in select)
                {
                    if (item.ItemOptions.Count > i)
                        row += ", " + item.ItemOptions[i].Option.Value;
                    else
                        row += ", \"\"";
                }
            }

            return row;
        }

        private static string SCVFirstLine(ContentCollection collection, List<SelectElement> select)
        {
            var row = "Name col, Topic, Descriptiom, Name item, Tags";
            if (collection.NameElements.Count > 0)
            {
                foreach (var name in collection.NameElements.ToList())
                {
                    row += ", " + name.Name;
                }
            }
            if (select.Count > 0)
            {
                foreach (var name in select)
                {
                    row += ", " + name.Name;
                }
            }
            row += "\n";
            return row;
        }

        private static string CSVNameElementsItems(ContentCollection collection, string row, Models.Item.ContentItem item)
        {
            var integers = 0;
            var dates = 0;
            var strings = 0;
            var markdowns = 0;
            var boxes = 0;
            foreach (var name in collection.NameElements.ToList())
            {
                CSVElement(ref row, item, name, ref integers, ref dates, ref strings, ref markdowns, ref boxes);
            }

            return row;
        }

        private static void CSVElement(ref string row, Models.Item.ContentItem item, NameField name, ref int integers, ref int dates, ref int strings, ref int markdowns, ref int boxes)
        {
            if (name.Type == TypeField.Integer)
            {
                row = CSVIntegerElemnt(row, item, integers);
                integers++;
            }
            if (name.Type == TypeField.String)
            {
                row = CSVStringElement(row, item, strings);
                strings++;
            }
            if (name.Type == TypeField.Markdown)
            {
                row = CSVMarkdownElement(row, item, markdowns);
                markdowns++;
            }
            if (name.Type == TypeField.DateTime)
            {
                row = CSVDateTimeElement(row, item, dates);
                dates++;
            }
            if (name.Type == TypeField.Checkbox)
            {
                row = CSVCheckBoxElement(row, item, boxes);
                boxes++;
            }
        }

        private static string CSVCheckBoxElement(string row, Models.Item.ContentItem item, int boxes)
        {
            if (item.CheckboxElements.Count > boxes)
                row += item.CheckboxElements[boxes].Value + ", ";
            else
                row += ", \"\"";
            return row;
        }

        private static string CSVDateTimeElement(string row, Models.Item.ContentItem item, int dates)
        {
            if (item.DateTimeElements.Count > dates)
                row += ", " + item.DateTimeElements[dates].Value;
            else
                row += ", \"\"";
            return row;
        }

        private static string CSVMarkdownElement(string row, Models.Item.ContentItem item, int markdowns)
        {
            if (item.MarkdownElements.Count > markdowns)
                row += ", " + item.MarkdownElements[markdowns].Value;
            else
                row += "\"\",";
            return row;
        }

        private static string CSVStringElement(string row, Models.Item.ContentItem item, int strings)
        {
            if (item.StringElements.Count > strings)
                row += ", " + item.StringElements[strings].Value;
            else
                row += ", \"\"";
            return row;
        }

        private static string CSVIntegerElemnt(string row, Models.Item.ContentItem item, int integers)
        {
            if (item.IntegerElements.Count > integers)
                row += ", " + item.IntegerElements[integers].Value;
            else
                row += ", \"\"";
            return row;
        }
    }
}
