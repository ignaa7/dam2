import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { Service } from 'src/services/service/service.service';

export const guard: CanActivateFn = (route, state) => {
  const service: Service = inject(Service);
  const router: Router = inject(Router);

  if (service.comprobarNumero()) {
    return true;
  } else {
    router.navigate(['padre']);
    return false;
  }
};
