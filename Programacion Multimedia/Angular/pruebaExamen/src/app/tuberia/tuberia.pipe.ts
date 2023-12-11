import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tuberia'
})
export class TuberiaPipe implements PipeTransform {

  transform(value: any, ...args: any[]): unknown {
    return value+args[2];
  }

}
