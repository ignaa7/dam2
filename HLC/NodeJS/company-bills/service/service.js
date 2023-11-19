const fs = require('fs');
const Client = require('../classes/client.js');

class Service {
    addClient(id, name) {
        let clients = this.getClients();
        const foundClient = clients.find((client) => client.getId() === id);
    
        if (!foundClient) {
            clients.push(new Client(id, name));
            this.saveClients(clients);
            return 0;
        }

        return 1;
    }
    
    removeClient(id) {
        const clients = this.getClients();
        const clientsToKeep = clients.filter((client) => client.getId() !== id);
    
        if (clients.length > clientsToKeep.length) {
            this.saveClients(clientsToKeep);
            return 0;
        }

        return 1;
    }

    addBill(clientId, billId, total) {
        const clients = this.getClients();
        const foundClient = clients.find((client) => client.getId() === clientId);
    
        if (foundClient) {
            const billAdded = foundClient.addBill(billId, total);
            
            if (billAdded) {
                this.saveClients(clients);
                return 0;
            }

            return 1;
        }

        return 2;
    }

    removeBill(id) {
        const clients = this.getClients();
        let billFound = false;

        for (let i = 0; i < clients.length && !billFound; i++) {
            if (clients[i].removeBill(id)) {
                billFound = true;
            }
        }

        if (billFound) {
            this.saveClients(clients);
            return 0;
        }

        return 1;
    }

    listClients() {
        return this.getClients().map(client => client.toJSON());
    }

    listBills() {
        const clients = this.getClients();
        let bills = [];

        clients.forEach(client => {
            let clientBills = client.getBills();

            clientBills.forEach(bill => {
                bills.push(bill);
            });
        });

        return bills;
    }

    listClientBills(id) {
        let clients = this.getClients();
        const foundClient = clients.find((client) => client.getId() === id);
    
        if (foundClient) {
            return foundClient.getBills();
        }

        return [];
    }
    
    saveClients(clients) {
        const literalClients = clients.map(client => client.toJSON());
        const clientsJSON = JSON.stringify(literalClients);
        fs.writeFileSync('clients.json', clientsJSON);
    }
    
    getClients () {
        try {
            const clientsBuffer = fs.readFileSync('clients.json');
            const clientsJSON = clientsBuffer.toString();
            const literalClients = JSON.parse(clientsJSON);
            return literalClients.map(client => Client.fromJSON(client));
        } catch (e) {
            return [];
        }
    }
}

module.exports = Service;