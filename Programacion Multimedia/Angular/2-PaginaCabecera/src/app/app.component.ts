import { Component, ViewChild } from '@angular/core';
import { Header3ComponentComponent } from './header3-component/header3-component.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = '2-PaginaCabecera';

  direccionImagen : string = '../assets/logo.png';

  @ViewChild(Header3ComponentComponent) cabecera3! : Header3ComponentComponent;

  ngAfterViewInit() {
    this.cabecera3.childImage.nativeElement.src = this.direccionImagen;
  }
}
