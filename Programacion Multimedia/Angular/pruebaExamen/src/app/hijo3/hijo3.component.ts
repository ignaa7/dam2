import { Component, ElementRef, Renderer2, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-hijo3',
  templateUrl: './hijo3.component.html',
  styleUrls: ['./hijo3.component.css']
})
export class Hijo3Component {
  texto!: string;

  @ViewChild('etiquetaTexto') etiquetaTexto!: ElementRef;

  constructor(private activatedRoute: ActivatedRoute, private renderer: Renderer2) {
    activatedRoute.queryParams.subscribe(texto => this.texto = texto['texto']);

    renderer.addClass(this.etiquetaTexto.nativeElement, 'clase')
    this.etiquetaTexto.nativeElement.class = 'clase'
  }

}
