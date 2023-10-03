import { Component } from '@angular/core';
import { ImagenOk } from 'src/classes/imagenOk/imagen-ok';

@Component({
  selector: 'buttonComponent',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent {
  imagen : ImagenOk = new ImagenOk('https://media.pronunciationstudio.com/2016/02/ok.png');
  texto : String = '';
  buttonPressed : boolean = false;
  divColor : string = this.imagen.getColorFondo();
  ruta = this.imagen.getRuta();

  constructor(){}

  mostrarTexto() {
    this.texto = 'Has pulsado el botón';
    this.buttonPressed = true;
  }

  setDivColor(color : string) {
    this.imagen.setColorFondo(color);
    this.divColor = this.imagen.getColorFondo();
  }
}
