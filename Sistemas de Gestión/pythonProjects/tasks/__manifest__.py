{
    'name': "tasks",
    'version': '1.0',
    'category': 'tasks',
    'depends': ['base'],
    'data': [
        'views/task_kanban_view.xml',
        'views/task_tree_view.xml',
        'views/task_form_view.xml',
        'views/person_tree_view.xml',
        'views/person_form_view.xml',
        'views/actions.xml',
        'views/menu.xml'
    ],
    'installable': True,
    'application': True,
    'auto_install': False
}