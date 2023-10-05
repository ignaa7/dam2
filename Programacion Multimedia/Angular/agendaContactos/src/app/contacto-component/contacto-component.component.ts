import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';

@Component({
  selector: 'app-contacto-component',
  templateUrl: './contacto-component.component.html',
  styleUrls: ['./contacto-component.component.css']
})
export class ContactoComponentComponent {
  @Input('contacto') contacto! : Contacto;
  @Output() eventoEliminarContacto = new EventEmitter<Contacto>();

  enviarContactoAEliminar() {
    this.eventoEliminarContacto.emit(this.contacto);
  }
}
