

function GetAltaHorario() {
    $.ajax({
        url: '/Horarios/CreateAsync',
        success: function (data) {
            $('#mdlContent').html(data);
            $('#MdlAjax').modal('show');
        },
        error: function (error) {
            console.log(error);
        }
    });
}