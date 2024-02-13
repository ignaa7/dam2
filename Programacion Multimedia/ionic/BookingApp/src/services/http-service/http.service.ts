import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  private apiUrl = 'http://localhost:3000';

  constructor(private http: HttpClient) {
  }

  async post(endpoint: string,header: any, data?: any): Promise<any> {
    return await firstValueFrom(this.http.post<any>(`${this.apiUrl}/${endpoint}`, data, header));
  }

  async get(endpoint: string, header: any): Promise<any> {
    return await firstValueFrom(this.http.get<any>(`${this.apiUrl}/${endpoint}`, header));
  }

  async patch(endpoint: string, header: any, data: any): Promise<any> {
    return await firstValueFrom(this.http.patch<any>(`${this.apiUrl}/${endpoint}`, data, header));
  }

  async delete(endpoint: string, header: any): Promise<any> {
    return await firstValueFrom(this.http.delete<any>(`${this.apiUrl}/${endpoint}`, header));
  }
}
