import { Injectable } from '@angular/core';
import { UsersService } from '../users-service/users.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private usersService: UsersService) { }

  signUpUser(name: string, surnames: string, email: string, username: string, password: string): boolean {
    return this.usersService.addUser(name, surnames, email, username, password);
  }

  logInUser(username: string, password: string): boolean {
    let user: any = this.usersService.getUser(username);

    if (user) {
      if (user.password == password) {
        return true;
      }
    }

    return false;
  }
}
