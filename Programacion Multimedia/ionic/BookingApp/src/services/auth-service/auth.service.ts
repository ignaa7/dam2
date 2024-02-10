import { Injectable } from '@angular/core';
import { HttpService } from '../http-service/http.service';
import { StorageService } from '../storage-service/storage.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private _userIsAuthenticated = false;

  get userIsAuthenticated() {
    return this._userIsAuthenticated;
  }

  constructor(private httpService: HttpService, private storageService: StorageService) { }

  async logIn(email: string, password: string): Promise<boolean> {
    try {
      let response = await this.httpService.post('users/login', {
        email,
        password
      });

      this._userIsAuthenticated = true;
      await this.storageService.setOnStorage(response.token);
      return true;
      
    } catch(error) {
      this._userIsAuthenticated = false;
      return false;
    }
  }

  async logOut(): Promise<void> {
    await this.httpService.post('users/logout', {});

    this._userIsAuthenticated = false;
    await this.storageService.clearStorage();
  }

  async signUp(username: string, email: string, password: string, age: number): Promise<boolean> {
    try {
      let response = await this.httpService.post('users', {
        name: username,
        email,
        password,
        age
      });

      this._userIsAuthenticated = true;
      await this.storageService.setOnStorage(response.token);
      return true;

    } catch(error) {
      this._userIsAuthenticated = false;
      return false;
    }
  }
}
