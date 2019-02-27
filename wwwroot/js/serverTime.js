var clockConnection = connectionBuilder.withUrl("/serverTime").build();

clockConnection.on("SendTime", function (serverTime) {
    document.getElementById("serverTime").innerText = 
        new Date(serverTime).toLocaleTimeString();
});

clockConnection.start().then(function () {
    // do your own post-connection-started work here
}).catch(function (err) {
    return console.error(err.toString());
});