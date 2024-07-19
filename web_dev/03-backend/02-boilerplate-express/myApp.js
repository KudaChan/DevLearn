let express = require("express");
require("dotenv").config();
let bodyParser = require("body-parser");

let app = express();

app.use("/json", function (req, res, next) {
   console.log(`${req.method} ${req.path} - ${req.ip}`);
   next();
});

app.use(bodyParser.urlencoded({ extended: false }));

app.get("/", function (req, res) {
   res.sendFile(__dirname + "/views/index.html");
});

app.use("/public", express.static(__dirname + "/public"));

app.get("/json", (req, res) => {
   process.env.MESSAGE_STYLE === "uppercase"
      ? res.json({ message: "HELLO JSON" })
      : res.json({ message: "Hello json" });
});

app.get(
   "/now",
   function (req, res, next) {
      req.time = new Date().toString();
      next();
   },
   function (req, res) {
      res.send({ time: req.time });
   }
);

app.get("/:word/echo", function (req, res) {
   res.send({ echo: req.params.word });
});

app.get("/name", function(req, res) {
   res.json({name: `${req.query.first} ${req.query.last}`});
})

app.post("/name", function(req, res) {
   res.json({name: `${req.body.first} ${req.body.last}`});
})

module.exports = app;
