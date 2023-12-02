import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UsersService } from 'src/services/users-service/users.service';

@Component({
  selector: 'app-signup-page',
  templateUrl: './signup-page.component.html',
  styleUrls: ['./signup-page.component.css']
})
export class SignupPageComponent {
  constructor(private router: Router, private usersService: UsersService) {}

  goToLoginPage() {
    this.router.navigate(['/loginPage']);
  }
}
