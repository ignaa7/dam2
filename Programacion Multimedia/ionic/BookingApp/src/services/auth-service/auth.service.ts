import { Injectable } from '@angular/core';
import { StorageService } from '../storage-service/storage.service';
import { UserHttpService } from '../user-http-service/user-http.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private userHttpService: UserHttpService, private storageService: StorageService) {
   }

   async hasToken(): Promise<boolean> {
    return await this.storageService.getFromStorage('token') ? true : false;
   }

  async logIn(email: string, password: string): Promise<boolean> {
    let token = await this.userHttpService.logIn(email, password);

    if (token) {
      await this.storageService.setOnStorage('token', token);
      return true;
    }
    else {
      return false;
    }
    
  }

  async logOut(): Promise<void> {
    let token = await this.storageService.getFromStorage('token');

    if (await this.userHttpService.logOut(token!)) {
      await this.storageService.removeFromStorage('token');
    }
  }

  async signUp(username: string, email: string, password: string, age: number): Promise<boolean> {
    return await this.userHttpService.signUp(username, email, password, age);
  }
}
