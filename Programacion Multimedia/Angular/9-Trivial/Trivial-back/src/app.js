const Service = require('./services/service.js');
const express = require('express');
const cors = require('cors');

const service = new Service();
const app = express();

app.use(cors());

app.get('/getQuestion', (req, res) => {
    res.json(service.getQuestion());
})

const port = 3000;
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});