import { Component, ElementRef, EventEmitter, Input, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Service } from 'src/services/service/service.service';

@Component({
  selector: 'hijo',
  templateUrl: './hijo.component.html',
  styleUrls: ['./hijo.component.css']
})
export class HijoComponent {
  @Input() texto: string;
  @Output() eventoMandartexto: EventEmitter<string> = new EventEmitter<string>();

  @ViewChild('parrafo') parrafo!: ElementRef;

  form!: FormGroup;
  nombreTexto: string | undefined;

  numero!: number;
  observable: Observable<any>;

  constructor(private formBuilder: FormBuilder, private service: Service, private router: Router) {
    this.texto = 'algo';
    this.actualizarDatos();
    
    service.getObservable().subscribe(numero => this.numero = numero);
    this.observable = this.service.getObservable();
  }

  ngAfterViewInit() {
    this.parrafo.nativeElement.textContent = 'hola soy un texto';
  }

  mandarTexto(texto: string) {
    this.eventoMandartexto.emit(texto);
  }


  actualizarDatos() {
    this.form = this.formBuilder.group({
      nombre: [this.nombreTexto, [Validators.required, Validators.minLength(2)]]
    });
  }

  recibir() {
    if (this.form.valid) {
      this.nombreTexto = this.form.value.nombre;
    } else {
      this.nombreTexto = "mal";
    }
  }

  sumar() {
    this.service.sumar();
  }


  navegar() {
    this.router.navigate(['hijo2']);
  }
}