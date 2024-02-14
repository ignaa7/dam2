import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NavController } from '@ionic/angular';
import { PhotoService } from 'src/services/photo-service/photo.service';
import { PlacesService } from 'src/services/places-service/places.service';

@Component({
  selector: 'app-edit-offer',
  templateUrl: './edit-offer.page.html',
  styleUrls: ['./edit-offer.page.scss'],
})
export class EditOfferPage implements OnInit {
  place!: any;
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
    private route: ActivatedRoute,
    private router: Router,
    private placesService: PlacesService,
    private navCtrl: NavController,
    private photoService: PhotoService
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe(paramMap => {
      if (!paramMap.has('placeId')) {
        this.navCtrl.navigateBack('/main/offers');
        return;
      }
      this.place = this.placesService.getPlace(paramMap.get('placeId')!);

      this.imageUrl = this.place.imageUrl;
    });
  }

  async editOffer(title: string, description: string, price: string) {
    if (title && description && this.imageUrl && price) {
      this.error = false;
      this.errorText = "";
      await this.placesService.editPlace(this.place._id, title, description, this.imageUrl, parseFloat(price));
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
