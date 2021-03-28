// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ProcedeForm() {
    document.getElementsByClassName("AgeVerificationForm")[0].style.display = 'none';
    var formDonation = document.getElementsByClassName("mainFormDonation")[0];
    formDonation.removeAttribute('hidden');
}

function OverviewForm(event) {
    var parentEl = event.currentTarget.parentElement;
    parentEl.setAttribute('hidden', true);
    document.getElementsByClassName("InfoOverview")[0].removeAttribute('hidden');
}

function ShowNavbar() {
    var navbarElement = document.getElementsByClassName("hidden-menu-section")[0]
    if (navbarElement.style.display == "") {
        navbarElement.style.display = "none";
    }

    if (navbarElement.style.display == "none") {
        navbarElement.style.display = "block";
        scrollPage();
    } else {
        navbarElement.style.display = "none";
    }
}

function scrollPage() {
    $("html, body").animate({ scrollTop: 0 }, "slow");
    return false;
}

window.onscroll = function () { someFunction() };

var navbar = document.getElementById("navbar");
var sticky = navbar.offsetTop;

function someFunction() {
    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky")
    } else {
        navbar.classList.remove("sticky");
    }
}

function ProcedeQuestionForm(event) {
    //hide current section
    var parentElement = event.currentTarget.parentElement.parentElement;
    parentElement.style.display = "none";
    //show next section
    var nextSection = parentElement.nextElementSibling;
    nextSection.style.display = "block";
}

function startQuestionnaire() {
    document.getElementById("startSection").style.display = "none"
    var firstSegment = document.getElementsByClassName("questionnaireSegment1")[0];
    firstSegment.style.display = "block";
}