import { Directive, ElementRef, HostBinding, HostListener, Renderer2 } from '@angular/core';

@Directive({
  selector: '[directiva]'
})
export class DirectivaDirective {

  constructor(private element: ElementRef, private renderer: Renderer2) { }

  @HostBinding('class.rojo') pulsado: boolean = false;

  @HostListener('mouseover') onMouseOver() {
    this.renderer.addClass(this.element.nativeElement, 'negrita');
    this.pulsado = true;
  }

  @HostListener('mouseout') onMouseOut() {
    this.renderer.removeClass(this.element.nativeElement, 'negrita');
    this.pulsado = false;
  }

}