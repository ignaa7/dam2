import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  public error = false;
  
  constructor(private router: Router, private authService: AuthService) {}

  goToSignupPage() {
    this.router.navigate(['/signupPage']);
  }

  logInUser(username: string, password: string) {
    if (password.length >= 8) {
      if (this.authService.logInUser(username, password)) {
        this.router.navigate(['/loginPage']);
      }
    } else {
      this.error = true;
    }
  }
}
