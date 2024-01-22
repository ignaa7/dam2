const ContactsDAO = require('../daos/contacts-dao.js');
const Contact = require('../classes/contact.js');

class Service {
    constructor() {
        this.contactsDAO = new ContactsDAO();
    }

    async addContact(contact) {
        return await this.contactsDAO.addContact(new Contact(
            contact.dni,
            contact.name,
            contact.age,
            contact.phoneNumber
            ));
    }

    async getContact(id) {
        return await this.contactsDAO.getContact(id);
    }

    async updateContact(id, contact) {
        return await this.contactsDAO.updateContact(id, contact);
    }

    async deleteContact(id) {
        return await this.contactsDAO.deleteContact(id);
    }
}

module.exports = Service;