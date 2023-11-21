const yargs = require('yargs');
const Service = require('./services/service.js');

yargs.version('1.1.0');

const service = new Service();

yargs.command({
    command: 'obtenerPosicionamiento',
    describe: 'Obtiene la latitud, longitud y altitud de una localización',
    builder: {
        location: {
            describe: 'Localización. Puede ser una dirección, un punto de interés, una ciudad, etc. Puede contener letras, números o espacios.',
            demandOption: true,
            type: 'string'
        }
    },
    async handler(argv) {
        const response = await service.getLocationData(argv.location);

        if (response != null) {
            console.log('Latitud: ' + response.latitude + '\nLongitud: ' + response.longitude + '\nAltitud: ' + response.altitude);
        } else {
            console.log('Error en la obtención de datos');
        }
    }
}),
yargs.command({
    command: 'obtenerTiempoAtmosferico',
    describe: 'Obtiene el tiempo atmosférico actual de una localización',
    builder: {
        location: {
            describe: 'Localización. Puede ser una dirección, un punto de interés, una ciudad, etc. Puede contener letras, números o espacios.',
            demandOption: true,
            type: 'string'
        }
    },
    async handler(argv) {
        const response = await service.getWeatherData(argv.location);

        if (response != null) {
            console.log('Temperatura: ' + response.temperature + 'ºC\nDescripción del tiempo: ' + response.description);
        } else {
            console.log('Error en la obtención de datos');
        }
    }
})

yargs.parse();