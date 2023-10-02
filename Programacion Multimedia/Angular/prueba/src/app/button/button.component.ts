import { Component } from '@angular/core';

@Component({
  selector: 'buttonComponent',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent {
  texto : String = '';
  buttonPressed : boolean = false;
  divColor : string = '';

  constructor(){}

  mostrarTexto() {
    this.texto = 'Has pulsado el botón';
    this.buttonPressed = true;
  }

  setDivColor(color : string) {
    this.divColor = color;
  }
}
