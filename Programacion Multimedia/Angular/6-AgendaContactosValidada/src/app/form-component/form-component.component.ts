import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Contacto } from 'src/classes/Contacto/contacto';

@Component({
  selector: 'form-component',
  templateUrl: './form-component.component.html',
  styleUrls: ['./form-component.component.css']
})
export class FormComponentComponent {
  @Output() eventoNuevoContacto = new EventEmitter<Contacto>();
  @Output() eventoEditarContacto = new EventEmitter<Object>();
  @Input() nombre : string | undefined;
  @Input() numero : string | undefined;
  @Input() edicion : boolean = false;

  form! : FormGroup;
  private formBuilder : FormBuilder;

  constructor(formBuilder: FormBuilder) {
    this.formBuilder = formBuilder;
  }

  ngOnChanges(): void {
    this.actualizarDatos();
  }

  ngOnInit(): void {
    this.actualizarDatos();
  }

  actualizarDatos(): void {
    this.form = this.formBuilder.group({
      nombre: [this.nombre, [Validators.required, Validators.minLength(6)]],
      numero: [this.numero, [Validators.required, Validators.pattern(/^\d{9}$/)]]
    });
  }

  onSubmit(): void {
    if (this.form.valid) {
      this.edicion
      ? this.eventoEditarContacto.emit({nombre : this.form.value.nombre, numero : this.form.value.numero})
      : this.eventoNuevoContacto.emit(new Contacto(this.form.value.nombre, this.form.value.numero));

      this.nombre = undefined;
      this.numero = undefined;
      this.actualizarDatos();
    }
  }
}
