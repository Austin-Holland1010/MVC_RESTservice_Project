function SecretNum() {
    int lower = null;
    var x = document.game.lower_txt.value;
    lower = parseInt(x);

    int upper = null;
    var y = document.game.upper_txt.value;
    upper = parseInt(y);

    document.game.Attempts_lbl.value = "Got Here";
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (xhttp.readyState == 4 && xhttp.status == 200)
            document.game.secret.value = xhttp.responseText;
    }
    xhttp.open("GET", http://localhost:56451/Service1.svc/NumberGenWithRange?lower=5&upper=10);
        xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send();
}