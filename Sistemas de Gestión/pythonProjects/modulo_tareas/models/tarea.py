from odoo import models, fields, api

class Tarea(models.Model):
    _name = 'modulo.tarea'
    _description = 'Modelo de tarea'

    name = fields.Char(string='Nombre de la tarea', required=True)
    description = fields.Text(string='Descripción', required=True)