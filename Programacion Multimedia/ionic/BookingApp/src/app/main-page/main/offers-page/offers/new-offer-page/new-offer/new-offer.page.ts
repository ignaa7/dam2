import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PhotoService } from 'src/services/photo-service/photo.service';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-new-offer',
  templateUrl: './new-offer.page.html',
  styleUrls: ['./new-offer.page.scss'],
})
export class NewOfferPage implements OnInit {
  public error: boolean = false;
  public errorText: string | undefined;
  public imageUrl: string | undefined;
  public actionSheetButtons = [
    {
      text: 'Cámara',
      handler: () => this.pickFromCamera(),
    },
    {
      text: 'Galería',
      handler: () => this.pickFromGallery(),
    },
    {
      text: 'Cancelar',
      role: 'cancel',
      data: {
        action: 'cancel',
      },
    },
  ];

  constructor(
    private placesService: PlacesService,
    private router: Router,
    private photoService: PhotoService
  ) { }

  ngOnInit() {
  }

  async addOffer(title: string, description: string, price: string) {
    if (title && description && this.imageUrl && price) {
      this.error = false;
      this.errorText = "";
      await this.placesService.addPlace(title, description, this.imageUrl, parseFloat(price));
      this.router.navigateByUrl('/main/offers');
    } else {
      this.error = true;
      this.errorText = "Please fill in all fields";
    }
  }

  async pickFromCamera(): Promise<void> {
    let pickedImage = await this.photoService.takePhoto();
    
    if (pickedImage) {
      this.imageUrl = pickedImage;
    }
  }

  async pickFromGallery(): Promise<void> {
    let pickedImage = await this.photoService.pickFromGallery();
    
    if (pickedImage) {
      this.imageUrl = pickedImage;
    }
  }

}
