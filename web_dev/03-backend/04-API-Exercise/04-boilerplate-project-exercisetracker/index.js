const express = require('express')
const app = express()
const cors = require('cors')
const mongoose = require('mongoose')
// const { v4: uuidv4 } = require('uuid')
const shortid = require('shortid')
const bodyParser = require('body-parser')
require('dotenv').config()

mongoose.connect(process.env.DB_URI, {
  useNewUrlParser: true,
  useUnifiedTopology: true
}).then(() => {
  console.log('Connected to MongoDB')
}).catch((err) => {
  console.log('Failed to connect to MongoDB', err)
});

const exerciseTrackerSchema = new mongoose.Schema({
  _id: { type: String, default: shortid.generate() },
  username: String,
  count: Number,
  log: [
    {
      description: String,
      duration: Number,
      date: { type: Date, default: Date.now }
    }
  ]
})

const ExerciseTracker = mongoose.model('ExerciseTracker', exerciseTrackerSchema);

app.use(cors());
app.use(express.static('public'));
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

app.get('/', (req, res) => {
  res.sendFile(__dirname + '/views/index.html')
});

//mongoose functions

//create and save a new user
const createSaveUser = async (username) => {
  try {
    const newUser = new ExerciseTracker({
      _id: shortid.generate(),
      username: username,
      count: 0,
      log: []
    })
    await newUser.save();
    return newUser;
  } catch (err) {
    throw err;
  }
}

// get all users
const getUsers = async () => {
  try {
    const users = await ExerciseTracker.find({});
    return users;
  } catch (err) {
    throw err;
  }
};

// get user bu id
const getUserById = async (id) => {
  try {
    const user = await ExerciseTracker.findById(id);
    return user;
  } catch (err) {
    throw err;
  }
};

// add exercise to user
const addExerciseToUser = async (id, description, duration, date) => {
  try {
    const user = await getUserById(id);
    user.log.push({ description, duration, date });
    user.count = user.log.length;
    await user.save();
    return user;
  } catch (err) {
    throw err;
  }
};



// request handlers
app.post("/api/users", (req, res) => {
  const username = req.body.username;
  createSaveUser(username)
    .then((data) => {
      res.json({
        username: data.username,
        _id: data._id
      });
    })
    .catch((err) => {
      res.status(500).json({ error: 'Internal Server Error' });
    });
});

app.post("/api/users/:_id/exercises", (req, res) => {
  const id = req.params._id;
  const description = req.body.description;
  const duration = req.body.duration;
  let date = req.body.date;

  if (!date || isNaN(Date.parse(date))) {
    date = new Date();
  } else {
    date = new Date(date);
  }

  addExerciseToUser(id, description, duration, date.toDateString())
    .then((data) => {
      res.json({
        username: data.username,
        description: data.log[data.log.length - 1].description,
        duration: data.log[data.log.length - 1].duration,
        date: data.log[data.log.length - 1].date.toDateString('ddd MMM DD YYYY'),
        _id: data._id
      });
    })
    .catch((err) => {
      res.status(500).json({ error: 'Internal Server Error' });
    });
});

app.get("/api/users", async (req, res) => {
  try {
    const users = await getUsers();
    res.json(
      users.map((user) => ({
        username: user.username,
        _id: user._id
      }))
    );
  } catch (err) {
    res.status(500).json({ error: 'Internal Server Error' });
  }
});

app.get("/api/users/:_id/logs", async (req, res) => {
  try {
    const id = req.params._id;
    const user = await getUserById(id);

    if (!user) {
      return res.status(404).json({ error: 'User not found' });
    }

    let { from, to, limit } = req.query;
    if (from) {
      from = new Date(from);
    }
    if (to) {
      to = new Date(to);
    }

    let log = user.log.filter((exercise) => {
      const exerciseDate = new Date(exercise.date);
      return (!from || exerciseDate >= from) && (!to || exerciseDate <= to);
    })

    if (limit) {
      limit = parseInt(limit);
      log = log.slice(0, limit);
    }

    res.json({
      username: user.username,
      count: log.length,
      _id: user._id,
      log: log.map((log) => ({
        description: log.description,
        duration: log.duration,
        date: log.date.toDateString('ddd MMM DD YYYY')
      }))
    })
  } catch (err) {
    res.status(500).json({ error: 'Internal Server Error', message: err.message });
  }
});



const listener = app.listen(process.env.PORT || 3000, () => {
  console.log('Your app is listening on port ' + listener.address().port)
})
