function game() {
    var currentPlayer = document.getElementById("curPlr");
    var WaitingForMarkerPlacement = false;

    function checkWin(data) {
        var win = true;

        for (var i = 0; i < winIndex.length; i++) {
            win = true;
            for (var j = 0; j < winIndex[i].length; j++) {
                var id = winIndex[i][j];
                var ind = data.indexOf(id);
                if (ind === -1) {
                    win = false;
                }
            }
            if (win) {
                return true;
            }
        }
        return false;
    }

    function cellClick() {
        if (this.innerHTML === '') {
            if (!WaitingForMarkerPlacement) {
                hubConnection.invoke("Send", this.getAttribute('pos'), currentPlayer.innerHTML);
            }
        }
        else {
            return;
        }
    }

    hubConnection.on("Drawing", function (pos, player) {
        var data = [];
        var element = document.getElementsByClassName("btn-game");
        for (var i = 0; i < element.length; i++) {
            if (element[i].getAttribute('pos') === pos) {
                element[i].innerHTML = player;
            }
        }
        for (var i = 0; i < cell.length; i++) {
            if (cell[i].innerHTML === player) {
                data.push(parseInt(cell[i].getAttribute('pos')))
            }
        }

        if (checkWin(data)) {
            restart("Winner : " + player)
        } else {
            var draw = true;
            for (var i in cell) {
                if (cell[i].innerHTML === '') {
                    draw = false;

                }
            }
            if (draw) {
                restart("Draw");
            }
        }

        player = player === "X" ? "O" : "X";
        currentPlayer.innerHTML = player;
    });

    hubConnection.on("WaitingForMarkerPlacement", function (wait) {
        WaitingForMarkerPlacement = wait;
    });

    var winIndex = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9],
        [1, 4, 7],
        [2, 5, 8],
        [3, 6, 9],
        [1, 5, 9],
        [7, 5, 3]
    ]

    for (var i = 0; i < cell.length; i++) {
        cell[i].addEventListener('click', cellClick, false);
    }

    document.getElementById("btn-close").removeEventListener('click', function (e) {
        console.log(document.getElementById("container").style.visibility);
        document.getElementById("container").style.visibility = "hidden";
        console.log(document.getElementById("root").style.visibility);
        document.getElementById("root").style.visibility = "hidden";
        console.log("i am here");
        setTimeout(() => {
            console.log("I am here")
            visibleElementHtml("start")
            currentPlayer.innerHTML = "X";
            hubConnection.invoke("Games", undefined);
        }, 0.2);
        for (var i = 0; i < cell.length; i++) {
            cell[i].innerHTML = '';
        }
    });

    document.getElementById("btn-close").addEventListener('click', function (e) {
        document.getElementById("container").style.visibility = "hidden";
        document.getElementById("root").style.visibility = "hidden";
        console.log(document.getElementById("container").style.visibility);
        console.log(document.getElementById("root").style.visibility);
        setTimeout(() => {
            currentPlayer.innerHTML = "X";
            hubConnection.invoke("Games", undefined);
        }, 0.2);
        for (var i = 0; i < cell.length; i++) {
            cell[i].innerHTML = '';
            console.log(i);
        }
    });

    function restart(text) {
        hubConnection.invoke("Winner", text);
    }
}