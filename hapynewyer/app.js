var express = require("express");
var app = express();

app.get("/",function(req,resp){
    resp.send("Hii...");
});

app.listen(6000);
console.log("server running at port 6000");