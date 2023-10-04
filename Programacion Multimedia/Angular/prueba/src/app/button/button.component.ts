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
  btnTexto : string = 'Mostrar imagen';

  constructor(){}

  cambiarImagen() {
    this.buttonPressed = !this.buttonPressed;
    this.buttonPressed ? this.btnTexto = 'Ocultar imagen' : this.btnTexto = 'Mostrar imagen';
  }

  setDivColor(color : string) {
    this.imagen.setColorFondo(color);
  }
}
