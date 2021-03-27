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