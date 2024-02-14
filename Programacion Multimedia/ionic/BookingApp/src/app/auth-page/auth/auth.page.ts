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

  async logInUser(email: string, password: string) {
    if (email && password) {
      if (password.length >= 8) {
        let isCorrect: boolean = await this.authService.logIn(email, password);
        if (isCorrect) {
          this.error = false;
          this.errorText = "";
          this.router.navigateByUrl('/main/discover');
        } else {
          this.error = true;
          this.errorText = "Invalid email or password";
        }
      } else {
        this.error = true;
        this.errorText = "Your password must be at least 8 characters long";
      }
    } else {
      this.error = true;
      this.errorText = "Please fill in all fields";
    }
  }

  async signUpUser(username: string, email: string, password: string, age: string) {
    if (username && email && password && age) {
      if (password.length >= 8) {
        if (await this.authService.signUp(username, email, password, parseInt(age))) {
          this.error = false;
          this.errorText = "";
          this.login = true;
        } else {
          this.error = true;
          this.errorText = "This user already exists";
        }
      } else {
        this.error = true;
        this.errorText = "Your password must be at least 8 characters long";
      }
    } else {
      this.error = true;
      this.errorText = "Please fill in all fields";
    }
  }

  goToSignupPage() {
    this.login = false;
  }

  goToLoginPage() {
    this.login = true;
  }

}
