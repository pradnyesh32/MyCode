express=require("express");
router=express.Router();
mongoose=require("mongoose");
mongoose.set('strictQuery', true);
schema=mongoose.Schema;
mngschema=new schema({
    loginid:String,password:String
},{
    strict: false
})


var Training_Manager=mongoose.model('emptab',mngschema,'emptab');


router.post('/tmlogin',function(req,resp){
    //console.log(req.body);
    Training_Manager.find({},function(err,data){
        //console.log(req.body.password);

        if(err){
            console.log("wrongid");
            resp.status(500).send("wrong id");

        }else{
            console.log(req.loginid);
            console.log(data);
            resp.send(data);
            }
         
        }
)
});


module.exports=router;