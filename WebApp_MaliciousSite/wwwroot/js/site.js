// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function readIframeCookie(iframeId) {
    var iframe = document.getElementById(iframeId);
    var iframeDoc = iframe.contentWindow.document;
    var cookie = iframeDoc.cookie;
    alert(cookie);
}

function getBankCapital(uri) {
    fetch(uri)
        .then(response => response.json())
        .then(data => alert(data))
        .catch(error => alert(error));
}

function updateUserName(uri) {
    const request = {
        userId: 0,
        userName: 'Jun'
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(request)
    })
        .then(response => response.json())
        .then(data => alert(data))
        .catch(error => alert(error));

    //const request = "userId=0&userName=Jun";

    //fetch(uri, {
    //    method: 'POST',
    //    headers: {
    //        'Content-Type': 'application/x-www-form-urlencoded',
    //    },
    //    body: request
    //})
    //    .then(response => response.json())
    //    .then(data => alert(data))
    //    .catch(error => alert(error));
}