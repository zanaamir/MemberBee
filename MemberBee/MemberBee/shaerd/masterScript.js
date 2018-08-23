﻿function AjaxJsonHandler(_url , _type,_data , success_callback, error_callback) {

 
    $.ajax({
        datatype: "json",
        url: _url,
        contentType: "application/json; charset=utf-8",
        method: _type,
        data: JSON.stringify(_data),
        success: success_callback,
        error: error_callback,
    });
}

function GenericError(err){
    console.log(err)
}

var systemHelper = {
    webApiEndPoints: {
        login :"/api/login"
    },
    HttpVerbs{
        POST: "POST",
        GET : "GET",
        DELETE : "DELETE",
        PUT : "PUT",


}
}