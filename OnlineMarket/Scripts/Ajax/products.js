
$("#btnAdd").click(function () {

});

function loadTable(url,div,page = 1, size = 20)
{
    $.get(url + '?page=' + page + 'size=').done(function (data) {
        div.empty();
        div.append(data);
    });
}