import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SplashScreen } from '@capacitor/splash-screen';
import { StatusBar, Style } from '@capacitor/status-bar';
import { Platform } from '@ionic/angular';
import { AuthService } from 'src/services/auth-service/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss'],
})
export class AppComponent {
  constructor(
    private platform: Platform,
    private authService: AuthService,
    private router: Router
  ) {
    this.initializeApp();
  }

  initializeApp() {
    this.platform.ready().then(async () => {
      await StatusBar.setStyle({ style: Style.Dark });
      await StatusBar.setStyle({ style: Style.Light });
    });
  }

  onLogout() {
    this.authService.logOut();
    this.router.navigateByUrl('/auth');
  }
}
