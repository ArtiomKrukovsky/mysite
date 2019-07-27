$(document).ready(function () {
    localStorage.setItem("greeted", true);

    if (localStorage.getItem("greeted") == true) {
        var name = prompt("Введите ваше имя", "");
        localStorage.setItem("greeted", false);
    }
});
