class Bill {
    constructor(id, total) {
        this.id = id;
        this.total = total;
    }

    getId() {
        return this.id;
    }

    getTotal() {
        return this.total;
    }

    toJSON() {
        return {
            id: this.id,
            total: this.total
        }
    }

    static fromJSON(bill) {
        return new Bill(bill.id, bill.total);
    }
}

module.exports = Bill;