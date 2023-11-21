const axios = require('axios');

class WeatherService {
    async getWeatherData(latitude, longitude) {
        const apiKey = '782c158ac510b7841675af765adb48fe';
        const url = `http://api.weatherstack.com/current?access_key=${apiKey}&query=${latitude},${longitude}`;
      
        try {
          const response = await axios.get(url);
          const data = response.data;
      
          if (data.error) {
            throw new Error(`Error: ${data.error.info}`);
          }
      
          return {
            temperature: data.current.temperature,
            description: data.current.weather_descriptions[0],
          };
        } catch (error) {
          throw error;
        }
      }
}

module.exports = WeatherService;