"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/serverTime").build();

connection.on("SendTime", function (serverTime) {
    document.getElementById("serverTime").innerText = 
        new Date(serverTime).toLocaleTimeString();
});

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});