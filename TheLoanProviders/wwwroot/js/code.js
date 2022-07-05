var username = "hassan47";
var password = "saan47";

function _login() {
    var password2 = document.getElementById('pass').value;
    var username2 = document.getElementById('user').value;

    if (username2 == username && password2 == password) {

        window.open("../Views/Home/dashboard.cshtml");
    }
    else {
        document.getElementById('wrong').style.display = "block";
    }
}


function matchpass() {

    var Retype = document.getElementById('pass2').value;
    var type = document.getElementById('pass').value;

    if (Retype != type) {

        var Retype = document.getElementById('pass2').value = "";
        var type = document.getElementById('pass').value = "";
        document.getElementById('match').style.display = "block";

    }
}


function dnt() {
    var Name = document.getElementById('name').value;
    var ID = document.getElementById('id').value;
    var Date = document.getElementById('mm').value;
    if (Name == "" && ID == "" && Date == "") {
        alert("Please fill the given inputs!!");
    }
    else {
        alert("Thanks for Donation!!")
    }
}


var slidecount = 1;
function slider() {
    slidecount = slidecount + 1;
    if (slidecount % 2 == 0) {
        document.getElementById('slider').style.backgroundImage = "url('/assets/slider.jpg')";
        document.getElementById('sideBar').style.display = "block";
    }
    else if (slidecount % 2 == 1) {
        document.getElementById('slider').style.backgroundImage = "url('/assets/sidebar.jpg')";
        document.getElementById('sideBar').style.display = "none";
    }
}


function loadpage(pagename0, pagename1, pagename2, pagename3) {

    document.getElementById(pagename0).style.display = "none";
    document.getElementById(pagename1).style.display = "none";
    document.getElementById(pagename2).style.display = "none";
    document.getElementById(pagename3).style.display = "block";
}


var blnc = 0;
function addblnc() {
    document.getElementById('wp').style.display = "none";
    document.getElementById('inputbx').style.display = "none";
    var newblnc = document.getElementById('newblnc').value;
    var blnccheckuser = document.getElementById('blnccheckuser').value;
    if (newblnc != "" && blnccheckuser != "") {
        if (blnccheckuser == "hassan47") {

            blnc += parseInt(newblnc);
            document.getElementById('blnc').innerHTML = blnc;
            document.getElementById('newblnc').value = "";
            document.getElementById('blnccheckuser').value = "";
        }
        else {
            document.getElementById('wp').style.display = "block";
            document.getElementById('newblnc').value = "";
            document.getElementById('blnccheckuser').value = "";
        }
    }
    else {
        document.getElementById('inputbx').style.display = "block";
    }


}
