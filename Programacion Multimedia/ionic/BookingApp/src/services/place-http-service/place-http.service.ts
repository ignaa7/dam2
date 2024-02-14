import { Injectable } from '@angular/core';
import { HttpService } from '../http-service/http.service';
import { Place } from 'src/models/place/place';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PlaceHttpService {

  constructor(private httpService: HttpService) { }

  async getPlaces() : Promise<any> {
    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    
    try {
      return await this.httpService.get('places', header);
    } catch (error) {
      console.log(error);
      return null;
    }
  }

  async addPlace(place: Place, token: string) : Promise<boolean> {
    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': token
      })
    };

    try {
      await this.httpService.post('places/add', header, place);

      return true;
    } catch (error) {
      console.log(error);
      return false;
    }
  }

  async bookPlace(id: string, token: string) : Promise<boolean> {
    let header = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': token
      })
    };

    let data = {
      id
    }

    try {
      await this.httpService.post('places/book', header, data);

      return true;
    } catch (error) {
      console.log(error);
      return false;
    }
  }
}
