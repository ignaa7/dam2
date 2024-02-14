import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Place } from 'src/models/place/place';
import { PlaceHttpService } from '../place-http-service/place-http.service';
import { StorageService } from '../storage-service/storage.service';
import { UserHttpService } from '../user-http-service/user-http.service';

@Injectable({
  providedIn: 'root'
})
export class PlacesService {
  private _places: Place[] = [];
  private _filteredPlaces: Place[] = [];
  private _fakePlaces = [
    new Place(
      'Manhattan Mansion',
      'In the heart of New York City.',
      'https://lonelyplanetimages.imgix.net/mastheads/GettyImages-538096543_medium.jpg?sharp=10&vib=20&w=1200',
      149.99
    ),
    new Place(
      "L'Amour Toujours",
      'A romantic place in Paris!',
      'https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Paris_Night.jpg/1024px-Paris_Night.jpg',
      189.99
    ),
    new Place(
      'The Foggy Palace',
      'Not your average city trip!',
      'https://upload.wikimedia.org/wikipedia/commons/0/01/San_Francisco_with_two_bridges_and_the_fog.jpg',
      99.99
    )
  ];

  private _subject: BehaviorSubject<any[]>;


  constructor(private placeHttpService: PlaceHttpService, private userHttpService: UserHttpService, private storageService: StorageService) {
    this._subject = new BehaviorSubject<any[]>(this._filteredPlaces);
  }

  public async loadPlaces() : Promise<void> {
    this._places = await this.placeHttpService.getPlaces();
    
    if (this._places.length == 0) {
      let token = await this.storageService.getFromStorage('token');
      this._fakePlaces.forEach(async place => this.placeHttpService.addPlace(place, token!));
    }
  }

  getObservable() {
    return this._subject.asObservable();
  }

  public async filterPlaces(page: string): Promise<void> {
    let token = await this.storageService.getFromStorage('token');
    let user: any = await this.userHttpService.getMyUser(token!);

    if (page === 'discover') {
      this._filteredPlaces = this._places.filter(place => place.owner !== user._id && !place.renter);
    }
    else if (page === 'offers') {
      this._filteredPlaces = this._places.filter(place => place.owner === user._id);
    }
    else if (page === 'bookings') {
      this._filteredPlaces = this._places.filter(place => place.renter === user._id);
    }

    this._subject.next(this._filteredPlaces);

  }

  public async addPlace(title: string, description: string, imageUrl: string, price: number) : Promise<void> {
    let token = await this.storageService.getFromStorage('token');
    let place = new Place(title, description, imageUrl, price);

    await this.placeHttpService.addPlace(place, token!);
    await this.loadPlaces();
  }

  public async editPlace(id: string, title: string, description: string, imageUrl: string, price: number) : Promise<void> {
    let token = await this.storageService.getFromStorage('token');
    let place = new Place(title, description, imageUrl, price);
    place._id = id;

    await this.placeHttpService.editPlace(place, token!);
    await this.loadPlaces();
  }

  public getPlace(id: string) : any | undefined {
    let place: Place | undefined = this._places.find(place => place._id === id);
    if (place) {
      return {
        _id: place._id,
        title: place.title,
        description: place.description,
        imageUrl: place.imageUrl,
        price: place.price
      }
    }

    return undefined;
  }

  public async bookPlace(id: string) : Promise<void> {
    let token = await this.storageService.getFromStorage('token');

    await this.placeHttpService.bookPlace(id, token!);
    await this.loadPlaces();
  }

  public async removeBooking(id: string) : Promise<void> {
    let token = await this.storageService.getFromStorage('token');

    await this.placeHttpService.removeBooking(id, token!);
    await this.loadPlaces();
  }
}
