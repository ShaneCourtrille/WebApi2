$(document).ready(function () {
    $('#simpleMessage').click(getMessage);
    $('#postList').click(postList);
    $('#postComplex').click(postComplex);

    $.ajaxSetup({
        cache: false
    })
});

function getMessage() {
    $.get("http://localhost:53492/api/simple", function (msg) {
        alert(msg);
    });
};

function postList() {
    var values = [1, 2, 4];

    $.post("http://localhost:53492/api/complex/postList", values, function() {
        alert('success');
    })
    .fail(function(jqXHR, textStatus, errorThrown) {
            alert(textStatus);
        });
}

function postComplex() {
    var model = {
        'name': "Bob",
        'values': [1, 2, 3]
    };

    $.post("http://localhost:53492/api/complex/postComplex", model, function () {
        alert('success');
    })
    .fail(function (jqXHR, textStatus, errorThrown) {
        alert(textStatus);
    });
}