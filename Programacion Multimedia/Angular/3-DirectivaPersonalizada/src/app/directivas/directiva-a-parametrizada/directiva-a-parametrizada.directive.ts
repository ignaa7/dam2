import { Directive, ElementRef, HostListener, Input, Renderer2 } from '@angular/core';

@Directive({
  selector: '[directivaAParametrizada]'
})
export class DirectivaAParametrizadaDirective {

  @Input('directivaAParametrizada') datos: any = {
    colorBorde: 'green',
    texto: 'https://angular.io/'
  };

  constructor(private element: ElementRef, private renderer: Renderer2) {}

  ngOnInit() {
    this.renderer.setProperty(this.element.nativeElement, 'textContent', this.datos.texto);
  }

  @HostListener('mouseenter') onMouseEnter() {
    this.renderer.setStyle(this.element.nativeElement, 'border', `1px solid ${this.datos.colorBorde}`);
    this.renderer.setStyle(this.element.nativeElement, 'text-transform', `uppercase`);
  }

  @HostListener('mouseout') onMouseOut() {
    this.renderer.removeStyle(this.element.nativeElement, 'border');
    this.renderer.removeStyle(this.element.nativeElement, 'text-transform');
  }
}
