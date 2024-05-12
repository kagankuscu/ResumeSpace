function AjaxWithData(url, data, type, successFunc, errorFunc) 
{
    $.ajax
    ({
        url: url,
        data: data,
        type: type.toUpperCase(),
        success: res => successFunc(res),
        error: err => errorFunc(err)
    })
}

function AjaxWithoutData(url, type, successFunc, errorFunc) 
{
    $.ajax
    ({
        url: url,
        type: type.toUpperCase(),
        success: res => successFunc(res),
        error: err => errorFunc(err)
    })
}