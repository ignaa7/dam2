import { Injectable } from '@angular/core';
import { User } from 'src/classes/user/user';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  private _users: User[];

  constructor() { 
    this._users = [
      new User('usuario', 'usuario', 'usuario@gmail.com', 'usuario', '12345678')
    ];
  }

  getUser(username: string): Object {
    let user: User | undefined = this._users.find(user => user.username == username);

    if (user) {
      return {
        username: user.username,
        password: user.password
      }
    }
    
    return {}
  }

  addUser(name: string, surnames: string, email: string, username: string, password: string): boolean {
    if (this._users.find(user => user.username == username)) {
      return false;
    } else {
      this._users.push(new User(name, surnames, email, username, password));
      return true;
    }
  }
}
