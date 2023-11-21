const GeocodeService = require('./geocode-service.js');
const WeatherService = require('./weather-service.js');

class Service {
    constructor() {
        this.geocodeService = new GeocodeService();
        this.weatherService = new WeatherService();
    }

    async getLocationData(location) {
        return await this.geocodeService.getLocationData(location);
    }

    async getWeatherData(location) {
        let locationData = await this.geocodeService.getLocationData(location);

        return await this.weatherService.getWeatherData(locationData.latitude, locationData.longitude);
    }
}

module.exports = Service;