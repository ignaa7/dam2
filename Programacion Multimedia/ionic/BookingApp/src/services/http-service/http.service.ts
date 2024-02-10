import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  private apiUrl = 'https://localhost:3000';
  private jwtToken = '';

  constructor(private http: HttpClient) { }

  async post(endpoint: string, data: any): Promise<Observable<any>> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${this.jwtToken}`
    });

    const response: any = await this.http.post<any>(`${this.apiUrl}/${endpoint}`, data, { headers });

    if (this.jwtToken === '' && !response.message) {
      this.jwtToken = response.token;
    }

    return response;
  }

  async get(endpoint: string, data: any): Promise<Observable<any>> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${this.jwtToken}`
    });

    const response: any = await this.http.post<any>(`${this.apiUrl}/${endpoint}`, data, { headers });

    if (this.jwtToken === '' && !response.message) {
      this.jwtToken = response.token;
    }

    return response;
  }
}
