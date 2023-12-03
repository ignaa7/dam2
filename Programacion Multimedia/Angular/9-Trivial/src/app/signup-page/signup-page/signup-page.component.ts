import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'app-signup-page',
  templateUrl: './signup-page.component.html',
  styleUrls: ['./signup-page.component.css']
})
export class SignupPageComponent {
  public error: boolean = false;
  public errorText: string | undefined;

  constructor(private router: Router, private authService: AuthService) {}

  goToLoginPage() {
    this.router.navigate(['/loginPage']);
  }

  signUpUser(name: string, surnames: string, email: string, username: string, password: string) {
    if (name && surnames && email && username && password) {
      if (password.length >= 8) {
        if (this.authService.signUpUser(name, surnames, email, username, password)) {
          this.router.navigate(['/loginPage']);
        } else {
          this.error = true;
          this.errorText = "Este usuario ya existe";
        }
      } else {
        this.error = true;
        this.errorText = "Introduzca una contraseña de 8 caracteres como mínimo";
      }
    } else {
      this.error = true;
      this.errorText = "Rellene todos los campos";
    }
  }
}
