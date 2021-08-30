function dropHandler(event, fileInput) {

    event.stopPropagation();
    event.preventDefault();

    const dT = new DataTransfer();
    for (let i = 0; i < event.dataTransfer.files.length; i++) {
        let file = event.dataTransfer.files[i]
        dT.items.add(file);
    }

    fileInput.files = dT.files;

    handleFiles(dT.files, event.target);
}

function handleFiles(files, element) {
    for (let i = 0; i < files.length; i++) {
        let file = files[i]
        if (!file.type.startsWith('image/')) { continue }
        let div = document.createElement("div")
        let div2 = document.createElement("div")
        let img = document.createElement("img");
        img.classList.add("img-thumbnail");
        img.file = file;

        let parent = element.parentElement;
        parent.removeChild(parent.firstElementChild);

        div2.appendChild(img);
        div.appendChild(div2);
        parent.appendChild(div);

        let reader = new FileReader();
        reader.onload = (function (aImg) { return function (e) { aImg.src = e.target.result; }; })(img);
        reader.readAsDataURL(file);
        
    }
}

function dragOverHandler(ev) {
    event.target.parentElement.classList.add('active-drop');
    ev.preventDefault();
}

function dragLeaveHandler(ev) {
    event.target.parentElement.classList.remove('active-drop');
    ev.preventDefault();
}

