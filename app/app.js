var express = require("express");
var app = express();

app.get("/",function(req,resp){
    resp.send("Hii...");
});

app.listen(8081);
console.log("server running at port 8081");