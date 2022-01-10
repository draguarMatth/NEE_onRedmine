// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


<<<<<<< HEAD
function openTab(evt, cityName) {
=======

const tabNames = ['localisation', 'type', 'orientation', 'surface'];

let tabNameSelected = tabNames[0];
let HasPrevious = false;
let HasNext= true;
let previousPage = 0;
let nextPage = 0;
let initPage = 0;
let totPages = tabNames.length;
let lastPage = totPages - 1;
let currentPage;

function initdisplaying() {
>>>>>>> Feature_Debug
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
<<<<<<< HEAD
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
=======
}

function clickNext(evt) {
    let pageElement;

    initdisplaying();

    if (previousPage < 0) {
        currentPage = initPage;
    }

    currentPage = previousPage + 1;

    if (currentPage > lastPage)
        currentPage = lastPage;
   
    previousPage = currentPage;
    pageElement = tabNames[currentPage];

    document.getElementById(pageElement).style.display = "block";
    evt.currentTarget.className += " active";

    manageButtons();
}

function clickPrevious(evt) {
    let pageElement;

    initdisplaying();

    if (previousPage > lastPage) {
        currentPage = lastPage;

    }

    currentPage = previousPage - 1;

    if (currentPage < initPage) {
        currentPage = initPage;
    }

    previousPage = currentPage;
    pageElement = tabNames[currentPage];

    document.getElementById(pageElement).style.display = "block";
    evt.currentTarget.className += " active";

    manageButtons();
}

function manageButtons() {
    checkBorderPage();

    if (HasNext && HasPrevious) {
        displayPreviousNext();
    }
    if (HasPrevious == false) {
        displayNextOnly();
    }
    if (HasNext == false) {
        displayPreviousAndSave();
    }
}

function checkBorderPage() {
    switch (currentPage) {
        case initPage:
            HasPrevious = false;
            HasNext = true;
            break;
        case lastPage:
            HasPrevious = true;
            HasNext = false;
            break;
        default:
            HasPrevious = true;
            HasNext = true;
    }
}

function displayPreviousNext(evt) {
    displayButton("buttonLeft");
    displayButton("buttonRight");
    hideButton("buttonSave");
}

function displayPreviousAndSave() {
    displayButton("buttonLeft");
    hideButton("buttonRight");
    displayButton("buttonSave");
    
}

function displayNextOnly() {

    displayButton("buttonRight");
    hideButton("buttonLeft");
    hideButton("buttonSave");
}

function displayButton(id) {
    if (document.getElementById(id).style.display == "none") {
        document.getElementById(id).style.display = "block";
    }
    return;
}

function hideButton(id) {
    if (document.getElementById(id).style.display == "block") {
        document.getElementById(id).style.display = "none";
    }
    return;
}

function saveFunction() {
    console.log("All data is saved");
>>>>>>> Feature_Debug
}