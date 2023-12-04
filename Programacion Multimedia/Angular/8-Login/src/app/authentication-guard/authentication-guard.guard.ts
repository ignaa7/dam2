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