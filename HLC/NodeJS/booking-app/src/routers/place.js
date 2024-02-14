const express = require('express')
const Place = require('../models/place')
const auth = require('../middlewares/auth')
const router = new express.Router()

router.get('/places', async (req, res) => {
    try {
        res.send(await Place.find({}))
    } catch (e) {
        res.status(400).send(e)
    }
})

router.post('/places/add', auth, async (req, res) => {
    req.body.owner = req.user
    const place = new Place(req.body)
    try {
        await place.save();
        res.status(201).send({ place })
    } catch (e) {
        res.status(400).send(e)
    }
})

router.post('/places/book', auth, async (req, res) => {
    const place = await Place.findById(req.body.id)
    try {
        place.renter = req.user._id;
        console.log(place)
        res.send(place)
    } catch (e) {
        res.status(400).send(e)
    }
})

module.exports = router