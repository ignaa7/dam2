import { Component, OnInit } from '@angular/core';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-offers',
  templateUrl: './offers.page.html',
  styleUrls: ['./offers.page.scss'],
})
export class OffersPage implements OnInit {
  offers!: any[];

  constructor(private placesService: PlacesService) { }

  ngOnInit() {
    this.offers = this.placesService.places;
  }
}
