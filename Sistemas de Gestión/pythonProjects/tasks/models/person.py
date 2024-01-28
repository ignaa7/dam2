# -*- coding: utf-8 -*-

from odoo import fields, models, api

class Person(models.Model):
    _name = "tasks.person"
    _description = "People added and assigned to one or multiple tasks"

    name = fields.Char('Name', required=True)
    age = fields.Integer('Age')
    assigned_tasks_count = fields.Integer(compute='_compute_total', store=True)
    tasks_ids = fields.Many2many('tasks.task')

    @api.depends("tasks_ids")
    def _compute_total(self):
        for record in self:
            record.assigned_tasks_count = len(record.tasks_ids) if record.tasks_ids else 0

    def delete_person(self):
        self.ensure_one()
        self.unlink()
        return {
            'type': 'ir.actions.act_window',
            'res_model': 'tasks.person',
            'view_mode': 'tree,form',
            }