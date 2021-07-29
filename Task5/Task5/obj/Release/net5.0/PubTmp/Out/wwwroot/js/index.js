const initCanvas = (id) => {
    return new fabric.Canvas(id, {
        width: 2000,
        height: 1000,
        selection: false,
    });
}

const setBackground = (url, canvas) => {
    fabric.Image.fromURL(url, (img) => {
        canvas.backgroundImage = img;
        canvas.renderAll();
    });
}

const toggleMode = (mode) => {
    console.log(mode);
    if (mode === modes.cursor) {
        changeToggleMode(mode);
    } else if (mode === modes.pan) {
        if (currentMode === modes.pan) {
            changeToggleMode(modes.cursor);
        }
        else {
            changeToggleMode(mode);
        }
    } else if (mode === modes.drawing) {
        if (currentMode === modes.drawing) {
            changeToggleMode(modes.cursor);
        }
        else {
            changeToggleMode(mode);
            canvas.isDrawingMode = true;
            canvas.renderAll();
        }
    } else if (mode === modes.eraser) {
        if (currentMode === modes.eraser) {
            changeToggleMode(modes.cursor);
        }
        else {
            changeToggleMode(mode);
        }
    } else if (mode === modes.text) {
        if (currentMode === modes.text) {
            changeToggleMode(modes.cursor);
        }
        else {
            changeToggleMode(mode);
        }
    } else if (mode === modes.sticky) {
        if (currentMode === modes.sticky) {
            changeToggleMode(modes.cursor);
        }
        else {
            addTODO(canvas);
            changeToggleMode(modes.text);
        }
    }
}

const changeToggleMode = (mode) => {
    setButtonStyle(mode);
    currentMode = mode;
    canvas.isDrawingMode = false;
    canvas.renderAll();
}

var fabricDblClick = (obj, handler) => {
    return function () {
        if (obj.clicked) handler(obj);
        else {
            obj.clicked = true;
            setTimeout(function () {
                obj.clicked = false;
            }, 500);
        }
    };
};

var items;
var ungroup = function (group) {
    items = group._objects;
    group._restoreObjectsState();
    canvas.remove(group);
    canvas.renderAll();
    for (var i = 0; i < items.length; i++) {
        canvas.add(items[i]);
    }
    canvas.renderAll();
};

const addTODO = (canvas) => {
    const text = new fabric.Textbox("Write your text here", {
        width: 280,
        fontSize: 20,
        editable: true,
    });
    text.on('editing:exited', () => {
        for (var i = 0; i < items.length; i++) {
            canvas.remove(items[i]);
        }
        var grp = new fabric.Group(items, {});
        canvas.add(grp);
        grp.on('mousedown', fabricDblClick(grp, function (obj) {
            if (currentMode === modes.text) {
                ungroup(grp);
                canvas.setActiveObject(text);
                text.enterEditing();
                text.selectAll();
            }
        }));
    });

    const rect = new fabric.Rect({
        height: 300,
        width: 300,
        fill: 'orange',
        originX: 'left',
    });
    const group = new fabric.Group([rect, text], {
        left: 250,
        top: 200,
        editable: true,
    })
    canvas.add(group);
    group.on('mousedown', fabricDblClick(group, function (obj) {
        if (currentMode === modes.text) {
            ungroup(group);
            canvas.setActiveObject(text);
            text.enterEditing();
            text.selectAll();
            canvas.renderAll();
            changeToggleMode(modes.cursor);
        }
    }));
    
    canvas.renderAll();
}

const setShadow = (obj, enableShadow) => {
    if (enableShadow) {
        obj.set({
            shadow: {
                color: 'rgba(0,0,0,0.5)',
                blur: 10,
                offsetX: 15,
                offsetY: 15
            }
        })
    }
    else {
        obj.set({
            shadow: {
                color: 'rgba(0,0,0,0.5)',
                offsetX: 0,
                offsetY: 0
            }
        })
    }
}

const setModeEvents = (canvas) => {
    canvas.on("mouse:move", (event) => {
        if (mousePressed) {
            if (currentMode === modes.pan) {
                canvas.setCursor('grab');
                canvas.renderAll();
                const mEvent = event.e;
                const delta = new fabric.Point(mEvent.movementX, mEvent.movementY);
                canvas.relativePan(delta);
            }
            else {
                if (event.target)
                    setShadow(event.target, true);
            }

        }
    });

    canvas.on("mouse:down", (event) => {
        mousePressed = true;
        if (currentMode === modes.pan) {
            canvas.setCursor('grab');
            canvas.renderAll();
        } else if (currentMode === modes.eraser) {
            if (event.target)
                canvas.remove(event.target);
        } else if (currentMode === modes.text) {
            if (!event.target) {
                const text = new fabric.Textbox("Write your text here", {
                    left: event.pointer.x,
                    top: event.pointer.y,
                    editable: true,
                });
                canvas.add(text).setActiveObject(text);
                text.enterEditing();
                text.on('selected', (event) => {
                    if (currentMode === modes.text) {
                        text.set('editable', true);
                    }
                    else {
                        text.set('editable', false);
                    }
                })
                text.on('deselected', (event) => {
                    changeToggleMode(modes.cursor);
                })
                
                canvas.renderAll();
            }
        }
    })

    canvas.on("mouse:up", (event) => {
        mousePressed = false;
        if (event.target)
            setShadow(event.target, false);
        if (currentMode === modes.drawing || currentMode === modes.cursor || currentMode === modes.eraser)
            hubConnection.invoke("Send", JSON.stringify(canvas));
        canvas.setCursor('default');
    })
}

const setColorListener = () => {
    const picker = document.getElementById('val4');
    picker.addEventListener('change', (event) => {
        color = event.target.value;
        canvas.freeDrawingBrush.color = color;
        canvas.renderAll();
    });
};

const setButtonStyle = (style) => {
    const picker = document.getElementById(style);
    const current = document.getElementById(currentMode);
    current.className = "btn btn-light";
    picker.className = "btn btn-secondary";
}

const clearCanvas = (canvas) => {
    canvas.getObjects().forEach((o) => {
        if (o !== canvas.backgroundImage) {
            canvas.remove(o);
        }
    })
    hubConnection.invoke("Send", JSON.stringify(canvas));
}

const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/index")
    .build();

hubConnection.on('Send', function (message) {
    canvas.loadFromJSON(message);
});

const canvas = initCanvas("canvas");
let mousePressed = false;
let color = "#FF0000";

const modes = {
    pan: 'pan',
    drawing: 'drawing',
    eraser: 'eraser',
    text: 'text',
    sticky: 'sticky',
    cursor: 'cursor',
}
let currentMode = modes.cursor;

setModeEvents(canvas);
setColorListener();
hubConnection.start();