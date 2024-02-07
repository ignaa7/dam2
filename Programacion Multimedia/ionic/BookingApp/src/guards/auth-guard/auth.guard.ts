import { CanMatchFn, UrlTree, Router, Route, UrlSegment } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';
import { inject } from '@angular/core';

export const authGuard: CanMatchFn = (
  route: Route,
  segments: UrlSegment[]
): boolean | UrlTree => {
  const authService: AuthService = inject(AuthService);
  const router: Router = inject(Router);
  const isAuthenticated = authService.userIsAuthenticated;

  return isAuthenticated ? true : router.createUrlTree(['/auth']);
};
