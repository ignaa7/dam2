import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-bookings',
  templateUrl: './bookings.page.html',
  styleUrls: ['./bookings.page.scss'],
})
export class BookingsPage implements OnInit {
  observable: Observable<any>;

  constructor(
    private placesService: PlacesService,
  ) {
    this.observable = placesService.getObservable();
  }

  ngOnInit() {
  }

}
