express = require('express');
mongoose = require("mongoose");
bodyparser = require("body-parser");
path = require("path");
mongoose.promise = global.promise;
var routes = require("./routes/router1")


const url = "mongodb+srv://pradnyeshkadam:pk70@cluster0.mwfvhd2.mongodb.net/?retryWrites=true&w=majority";
app = express();
mongoose.connect(url, { connectTimeoutMS: 1000 }, function (err, data) {
    if (err) {
        console.log("connection failed")
    }
    else {
        console.log("connected with port number 4000")
    }
})
app.use(bodyparser.json())
app.use(bodyparser.urlencoded({ extended: false }))
app.use(express.static(path.join(__dirname, "public")))
app.use(function (req, res, next) {
    res.header("Access-Control-Allow-Origin", " *");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
    next();
});

app.use("/", routes);
app.listen(4000);

module.exports = app;

