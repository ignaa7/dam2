# -*- coding: utf-8 -*-

from odoo import fields, models, api

class Task(models.Model):
    _name = "tasks.task"
    _description = "Tasks added to the module"

    name = fields.Char('Name', required=True)
    description = fields.Text('Description')
    creation_date = fields.Datetime('Creation date', default=lambda self: fields.Datetime.now())
    end_date = fields.Datetime('End date')
    assigned_people_count = fields.Integer(compute='_compute_total', store=True)
    people_ids = fields.Many2many('tasks.person')
    state = fields.Selection([('draft', 'Draft'), ('progress', 'In Progress'), ('done', 'Done')],
                             string='Status', default='draft', required=True)
    

    @api.depends("people_ids")
    def _compute_total(self):
        for record in self:
            record.assigned_people_count = len(record.people_ids) if record.people_ids else 0