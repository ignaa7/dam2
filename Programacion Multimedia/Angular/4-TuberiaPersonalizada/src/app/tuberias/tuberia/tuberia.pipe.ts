import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tuberia'
})
export class TuberiaPipe implements PipeTransform {

  transform(texto : string, palabrasInadecuadas : string[]): string {
    palabrasInadecuadas.forEach((palabra : string) => {
      texto = texto.replace(palabra, '****');
    });

    return texto;
  }

}