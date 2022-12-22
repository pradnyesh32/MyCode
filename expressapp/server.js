var express = require("express");
var app = express();

app.get("/",function(req,res){
res.sendFile("public/index.html",{root:__dirname});
})

app.listen(7000);
console.log("app running at 7000");