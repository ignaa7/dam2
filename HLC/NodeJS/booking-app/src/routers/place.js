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

router.patch('/places/edit', auth, async (req, res) => {
    const place = await Place.findById(req.body._id)
    let updates = Object.keys(req.body)
    updates = updates.filter(update => update !== '_id')
    const allowedUpdates = ['title', 'description', 'imageUrl', 'price']
    const isValidOperation = updates.every((update) => allowedUpdates.includes(update))

    if (!isValidOperation) {
        return res.status(400).send({ error: 'Invalid updates!' })
    }

    try {
        updates.forEach((update) => place[update] = req.body[update])
        await place.save()
        res.send()
    } catch (e) {
        res.status(400).send(e)
    }
})

router.patch('/places/book', auth, async (req, res) => {
    const place = await Place.findById(req.body.id)
    try {
        place.renter = req.user._id;
        await place.save();
        res.send()
    } catch (e) {
        res.status(400).send(e)
    }
})

router.patch('/places/removeBooking', auth, async (req, res) => {
    const place = await Place.findById(req.body.id)
    try {
        place.renter = undefined;
        await place.save();
        res.send()
    } catch (e) {
        res.status(400).send(e)
    }
})

module.exports = router