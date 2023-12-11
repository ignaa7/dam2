import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'hijo2',
  templateUrl: './hijo2.component.html',
  styleUrls: ['./hijo2.component.css']
})
export class Hijo2Component {
  constructor(private router: Router) {}

  volver() {
    this.router.navigate(['padre']);
  }
}
