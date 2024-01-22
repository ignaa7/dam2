import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertController } from '@ionic/angular';
import { CoursesService } from 'src/services/courses-service/courses.service';
import { Camera, CameraOptions } from '@awesome-cordova-plugins/camera';

@Component({
  selector: 'app-details-page',
  templateUrl: './details-page.page.html',
  styleUrls: ['./details-page.page.scss'],
})
export class DetailsPagePage implements OnInit {
  course: any;
  actionSheetButtons = [
    {
      text: 'Cámara',
      data: {
        action: this.pickFromCamera,
      },
    },
    {
      text: 'Galería',
      data: {
        action: this.selectFromGallery,
      },
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
    private activatedRoute: ActivatedRoute,
    private coursesService: CoursesService,
    private router: Router,
    private alertCtrl: AlertController,
    ) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(paramMap => {
      if (!paramMap.has('courseId')) {
        this.router.navigate(['/courses']);
        return;
      }
      const id = paramMap.get('courseId');
      
      if (id) {
        this.course = this.coursesService.getCourse(id);
      }
    });
  }

  onDeleteRecipe(): void {
    this.alertCtrl
      .create({
        header: 'Borrar el curso',
        message: '¿Seguro que quiere borrar el curso?',
        buttons: [
          {
            text: 'Cancelar',
            role: 'cancel'
          },
          {
            text: 'Borrar',
            handler: () => {
              this.coursesService.deleteCourse(this.course['id']);
              this.router.navigate(['/courses']);
            }
          }
        ]
      })
      .then(alertEl => {
        alertEl.present();
      });
  }

  pickFromCamera(): void {
    const options: CameraOptions = {
      quality: 80,
      destinationType: Camera.DestinationType.FILE_URI,
      encodingType: Camera.EncodingType.JPEG,
      mediaType: Camera.MediaType.PICTURE,
      sourceType: Camera.PictureSourceType.CAMERA,
    };
  
    Camera.getPicture(options).then((url) => {
      this.course['imageUrl'] = url;
    }, (error) => {
      console.error(error);
    });
  }

  selectFromGallery(): void {
    const options: CameraOptions = {
      quality: 80,
      destinationType: Camera.DestinationType.FILE_URI,
      encodingType: Camera.EncodingType.JPEG,
      mediaType: Camera.MediaType.PICTURE,
      sourceType: Camera.PictureSourceType.PHOTOLIBRARY,
    };
  
    Camera.getPicture(options).then((url) => {
      this.course['imageUrl'] = url;
    }, (error) => {
      console.error(error);
    });
  }
}
