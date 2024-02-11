import { CanMatchFn, UrlTree, Router, Route, UrlSegment } from '@angular/router';
import { AuthService } from 'src/services/auth-service/auth.service';
import { inject } from '@angular/core';

export const authGuard: CanMatchFn = async (
  route: Route,
  segments: UrlSegment[]
): Promise<boolean | UrlTree> => {
  const authService: AuthService = inject(AuthService);
  const router: Router = inject(Router);

  return await authService.getToken() ? true : router.createUrlTree(['/auth']);
};
