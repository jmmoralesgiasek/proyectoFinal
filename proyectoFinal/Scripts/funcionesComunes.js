function getInformation() {

    $.ajax({
        url: "/edumatica/getInformation",
        cache: false,
        type: "POST",
        success: function (response) {
            $("#respuesta").html(response);
        },
        error: function (xhr) {
            alert("Ha ocurrido un error " + xhr);
        }
    });

}