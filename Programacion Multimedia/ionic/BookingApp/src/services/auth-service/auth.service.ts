import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private _userIsAuthenticated = false;

  get userIsAuthenticated() {
    return this._userIsAuthenticated;
  }

  constructor() { }

  logIn(username: string, password: string) {
    this._userIsAuthenticated = true;

    return this._userIsAuthenticated;
  }

  logOut() {
    this._userIsAuthenticated = false;
  }

  signUp(name: string, surnames: string, email: string, username: string, password: string): boolean {
    return true;
  }
}
