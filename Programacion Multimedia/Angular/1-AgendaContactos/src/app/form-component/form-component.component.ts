import { Component, EventEmitter, Output, Input } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';

@Component({
  selector: 'app-form-component',
  templateUrl: './form-component.component.html',
  styleUrls: ['./form-component.component.css']
})
export class FormComponentComponent {
  @Output() eventoNuevoContacto = new EventEmitter<Contacto>();
  @Output() eventoEditarContacto = new EventEmitter<Object>();
  @Input() nombre : string | undefined;
  @Input() numero : string | undefined;
  @Input() edicion : boolean = false;

  enviarDatos(){
    if (this.nombre != null && this.nombre != '' && this.numero != null && this.numero != '') {
      this.edicion
      ? this.eventoEditarContacto.emit({nombre : this.nombre, numero : this.numero})
      : this.eventoNuevoContacto.emit(new Contacto(this.nombre, this.numero));

      this.nombre = undefined;
      this.numero = undefined;
    }
  }
}
