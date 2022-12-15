

function DoTest() {

    $.ajax({
        url: "/Home/GetTest",
        
        success: function (result) {
            alert(result);
        }
    });
   
}


