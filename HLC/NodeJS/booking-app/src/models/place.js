const mongoose = require('mongoose');

const placeSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true,
        trim: true
    },
    description: {
        type: String,
        required: false,
        trim: true
    },
    imageUrl: {
        type: String,
        required: false,
        trim: true
    },
    price: {
        type: String,
        required: true,
        trim: true
    },
    owner: {
        type: mongoose.Schema.Types.ObjectId,
        required: true,
        ref: 'User'
    },
    renter: {
        type: mongoose.Schema.Types.ObjectId,
        required: false,
        ref: 'User'
    }
}, {
    timestamps: true
});

const Place = mongoose.model('Place', placeSchema);

module.exports = Place;