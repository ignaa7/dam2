import { Component, OnInit } from '@angular/core';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-discover',
  templateUrl: './discover.page.html',
  styleUrls: ['./discover.page.scss'],
})
export class DiscoverPage implements OnInit {
  loadedPlaces!: any[];

  constructor(
    private placesService: PlacesService,
  ) {}

  ngOnInit() {
    this.loadedPlaces = this.placesService.places;
  }
}
