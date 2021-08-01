
var tags = new Array();

const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/tictactoe")
    .build();

var cell = document.getElementsByClassName("btn-game");
document.getElementById('searchByTags').addEventListener("input", function (e) {
    var gamesList = document.getElementsByClassName("btn findGame");
    for (var i = 0; i < gamesList.length; i++) {
        if (gamesList[i].getAttribute('value').includes(this.value))
            gamesList[i].style.display = "flex"
        else
            gamesList[i].style.display = "none"
    }
});

hubConnection.on("RestartGame", function () {
    visibleElementHtml("start");

    hubConnection.on("SetAllGames", function (tagGames, gameNames, ids, tagList) {
        visibleElementHtml("start");
        initTags(tagList);
        initListGame(gameNames, ids, tagGames);
        addEnventForBtn();
    });

    hubConnection.on("AppendenGame", function (tagGames, gameNames, ids, tagList) {
        initListGame(gameNames, ids, tagGames);
        initTags(tagList);
        addEnventForBtn();
    });

    hubConnection.on("RemoveGame", function (id) {
        var gamesList = document.getElementsByClassName("btn findGame");
        for (var i = 0; i < gamesList.length; i++) {
            if (parseInt(gamesList[i].getAttribute('pos')) === id) {
                gamesList[i].remove();
            }
        }
    });


    document.getElementById("createNewGame").addEventListener("click", function (e) {
        visibleElementHtml("createGame");
        document.getElementById("sendNewGame").addEventListener("click", function (e) {
            var tag = document.getElementById("tagName").value;
            tag = tag.trim();
            if (tag === '')
                return;
            var gameName = document.getElementById("gameName").value;
            hubConnection.on("NoOpponent", function () {
                document.getElementById("gameInformation").innerHTML = "<strong> We're searching for an opponent, please wait! </strong>";
                visibleElementHtml("gameInformation")
            });
            hubConnection.invoke("CreateGame", gameName, tag);
        });
    });
});

hubConnection.on("WinnerGame", function (text) {
    visibleElementHtml("container");
    document.getElementById("content").innerHTML = "<strong>" + text + "</strong>";
});


hubConnection.on("FoundOpponent", function (choise) {
    visibleElementHtml("root")
    document.getElementById("opponent").innerHTML = "</strong> <center> You play " + choise + "</center>";
    game();
});


function initListGame(gameNames, ids, tagGames) {
    var btnGameList = document.getElementById("listGames");
    btnGameList.innerHTML = "";
    for (var i = 0; i < gameNames.length; i++) {
        btnGameList.innerHTML += "<div class=\"btn btn-primary findGame col-12 col-sm-6 col-md-4 col-xl\" pos = " + ids[i] + " value = " + tagGames[i] + "><center> " + gameNames[i] + "</center></div><br />";
    }
}

function initTags(tagGames) {
    tags = tagGames;
}

function addEnventForBtn() {
    var tag = document.getElementById('searchByTags').value;
    var gamesList = document.getElementsByClassName("btn findGame");
    for (var i = 0; i < gamesList.length; i++) {
        gamesList[i].removeEventListener('click', clickGame, false);
        gamesList[i].addEventListener('click', clickGame, false);
        if (gamesList[i].getAttribute('value').includes(tag))
            gamesList[i].style.display = "flex";

        else
            gamesList[i].style.display = "none";
    }
}

function clickGame() {
    hubConnection.invoke("FindOpponent", this.getAttribute('pos'));
}

function visibleElementHtml(element) {
    document.getElementById("container").style.visibility = "hidden";
    document.getElementById("root").style.visibility = "hidden";
    document.getElementById("start").style.visibility = "hidden";
    document.getElementById("findOpponent").style.visibility = "hidden";
    document.getElementById("createGame").style.visibility = "hidden";
    document.getElementById("gameInformation").style.visibility = "hidden";
    if (element === "findOpponent")
        document.getElementById("findOpponent").style.visibility = "visible";
    if (element === "createGame")
        document.getElementById("createGame").style.visibility = "visible";
    if (element === "start")
        document.getElementById("start").style.visibility = "visible";
    if (element === "gameInformation")
        document.getElementById("gameInformation").style.visibility = "visible";
    if (element === "root")
        document.getElementById("root").style.visibility = "visible";
    if (element === "container") {
        document.getElementById("root").style.visibility = "visible";
        document.getElementById("container").style.visibility = "visible";
    }
}

hubConnection.start();
hubConnection.serverTimeoutInMilliseconds = 1000 * 60 * 10;