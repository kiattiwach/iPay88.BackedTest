$(function () {
    var service = iPay88.backedTest.creditCardDefinitions.creditCardDefinition;

    var cardNo = $("#CardNo");
    var cardType = $("#CardType");
    var bank = $("#BankLogo");

    cardNo.on('paste input', '', function () {
        var nr = $("#CardNo").val() == '' ? 0 : $("#CardNo").val();
        service.getByCardNo(nr).then(function (result) {
            var cardTypeLogo = '';
            var bankLogo = '';

            if (result != undefined) {
                cardTypeLogo = 'images/' + result.cardTypeLogo;
                bankLogo = 'images/bank/' + result.logo;
            }

            bank.attr("src", bankLogo);
            cardType.attr("src", cardTypeLogo);
        });
    });
});