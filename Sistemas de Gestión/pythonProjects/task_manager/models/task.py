from odoo import models, fields, api

class Task(models.Model):
    _name = 'task_manager.task'
    _description = 'Task Manager'

    name = fields.Char(string="Task name", required=True)
    description = fields.Text(string="Description", required=True)
    creation_date = fields.Datetime(string="Creation date", required=True)
    end_date = fields.Datetime(string="End date", required=True)