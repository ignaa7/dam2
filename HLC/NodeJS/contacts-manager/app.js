const Service = require('./services/service.js');
const express = require('express');
const cors = require('cors');

const service = new Service();
const app = express();

app.use(cors());
app.use(express.json());

app.post('/crearcontacto', async (req, res) => {
    res.json(await service.addContact(req.body));
})

app.get('/buscarcontacto/:id', async (req, res) => {
    res.json(await service.getContact(req.params.id));
});

app.put('/actualizacontacto/:id', async (req, res) => {
    res.json(await service.updateContact(req.params.id, req.body));
});

app.delete('/borracontacto/:id', async (req, res) => {
    res.json(await service.deleteContact(req.params.id));
});

const port = 3000;
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});