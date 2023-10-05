import { Component, EventEmitter, Output } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';

@Component({
  selector: 'app-form-component',
  templateUrl: './form-component.component.html',
  styleUrls: ['./form-component.component.css']
})
export class FormComponentComponent {
  @Output() eventoNuevoContacto = new EventEmitter<Contacto>();
  nombre : string = '';
  numero : string = '';

  enviarDatos(){
    this.eventoNuevoContacto.emit(new Contacto(this.nombre, this.numero));
    this.nombre = '';
    this.numero = '';
  }
}
