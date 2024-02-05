import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Place } from 'src/models/place/place';

@Injectable({
  providedIn: 'root'
})
export class PlacesService {
  private _places: Place[] = [
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

  private _subject: BehaviorSubject<Object[]>;


  constructor() {
    this._subject = new BehaviorSubject<Object[]>(this.places);
  }

  getObservable() {
    return this._subject.asObservable();
  }

  public get places() : Object[] {
    return this.getPlacesCopy(this._places);
  }

  public getPlace(id: string) : Object | undefined {
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
