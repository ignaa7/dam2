import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UsersService } from 'src/services/users-service/users.service';

@Component({
  selector: 'login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  constructor(private router: Router, private usersService: UsersService) {}

  goToSignupPage() {
    this.router.navigate(['/signupPage']);
  }
}
