require('dotenv').config();
const express = require('express');
const cors = require('cors');
const dns = require('dns');
const bodyParser = require('body-parser');
const app = express();


// Basic Configuration
const port = process.env.PORT || 3000;

let oUrl = {
  url: '',
  short_url: 1
};

app.use(cors());
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.use('/public', express.static(`${process.cwd()}/public`));

app.get('/', function(req, res) {
  res.sendFile(process.cwd() + '/views/index.html');
});

// Your first API endpoint
app.get('/api/hello', function(req, res) {
  res.json({ greeting: 'hello API' });
});

const isValidUrl = (urlString, callback) => {
  try {
    const url = new URL(urlString);
    dns.lookup(url.hostname, (err, address) => {
      if (err || !address) {
        callback(false);
      } else {
        callback(true);
      }
    });
  } catch (e) {
    callback(false);
  }
};

// POST endpoint to create a short URL
app.post('/api/shorturl', (req, res) => {
  const originalUrl = req.body.url;

  isValidUrl(originalUrl, (isValid) => {
    if (!isValid) {
      return res.json({ error: 'invalid url' });
    }

    oUrl.url = originalUrl;
    oUrl.short_url = 1;
    res.json({ original_url: originalUrl, short_url: 1 });
  });
});

app.get('/api/shorturl/:short_url', (req, res) => {
  // const short_url = req.params.short_url;
  res.redirect(oUrl.url);
});

app.listen(port, function() {
  console.log(`Listening on port ${port}`);
});
