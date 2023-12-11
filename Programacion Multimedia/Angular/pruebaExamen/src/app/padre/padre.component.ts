import { Component } from '@angular/core';

@Component({
  selector: 'padre',
  templateUrl: './padre.component.html',
  styleUrls: ['./padre.component.css']
})
export class PadreComponent {
  textoPadre: string = '';

  mandarTexto(texto: string) {
    this.textoPadre = texto;
  }
}
