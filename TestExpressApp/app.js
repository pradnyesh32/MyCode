var express = require("express");
var app = express();

app.get("/",function(req,resp){
    resp.send("HELLOW WORLD");
})

app.listen(7000);
console.log("Server running at port 7000");