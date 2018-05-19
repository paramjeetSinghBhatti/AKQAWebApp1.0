
$(document).ready(function () {
    $('#divOutput').hide();
    $('form').submit(function (e) {
        // debugger;
        // e.preventDefault();
        $('#divOutput').hide();
        var formVlid = $('form').valid();
        if (formVlid == true) {
            var user = '{userName:"' + $('#UserName').val() + '" ,userNumber: "' + $('#UserNumber').val() + '" }'
            $.ajax({
                url: "http://localhost:54650/api/userapi/",
                type: 'POST',
                data: user,
                contentType: "application/json; charset=utf-8",
                statusCode: {
                    200: function () {
                        console.log('OK');
                    },
                    500: function () {
                        console.log('Internal Error');
                    }

                },
                success: function (data) {
                    // debugger;
                    try {
                        console.log('data: ' +data);
                        $('#UserName').val('');
                        $('#UserNumber').val('');
                        $('#lblWords').text(data.ConvertedToWordNumber);
                        $('#lblUserName').text(data.UserName);
                        $('#divOutput').show();
                    }
                    catch (e) {
                        console.log("inside catch");
                        $('#divOutput').hide();
                    }

                },
                error: function (error) {
                    console.log('error: ' + error);
                    $('#divOutput').hide();
                    window.location = '/CustomError/Error' + '?statusCode=' + error.status;
                }
            });
        }
        return (false);
    })
});