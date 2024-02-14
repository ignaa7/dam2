import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-bookings',
  templateUrl: './bookings.page.html',
  styleUrls: ['./bookings.page.scss'],
})
export class BookingsPage implements OnInit {
  observable: Observable<any>;
  isAlertOpen: boolean = false;
  alertButtons = ['Aceptar'];

  constructor(
    private placesService: PlacesService,
    private router: Router
  ) {
    this.observable = placesService.getObservable();
  }

  ngOnInit() {
  }

  ionViewWillEnter() {
    this.placesService.filterPlaces('bookings');
  }

  async deleteBooking(place: any) {
    await this.placesService.removeBooking(place._id);
    this.placesService.filterPlaces('bookings');
    this.setAlertOpen(true);
  }

  setAlertOpen(isOpen: boolean) {
    this.isAlertOpen = isOpen;
  }

}
