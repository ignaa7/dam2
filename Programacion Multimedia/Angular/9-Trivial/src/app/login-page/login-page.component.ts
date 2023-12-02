import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  constructor(private router: Router, private authService: AuthService) {}

  goToSignupPage() {
    this.router.navigate(['/signupPage']);
  }
}
