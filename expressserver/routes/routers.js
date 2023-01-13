var express = require("express");
const { modelNames }=require("mongoose");
var mongoose = require("mongoose");
var schema=mongoose.Schema;
var router = express.Router();

var empschema = new schema({
    empid:String,ename:String,sal:String
})

var Emp = mongoose.model('emptab',empschema,'emptab');

router.get("/",function(req,resp){
        resp.send("Hello");
    // Emp.find().exec(function(err,data){
    //     if(err){
    //         resp.status(500).send("no data found");
    //     }
    //     else{
    //         resp.send("Hello World");
    //         resp.send(data);
    //     }
    // })
});

module.exports=router;