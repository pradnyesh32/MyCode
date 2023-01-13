var mongoose = require("mongoose");

var schema = new mongoose.Schema({
    loginid:String,
    password:String
});

module.exports = mongoose.model('Emp',schema);