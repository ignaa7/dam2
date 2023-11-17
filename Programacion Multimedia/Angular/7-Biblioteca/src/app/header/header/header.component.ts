import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  @Output() logInEvent = new EventEmitter();

  callLogIn(): void {
    this.logInEvent.emit();
  }
}
