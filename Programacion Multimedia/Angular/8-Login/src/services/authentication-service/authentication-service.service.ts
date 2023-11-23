import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private isLoggedIn: boolean = false;

  logIn(username: string, password: string): void {
    if (username !== '' && password !== '') {
      this.isLoggedIn = true;
    }
  }

  isLoggedInUser(): boolean {
    return this.isLoggedIn;
  }
}
