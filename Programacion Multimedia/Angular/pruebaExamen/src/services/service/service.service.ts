import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Service {

  numero: number;
  subject: BehaviorSubject<number>;

  constructor() { 
    this.numero = 0;
    this.subject = new BehaviorSubject(0);
  }

  getObservable() {
    return this.subject.asObservable();
  }

  sumar() {
    this.numero++;
    this.subject.next(this.numero);
  }

  comprobarNumero() {
    return this.numero > 1;
  }
}
