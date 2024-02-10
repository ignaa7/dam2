import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.page.html',
  styleUrls: ['./main.page.scss'],
})
export class MainPage implements OnInit {

  constructor(
    private authService: AuthService,
    private placesService: PlacesService,
    private router: Router
    ) {
      placesService
     }

  ngOnInit() {
  }

  onLogout() {
    this.authService.logOut();
    this.router.navigateByUrl('/auth');
  }

}
