import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.page.html',
  styleUrls: ['./auth.page.scss'],
})
export class AuthPage implements OnInit {
  public error: boolean = false;
  public errorText: string | undefined;
  public login: boolean = true;

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit() {
  }

  logInUser(username: string, password: string) {
    if (username && password) {
      if (password.length >= 8) {
        if (this.authService.logIn(username, password)) {
          this.error = false;
          this.errorText = "";
          this.router.navigateByUrl('/main/discover');
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

  signUpUser(name: string, surnames: string, email: string, username: string, password: string) {
    if (name && surnames && email && username && password) {
      if (password.length >= 8) {
        if (this.authService.signUp(name, surnames, email, username, password)) {
          this.login = true;
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

  goToSignupPage() {
    this.login = false;
  }

  goToLoginPage() {
    this.login = true;
  }

}
