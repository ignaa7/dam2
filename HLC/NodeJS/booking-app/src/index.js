const express = require('express')
const cors = require('cors');
require('./db/mongoose')
const userRouter = require('./routers/user')
const placeRouter = require('./routers/place')

const app = express()
const port = process.env.PORT || 3000

app.use(cors());
app.use(express.json({limit: '50mb'}));
app.use(express.urlencoded({extended: true, limit: '50mb'}));
app.use(userRouter)
app.use(placeRouter)

app.listen(port, () => {
    console.log('Server is up on port ' + port)
})
