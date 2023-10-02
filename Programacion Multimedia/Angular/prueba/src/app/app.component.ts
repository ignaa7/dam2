import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  textos : string[] = [];

  constructor() {
    for (let i = 1; i <= 3; i++) {
      this.textos.push(`patata${i}`);
    }
  }
}
