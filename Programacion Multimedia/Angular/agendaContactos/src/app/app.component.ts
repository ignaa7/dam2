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

  agregarContacto(contacto : Contacto) {
    this.contactos.push(contacto);
  }

  eliminarContacto(contacto : Contacto) {
    this.contactos.splice(this.contactos.indexOf(contacto), 1);
  }
}
