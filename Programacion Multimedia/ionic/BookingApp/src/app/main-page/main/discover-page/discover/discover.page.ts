import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-discover',
  templateUrl: './discover.page.html',
  styleUrls: ['./discover.page.scss'],
})
export class DiscoverPage implements OnInit {
  observable: Observable<any>;

  constructor(
    private placesService: PlacesService,
  ) {
    placesService.loadPlaces();
    this.observable = placesService.getObservable();
  }

  ngOnInit() {
  }
}
