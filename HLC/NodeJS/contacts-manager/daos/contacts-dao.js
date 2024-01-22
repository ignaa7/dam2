const { MongoClient, ObjectId } = require('mongodb');

class ContactsDAO {
    constructor() {
        this.url = 'mongodb://127.0.0.1:27017';
        this.db = '';
        this.connect();
    }

    async connect() {
        try {
            let client = await MongoClient.connect(this.url);
            this.db = client.db('contacts_db');
        }
        catch(error) {
            console.log(error);
        }
    }

    async addContact(contact) {
        try {
            return await this.db.collection('contacts').insertOne(contact);
        }
        catch(error) {
            return {
                error: error.message
            };
        }
    }

    async getContact(id) {
        try {
            return await this.db.collection('contacts').findOne({_id: new ObjectId(id)});
        }
        catch(error) {
            return {
                error: error.message};
        }
    }

    async updateContact(id, contact) {
        try {
            return await this.db.collection('contacts').updateOne({_id: new ObjectId(id)}, {$set: contact});
        }
        catch(error) {
            return {
                error: error.message
            };
        }
    }

    async deleteContact(id) {
        try {
            return await this.db.collection('contacts').deleteOne({_id: new ObjectId(id)});
        }
        catch(error) {
            return {
                error: error.message
            };
        }
    }
}

module.exports = ContactsDAO;