var username = "hassan47";
var password = "saan47";

function login() {
    var password2 = document.getElementById('pass').value;
    var username2 = document.getElementById('user').value;

    if (username2 == username && password2 == password) {
        alert("User " + username + " Loggedin");

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
