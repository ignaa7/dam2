import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';

export const authGuard: CanActivateFn = (route, state) => {
  const authService: AuthService = inject(AuthService);
  const router: Router = inject(Router);

  let isAuthenticated: boolean = authService.userIsAuthenticated();

  if (!isAuthenticated){
    router.navigate(['/auth']);
  }
  
  return isAuthenticated;
};