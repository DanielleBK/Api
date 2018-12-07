const mongoose = require('mongoose');

// mongoose.connect('mongodb://admin:a123456@ds227664.mlab.com:27664/node_rest');
mongoose.connect('mongodb://localhost/noderest')

mongoose.Promise = global.Promise;

module.exports = mongoose; 