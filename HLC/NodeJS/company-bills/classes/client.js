const Bill = require('./bill.js');

class Client {
    constructor(id, name) {
        this.id = id;
        this.name = name;
        this.bills = [];
    }

    getId() {
        return this.id;
    }

    getName() {
        return this.name;
    }

    getBills() {
        return this.bills.map(bill => bill.toJSON());
    }

    setBills(bills) {
        this.bills = bills;
    }

    addBill(id, total) {
        const foundBill = this.bills.find((bill) => bill.getId() === id);
    
        if (!foundBill) {
            this.bills.push(new Bill(id, total));
            return true;
        }
        
        return false;
    }

    removeBill(id) {
        const billsToKeep = this.bills.filter((bill) => bill.getId() !== id);
    
        if (this.bills.length > billsToKeep.length) {
            this.bills = billsToKeep;
            return true;
        }

        return false;
    }

    toJSON() {
        return {
            id: this.id,
            name: this.name,
            bills: this.bills.map(bill => bill.toJSON())
        };
    }

    static fromJSON(client) {
        const bills = client.bills.map(bill => Bill.fromJSON(bill));
        const newClient = new Client(client.id, client.name);
        newClient.setBills(bills);

        return newClient;
    }
}

module.exports = Client;