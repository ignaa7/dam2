import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';

@Component({
  selector: 'contacto-component',
  templateUrl: './contacto-component.component.html',
  styleUrls: ['./contacto-component.component.css']
})
export class ContactoComponentComponent {
  @Input() contacto! : Contacto;
  @Output() eventoEliminarContacto = new EventEmitter<Contacto>();
  @Output() eventoEditarContacto = new EventEmitter<Contacto>();

  enviarContactoAEliminar() {
    this.eventoEliminarContacto.emit(this.contacto);
  }

  enviarContactoAEditar() {
    this.eventoEditarContacto.emit(this.contacto);
  }
}
