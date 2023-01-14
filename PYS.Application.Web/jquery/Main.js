function Login() {

    $.ajax({
        url: "/Home/PostTest",
        success: function (result, e, f) {
            if (f.status ===200) {
                alet(result);
            }
            else {
                alet("bir hata meydana geldi.");
            }
        },
        data: { "Name": "Tunc", "Surname": "Güleç" }
        method:"POST"
    }).done(function (result, e, f) {
        var f = result;
    })



}