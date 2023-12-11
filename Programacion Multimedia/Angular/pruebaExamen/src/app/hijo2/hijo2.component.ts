import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Service } from 'src/services/service/service.service';

@Component({
  selector: 'hijo2',
  templateUrl: './hijo2.component.html',
  styleUrls: ['./hijo2.component.css']
})
export class Hijo2Component {
  formName: FormGroup;

  observable: Observable<any>;

  usuario!: string;

  constructor(private router: Router, private formBuilder: FormBuilder, private service: Service, private activatedRoute: ActivatedRoute) {
    this.formName = formBuilder.group({
      algo: new FormControl("eggeas", [Validators.required])
    });

    this.observable = service.getObservable();

    activatedRoute.queryParams.subscribe(param => this.usuario = param['usuario']);
  }

  volver() {
    this.router.navigate(['padre']);
  }

  navegarHijo3() {
    this.router.navigate(['hijo3'], {queryParams: {texto: "algo"}});
  }
}
