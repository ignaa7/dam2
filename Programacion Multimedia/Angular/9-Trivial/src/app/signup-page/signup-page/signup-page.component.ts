import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'app-signup-page',
  templateUrl: './signup-page.component.html',
  styleUrls: ['./signup-page.component.css']
})
export class SignupPageComponent {
  constructor(private router: Router, private authService: AuthService) {}

  goToLoginPage() {
    this.router.navigate(['/loginPage']);
  }

  signUpUser() {
    a
  }
}
