import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Place } from 'src/models/place/place';
import { HttpService } from '../http-service/http.service';
import { User } from 'src/models/user/user';

@Injectable({
  providedIn: 'root'
})
export class PlacesService {
  private _places: Place[] = [];
  private _fakePlaces = [
    new Place(
      'p1',
      'Manhattan Mansion',
      'In the heart of New York City.',
      'https://lonelyplanetimages.imgix.net/mastheads/GettyImages-538096543_medium.jpg?sharp=10&vib=20&w=1200',
      149.99
    ),
    new Place(
      'p2',
      "L'Amour Toujours",
      'A romantic place in Paris!',
      'https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Paris_Night.jpg/1024px-Paris_Night.jpg',
      189.99
    ),
    new Place(
      'p3',
      'The Foggy Palace',
      'Not your average city trip!',
      'https://upload.wikimedia.org/wikipedia/commons/0/01/San_Francisco_with_two_bridges_and_the_fog.jpg',
      99.99
    )
  ];

  private _subject: BehaviorSubject<any[]>;


  constructor(private httpService: HttpService) {
    this._subject = new BehaviorSubject<any[]>(this._places);
  }

  public async loadPlaces() : Promise<void> {
    this._places = await this.httpService.get('places');
    console.log(this._places.length)
    if (this._places.length == 0) {
      this._fakePlaces.forEach(async place => await this.httpService.post('places/add', place));
    }

    this._subject.next(this._places);
  }

  getObservable() {
    return this._subject.asObservable();
  }

  public get places() : any[] {
    return this.getPlacesCopy(this._places);
  }

  public async filterPlaces(page: string): Promise<void> {
    if (page === 'discover') {
      this._places = this._places.filter(async place => place.owner !== (await this.httpService.get('users/me'))._id);
    }
    else if (page === 'offers') {
      this._places = this._places.filter(async place => place.owner === (await this.httpService.get('users/me'))._id);
    }
    else if (page === 'bookings') {
      this._places = this._places.filter(async place => place.renter === (await this.httpService.get('users/me'))._id);
    }

    this._subject.next(this._places);
  }

  public getPlace(id: string) : any | undefined {
    let place: Place | undefined = this._places.find(place => place.id === id);
    if (place) {
      return {
        id: place.id,
        title: place.title,
        description: place.description,
        imageUrl: place.imageUrl,
        price: place.price
      }
    }

    return undefined;
  }

  private getPlacesCopy(places : Place[]): Object[] {
    let placesCopy : Object[] = [];
    
    places.forEach(place => {
      placesCopy.push({
        id: place.id,
        title: place.title,
        description: place.description,
        imageUrl: place.imageUrl,
        price: place.price
      })
    });
    return placesCopy;
  }
}
