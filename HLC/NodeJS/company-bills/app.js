const chalk = require('chalk');
const yargs = require('yargs');
const Service = require('./service/service.js');

yargs.version('1.1.0');

const service = new Service();

yargs.command({
    command: 'agregarCliente',
    describe: 'Añade un nuevo cliente',
    builder: {
        id: {
            describe: 'ID del cliente',
            demandOption: true,
            type: 'string'
        },
        name: {
            describe: 'Nombre del cliente',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        const response = service.addClient(argv.id, argv.name);

        if (response == 0) {
            console.log(chalk.green.inverse('Cliente añadido correctamente'));
        } else if (response == 1) {
            console.log(chalk.red.inverse('ID de cliente duplicado'));
        }
    }
})

yargs.command({
    command: 'eliminarCliente',
    describe: 'Eliminar un cliente',
    builder: {
        id: {
            describe: 'ID del cliente',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        const response = service.removeClient(argv.id);

        if (response == 0) {
            console.log(chalk.green.inverse('Cliente eliminado correctamente'));
        } else if (response == 1) {
            console.log(chalk.red.inverse('No se ha encontrado el cliente'));
        }
    }
})

yargs.command({
    command: 'agregarFactura',
    describe: 'Añade una nueva factura',
    builder: {
        clientId: {
            describe: 'ID del cliente',
            demandOption: true,
            type: 'string'
        },
        billId: {
            describe: 'ID de la factura',
            demandOption: true,
            type: 'string'
        },
        total: {
            describe: 'Importe total a pagar',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        const response = service.addBill(argv.clientId, argv.billId, argv.total);

        if (response == 0) {
            console.log(chalk.green.inverse('Factura añadida correctamente'));
        } else if (response == 1) {
            console.log(chalk.red.inverse('ID de factura duplicado'));
        } else if (response == 2) {
            console.log(chalk.red.inverse('No se ha encontrado el cliente'));
        }
    }
})

yargs.command({
    command: 'eliminarFactura',
    describe: 'Eliminar una factura',
    builder: {
        id: {
            describe: 'ID de la factura',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        const response = service.removeBill(argv.id);

        if (response == 0) {
            console.log(chalk.green.inverse('Factura eliminada correctamente'));
        } else if (response == 1) {
            console.log(chalk.red.inverse('No se ha encontrado la factura'));
        }
    }
})

yargs.command({
    command: 'listarClientes',
    describe: 'Mostrar todos los clientes',
    handler() {
        const clients = service.listClients();

        if (clients.length == 0) {
            console.log(chalk.red.inverse('No se ha encontrado ningún cliente'));
        } else {
            clientsData = '';

            clients.forEach(client => {
                clientsData += 'ID Cliente: ' + client.id + '\nNombre: ' + client.name + '\nFacturas:\n';

                client.bills.forEach(bill => {
                    clientsData += 'ID Factura: ' + bill.id + '\nTotal: ' + bill.total + '\n';
                });

                clientsData += '\n';
            });

            console.log(clientsData);
        }
    }
})

yargs.command({
    command: 'listarFacturas',
    describe: 'Mostrar todas las facturas',
    handler() {
        const bills = service.listBills();

        if (bills.length == 0) {
            console.log(chalk.red.inverse('No se ha encontrado ninguna factura'));
        } else {
            billsData = '';

            bills.forEach(bill => {
                billsData += 'ID Factura: ' + bill.id + '\nTotal: ' + bill.total + '\n\n';
            });

            console.log(billsData);
        }
    }
})

yargs.command({
    command: 'listarFacturasCliente',
    describe: 'Mostrar todas las facturas de un cliente',
    builder: {
        id: {
            describe: 'ID del cliente',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        const clients = service.listClients();
        const clientArray = clients.filter(client => client.id === argv.id);

        if (clientArray) {
            client = clientArray[0];
            clientData = '';
            clientData += 'ID Cliente: ' + client.id + '\nNombre: ' + client.name + '\nFacturas:\n';

            client.bills.forEach(bill => {
                clientData += 'ID Factura: ' + bill.id + '\nTotal: ' + bill.total + '\n';
            });
            
            console.log(clientData);
        } else {
            console.log(chalk.red.inverse('No se ha encontrado el cliente'));
        }
    }
})

yargs.parse();