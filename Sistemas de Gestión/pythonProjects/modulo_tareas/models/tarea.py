# models/tarea.py
from odoo import models, fields

class Tarea(models.Model):
    _name = 'mi_modulo.tarea'
    _description = 'Modelo de Tarea'

    name = fields.Char(string='Nombre de la tarea', required=True)
    description = fields.Text(string='Descripción')