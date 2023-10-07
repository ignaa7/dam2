import { Component, Output } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'agendaContactos';

  contactos : Contacto[] = [];
  contactoAEditar : Contacto | undefined;
  edicion : boolean = false;

  agregarContacto(contacto : Contacto) {
    this.contactos.push(contacto);
  }

  eliminarContacto(contacto : Contacto) {
    if (!this.edicion) this.contactos.splice(this.contactos.indexOf(contacto), 1);
  }

  comenzarEdicionContacto(contacto : Contacto) {
    if (!this.edicion) {
      this.contactoAEditar = contacto;
      this.edicion = true;
    }
  }

  editarContacto(datosContacto : any) {
    this.contactoAEditar!.nombre = datosContacto.nombre;
    this.contactoAEditar!.numero = datosContacto.numero;
    this.contactoAEditar = undefined;
    this.edicion = false;
  }
}
