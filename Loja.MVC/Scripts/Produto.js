
var divResultado = $("#dvValorTotal");

divResultado.html("<b>Valor total: </b>R$ 0,00");

$(document.body).on('change', '.checkbox-inline', InserirRemoverItem)
                .on('click', '#btnFecharPedido', FecharPedido);


function InserirRemoverItem()
{
    var codigo = $(this).attr('data-codigo');

    if ($(this).is(':checked'))
        InserirItem(codigo);
    else
        RemoverItem(codigo);
}



function InserirItem(codigo)
{
    $.ajax({
        data: { codigo: codigo },
        url: '/Pedido/InserirItem/',
        type: 'POST',
        cache: false,
        success: function (data) {

            var descricao = "<b>Valor total: </b>R$ " + data.ValorTotal;

            $("#dvValorTotal").empty().html(descricao);
        },
        error: function (jqXhr, textStatus, errorThrown) { pageLoadingFrame("hide"); },
        complete: function () {}
    });
}

function RemoverItem(codigo) {
    $.ajax({
        data: { codigo: codigo },
        url: '/Pedido/RemoverItem/',
        type: 'POST',
        cache: false,
        success: function (data) {

            var descricao = "<b>Valor total: </b>R$ " + data.ValorTotal;

            $("#dvValorTotal").empty().html(descricao);
        },
        error: function (jqXhr, textStatus, errorThrown) { pageLoadingFrame("hide"); },
        complete: function () { }
    });
}