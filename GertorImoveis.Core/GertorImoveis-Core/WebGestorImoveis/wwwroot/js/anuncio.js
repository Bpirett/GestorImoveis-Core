var ObjAnuncio = new Object();

ObjAnuncio.CarregaAnuncios = function () {

    $.ajax({
        type: 'GET',
        url: "/api/ListarAnuncios",
        dataType: "JSON",
        cache: false,
        async: true,
        success: function (data) {
            console.log('my message');
            var htmlConteudo = "";

            data.forEach(function (Entitie) {

                htmlConteudo += " <div class='col-xs-12 col-sm-4 col-md-4 col-lg-4'>"

                var idReferecia = "referencia_" + Entitie.id;

                htmlConteudo += "<label id= '" + idReferecia + "' >" + Entitie.bairro + "</label></br>"
                htmlConteudo += "<label> " + Entitie.tipoimovel + "</label></br>";
                htmlConteudo += "<label> Valor: " + Entitie.valor + "</label></br>";
                htmlConteudo += " </div>";
            });
            $('#divAnuncio').html(htmlConteudo);
        }


    });



}


$(function () {

    ObjAnuncio.CarregaAnuncios();

});