import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ModalController, NavController } from '@ionic/angular';
import { PlacesService } from 'src/services/places-service/places.service';
import { CreateBookingComponent } from './create-booking-component/create-booking/create-booking.component';

@Component({
  selector: 'app-place-details',
  templateUrl: './place-details.page.html',
  styleUrls: ['./place-details.page.scss'],
})
export class PlaceDetailsPage implements OnInit {
  place: any;
  isAlertOpen: boolean = false;
  alertButtons = ['Aceptar'];

  constructor(
    private navCtrl: NavController,
    private route: ActivatedRoute,
    private placesService: PlacesService,
    private modalCtrl: ModalController,
    private router: Router,
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe(paramMap => {
      if (!paramMap.has('placeId')) {
        this.navCtrl.navigateBack('/main/discover');
        return;
      }
      this.place = this.placesService.getPlace(paramMap.get('placeId')!);
    });
  }

  async onBookPlace() {
      try {
        const modal = await this.modalCtrl.create({
          component: CreateBookingComponent,
          componentProps: { selectedPlace: this.place }
        });

        modal.present();
        let resultData = await modal.onDidDismiss();

        if (resultData.role === 'confirm') {
          this.placesService.bookPlace(this.place._id);
          this.setAlertOpen(true);
          this.router.navigateByUrl('/main/discover');
        }
      } catch(e) {
        console.log(e);
      }
  }

  setAlertOpen(isOpen: boolean) {
    this.isAlertOpen = isOpen;
  }
}
