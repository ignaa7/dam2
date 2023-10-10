import { Component } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';
import { Servicio } from 'src/service/servicio';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'agendaContactos';

  servicio : Servicio = new Servicio();

  contactoAEditar : Contacto | undefined;
  edicion : boolean = false;

  agregarContacto(contacto : Contacto) {
    this.servicio.addContacto(contacto);
  }

  eliminarContacto(contacto : Contacto) {
    if (!this.edicion) this.servicio.removeContacto(contacto);
  }

  comenzarEdicionContacto(contacto : Contacto) {
    if (!this.edicion) {
      this.contactoAEditar = contacto;
      this.edicion = true;
    }
  }

  editarContacto(datosContacto : any) {
    this.servicio.editContacto(this.contactoAEditar!, datosContacto);
    this.contactoAEditar = undefined;
    this.edicion = false;
  }
}
