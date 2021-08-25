function dropHandler(event, fileInput) {

    event.stopPropagation();
    event.preventDefault();

    const dT = new DataTransfer();
    dT.items.add(event.dataTransfer.files[0]);

    fileInput.files = dT.files;

    handleFiles(dT.files, event.target);
}

function handleFiles(files, element) {
    for (var i = 0; i < files.length; i++) {
        var file = files[i]
        if (!file.type.startsWith('image/')) { continue }

        var img = document.createElement("img");
        img.classList.add("img-thumbnail");
        img.file = file;
        element.parentElement.classList.remove('active-drop');

        var parent = element.parentElement;

        parent.removeChild(parent.firstElementChild);
        parent.appendChild(img);

        var reader = new FileReader();
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