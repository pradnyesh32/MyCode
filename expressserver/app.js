var express = require("express");
var app = express();
var bodyparser = require("body-parser");
var path = require("path");
var cors = require('cors');
var mongoose = require("mongoose");
var Emp = require ("./routes/models/Emp");


app.use(cors());
app.use(bodyparser.json())
app.use(bodyparser.urlencoded({extended:false}))
app.use(express.static(path.join(__dirname,"public")))
mongoose.set('strictQuery', false);

mongoose.connect("mongodb+srv://pradnyeshkadam:pradnyesh@cluster0.mwfvhd2.mongodb.net/?retryWrites=true&w=majority",
                    {useNewUrlParser:true}).then(()=>{


                        app.get("/", async (req,resp)=>{
                           var emp = await Emp.find();
                            resp.send(emp);
                        })

                        app.get("/add", async (req,resp)=>{
                            const e = new Emp({loginid:"ascdc",password:"dfvdfvfv"});
                            await e.save();
                            resp.send(e);
                        })
                        
                        app.listen(4000);
                        console.log("Server running at port 4000");


                    }).catch((err)=>{
                        console.log(err);
                    })







//var routes = require("./routes/routers");


// mongoose.connect(url,{
//     connectTimeoutMS:1000
// },function(err,result){
//     if(err){
//         console.log("error in MDB connection"+err);
//     }
//     else{
//         console.log("Connection Succesful");
//     }
// });



module.exports=app;