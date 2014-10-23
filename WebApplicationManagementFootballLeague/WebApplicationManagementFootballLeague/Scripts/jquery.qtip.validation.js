$(function () {
    // Run this function for all validation error messages
    $('.field-validation-error').each(function () {
        // Get the name of the element the error message is intended for
        // Note: ASP.NET MVC replaces the '[', ']', and '.' characters with an
        // underscore but the data-valmsg-for value will have the original characters
        var inputElem = '#' + $(this).attr('data-valmsg-for').replace('.', '_').replace('[', '_').replace(']', '_');

        var corners = ['right center', 'left center'];
        var flipIt = $(inputElem).parents('span.right').length > 0;

        // Hide the default validation error
        $(this).hide();

        // Show the validation error using qTip
        $('.Prawa').filter(':not(.valid)').qtip({
            content: { text: $(this).text() }, // Set the content to be the error message
            position: {
                my: 'left center',
                at: 'right center',
                viewport: $(window)
            },
            show: { ready: true },
            hide: false,
            style: { classes: 'qtip-red' }
        });
        $('.Lewa').filter(':not(.valid)').qtip({
            content: { text: $(this).text() }, // Set the content to be the error message
            position: {
                my: 'right center',
                at: 'left center',
                viewport: $(window)
            },
            show: { ready: true },
            hide: false,
            style: { classes: 'qtip-red' }
        });
    });
});