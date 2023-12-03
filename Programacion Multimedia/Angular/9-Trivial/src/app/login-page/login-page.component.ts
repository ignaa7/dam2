import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  public error: boolean = false;
  public errorText: string | undefined;
  
  constructor(private router: Router, private authService: AuthService) {}

  goToSignupPage() {
    this.router.navigate(['/signupPage']);
  }

  logInUser(username: string, password: string) {
    if (username && password) {
      if (password.length >= 8) {
        if (this.authService.logInUser(username, password)) {
          this.router.navigate(['/loginPage']);
        } else {
          this.error = true;
          this.errorText = "Usuario o contraseña incorrectos";
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
