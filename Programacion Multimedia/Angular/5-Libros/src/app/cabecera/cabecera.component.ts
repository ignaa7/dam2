import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'cabecera',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent {
  @Output() eventoMostrarLibro = new EventEmitter<Object>();

  enviarIdLibro(id : number) {
    this.eventoMostrarLibro.emit(id);
  }
}
