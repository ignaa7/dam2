import { Injectable } from '@angular/core';
import { HttpService } from '../http-service/http.service';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserHttpService {

  constructor(private httpService: HttpService) { }

  async logIn(email: string, password: string) : Promise<string | null> {
    let data = {
      email,
      password
    };

    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    try {
      let response = await this.httpService.post('users/login', header, data);

      return response.token;
      
    } catch(error) {
      console.log(error);
      return null;
    }
  }

  async logOut(token: string): Promise<boolean> {
    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': token
      })
    };

    try {
      await this.httpService.post('users/logout', header);

      return true;
    } catch (error) {
      console.log(error);
      return false;
    }
  }

  async signUp(username: string, email: string, password: string, age: number): Promise<boolean> {
    let data = {
      name: username,
      email,
      password,
      age
    };

    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    try {
      await this.httpService.post('users/add', header, data);
      
      return true;

    } catch(error) {
      console.log(error);
      return false;
    }
  }

  async getMyUser(token: string): Promise<any> {
    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': token
      })
    };

    try {
      return await this.httpService.get('users/me', header);
    } catch (error) {
      console.log(error);
      return null;
    }
  }
}
