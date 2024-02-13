import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-offers',
  templateUrl: './offers.page.html',
  styleUrls: ['./offers.page.scss'],
})
export class OffersPage implements OnInit {
  observable: Observable<any>;

  constructor(private placesService: PlacesService) {
    this.observable = placesService.getObservable();
  }

  ngOnInit() {
  }

  ionViewWillEnter() {
    this.placesService.filterPlaces('offers');
  }
}
