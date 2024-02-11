import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom } from 'rxjs';
import { StorageService } from '../storage-service/storage.service';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  private apiUrl = 'http://localhost:3000';

  constructor(private http: HttpClient, private storageService: StorageService) {
  }

  async post(endpoint: string, data: any): Promise<any> {
    return await firstValueFrom(this.http.post<any>(`${this.apiUrl}/${endpoint}`, data, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': await this.storageService.getFromStorage('token') ?? ''
      })
    }));
  }

  async get(endpoint: string): Promise<any> {
    return await firstValueFrom(this.http.get<any>(`${this.apiUrl}/${endpoint}`, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': await this.storageService.getFromStorage('token') ?? ''
      })
    }));
  }

  async patch(endpoint: string, data: any): Promise<any> {
    return await firstValueFrom(this.http.patch<any>(`${this.apiUrl}/${endpoint}`, data, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': await this.storageService.getFromStorage('token') ?? ''
      })
    }));
  }

  async delete(endpoint: string): Promise<any> {
    return await firstValueFrom(this.http.delete<any>(`${this.apiUrl}/${endpoint}`, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': await this.storageService.getFromStorage('token') ?? ''
      })
    }));
  }
}
