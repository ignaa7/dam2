import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { AuthenticationService } from 'src/services/authentication-service/authentication-service.service';

export const authenticationGuard: CanActivateFn = (route, state) => {
  const authenticationService: AuthenticationService = inject(AuthenticationService);
  const router: Router = inject(Router);

  if (authenticationService.isLoggedInUser()){
    return true;
  }
  else {
    router.navigate(['/loginPage']);
    return false;
  }  
};

// export class AuthenticationGuard implements CanActivate {
//   constructor(private authService: AuthenticationService, private router: Router) {}

//   canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
//     if (this.authService.isLoggedInUser()) {
//       return true;
//     } else {
//       this.router.navigate(['/loginPage']);
//       return false;
//     }
//   }
// }