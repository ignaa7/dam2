import { Injectable } from '@angular/core';
import { HttpService } from '../http-service/http.service';
import { StorageService } from '../storage-service/storage.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private httpService: HttpService, private storageService: StorageService) {
   }

   async hasToken(): Promise<boolean> {
    return await this.storageService.getFromStorage('token') ? true : false;
   }

  async logIn(email: string, password: string): Promise<boolean> {
    try {
      let response = await this.httpService.post('users/login', {
        email,
        password
      });

      await this.storageService.setOnStorage('token', response.token);
      return true;
      
    } catch(error) {
      return false;
    }
  }

  async logOut(): Promise<void> {
    await this.httpService.post('users/logout', {});

    await this.storageService.removeFromStorage('token');
  }

  async signUp(username: string, email: string, password: string, age: number): Promise<boolean> {
    try {
      let response = await this.httpService.post('users', {
        name: username,
        email,
        password,
        age
      });

      await this.storageService.setOnStorage('token', response.token);
      return true;

    } catch(error: any) {
      return false;
    }
  }
}
