import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'diferenciaFechas'
})
export class DiferenciaFechasPipe implements PipeTransform {

  transform(fecha: Date): number {
    return new Date().getFullYear() - fecha.getFullYear();
  }

}
