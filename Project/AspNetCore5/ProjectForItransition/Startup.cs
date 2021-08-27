using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using ProjectForItransition.Repository.Data;
using ProjectForItransition.Repository.Interface;
using CloudinaryDotNet;
using ProjectForItransition.Repository;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Core;

namespace ProjectForItransition
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Локальньная версия 
            var cloudName = Configuration["AccountSettings:CloudName"];
            var apiKey = Configuration["AccountSettings:ApiKey"];
            var apiSecret = Configuration["AccountSettings:ApiSecret"];
            if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
            {
                throw new ArgumentException("Please specify Cloudinary account details!");
            }
            services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
            services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = Configuration["Authentication:Facebook:AppId"];
                options.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            }).AddGoogle(options =>
            {
                options.ClientId = Configuration["Authentication:Google:ClientId"];
                options.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            });

            //// Деплой на azure
            //SecretClientOptions options = new()
            //{
            //    Retry =
            //    {
            //        Delay= TimeSpan.FromSeconds(2),
            //        MaxDelay = TimeSpan.FromSeconds(16),
            //        MaxRetries = 5,
            //        Mode = RetryMode.Exponential
            //    }
            //};
            //var client = new SecretClient(new Uri("https://KeyForMyProject.vault.azure.net/"), new DefaultAzureCredential(), options);
            //KeyVaultSecret AccountSettingsApiKey = client.GetSecret("AccountSettingsApiKey");
            //KeyVaultSecret AccountSettingsApiSecret = client.GetSecret("AccountSettingsApiSecret");
            //KeyVaultSecret AccountSettingsCloudName = client.GetSecret("AccountSettingsCloudName");
            //KeyVaultSecret AuthenticationFacebookAppId = client.GetSecret("AuthenticationFacebookAppId");
            //KeyVaultSecret AuthenticationFacebookAppSecret = client.GetSecret("AuthenticationFacebookAppSecret");
            //KeyVaultSecret AuthenticationGoogleClientId = client.GetSecret("AuthenticationGoogleClientId");
            //KeyVaultSecret AuthenticationGoogleClientSecret = client.GetSecret("AuthenticationGoogleClientSecret");

            //services.AddAuthentication().AddFacebook(options =>
            //{
            //    options.AppId = AuthenticationFacebookAppId.Value;
            //    options.AppSecret = AuthenticationFacebookAppSecret.Value;
            //}).AddGoogle(options =>
            //{
            //    options.ClientId = AuthenticationGoogleClientId.Value;
            //    options.ClientSecret = AuthenticationGoogleClientSecret.Value;
            //});
            //services.AddSingleton(new Cloudinary(new Account(AccountSettingsCloudName.Value, AccountSettingsApiKey.Value, AccountSettingsApiSecret.Value)));
            //if (new[] { AccountSettingsCloudName.Value, AccountSettingsApiKey.Value, AccountSettingsApiSecret.Value }.Any(string.IsNullOrWhiteSpace))
            //{
            //    throw new ArgumentException("Please specify Cloudinary account details!");
            //}

            services.AddSignalR();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultUI().AddDefaultTokenProviders();

            services.AddScoped<ICollectionRepo, SqlCollectionRepo>();
            services.AddScoped<IItemRepo, SqlItemRepo>();
            services.AddScoped<ITagRepo, SqlTagRepo>();
            services.AddScoped<ILikeRepo, SqlLikeRepo>();
            services.AddScoped<IOptionRepo, SqlOptionRepo>();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMvc().AddDataAnnotationsLocalization().AddViewLocalization();

            services.Configure<RequestLocalizationOptions>(optints =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("ru"),
                    new CultureInfo("en"),
                };
                optints.DefaultRequestCulture = new RequestCulture("ru");
                optints.SupportedCultures = supportedCultures;
                optints.SupportedUICultures = supportedCultures;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapHub<ItemHub>("/Item/Index");
            });
        }
    }
}
