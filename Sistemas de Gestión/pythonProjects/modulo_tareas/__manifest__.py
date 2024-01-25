{
    'name': "modulo_tareas",
    'version': '1.0',
    'depends': ['base'],
    'author': "Ignacio",
    'category': 'Tareas',
    'description': "Módulo de gestión de tareas",
    'data': [
        'views/tarea_vista_arbol.xml',
        'views/tarea_vista_formulario.xml',
        'views/menu.xml',
        'views/actions.xml',
    ],
    'installable': True,
    'auto_install': False,
    'application': True,
}