import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/services/authentication-service/authentication-service.service';

@Component({
  selector: 'login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  username: string = '';
  password: string = '';

  constructor(private router: Router, private authenticationService: AuthenticationService) {}

  goToLoggedPage() {
    this.authenticationService.logIn(this.username, this.password);

    this.router.navigate(['/loggedPage'], {
      queryParams: {username: this.username, password: this.password}
    });
  }
}
