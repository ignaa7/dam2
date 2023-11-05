import { Component } from '@angular/core';
import { Servicio } from 'src/servicio/servicio';

@Component({
  selector: 'principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent {
  private servicio : Servicio = new Servicio();
  libro : any;

  mostrarLibro(idLibro : any) {
    this.libro = this.servicio.getLibro(idLibro);
  }
}
