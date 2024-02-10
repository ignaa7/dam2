import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Storage } from '@ionic/storage-angular';
import { AuthService } from 'src/services/auth-service/auth.service';
import { StorageService } from 'src/services/storage-service/storage.service';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss'],
})
export class AppComponent {
  constructor(
    private authService: AuthService,
    private router: Router,
    private storage: Storage,
    private storageService: StorageService
  ) {
  }

  async ngOnInit() {
    await this.storage.create();
    await this.storageService.getFromStorage();
  }

  async onLogout() {
    await this.authService.logOut();
    this.router.navigateByUrl('/auth');
  }
}
