'use strict';

$(function () {
    var hotelScript = $("#fetchHotel-template").html();
    var hotel = Handlebars.compile(hotelScript);

    $("#fetchHotels").click(function () {
        $.post("/Default/getHotel", function (data) {
            
            Handlebars.registerHelper('list', function () {
                var id = Handlebars.escapeExpression(this.id),
                    name = Handlebars.escapeExpression(this.name),
                    rating = Handlebars.escapeExpression(this.rating),
                    status = Handlebars.escapeExpression(this.status);

                return new Handlebars.SafeString(
                  "<tr><td>" + id + "</td><td>" + name + "</td><td>" + rating + "</td><td>" + status + "</td></tr>"
                );
            });

            var theCompiledHtml = hotel(data);
            $('.content-hotel').html(theCompiledHtml);
        });
    });
});