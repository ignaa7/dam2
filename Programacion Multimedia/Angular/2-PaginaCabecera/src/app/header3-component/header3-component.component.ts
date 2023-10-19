import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-header3-component',
  templateUrl: './header3-component.component.html',
  styleUrls: ['./header3-component.component.css']
})
export class Header3ComponentComponent {
  direccionImagen! : string;
  @ViewChild('childImage') childImage!: ElementRef;
}
