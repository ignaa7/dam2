import { Component } from '@angular/core';

@Component({
  selector: 'buttonComponent',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent {
  texto : String = '';
  constructor(){}

  mostrarTexto() {
    this.texto = 'Has pulsado el botón';
  }
}
