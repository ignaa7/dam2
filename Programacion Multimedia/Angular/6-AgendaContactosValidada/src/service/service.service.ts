import { Injectable } from '@angular/core';
import { Contacto } from 'src/classes/Contacto/contacto';

@Injectable({
  providedIn: 'root'
})
export class Service {
  private contactos : Contacto[];

    constructor() {
        this.contactos = [];
    }

    public getContactos() : Contacto[] {
        return [...this.contactos];
    }

    public addContacto(contacto : Contacto) : void {
        this.contactos.push(contacto);
    }

    public removeContacto(contacto : Contacto) : void {
        this.contactos.splice(this.contactos.indexOf(contacto), 1);
    }

    public editContacto(contacto : Contacto, datosContacto : any) : void {
        contacto.nombre = datosContacto.nombre;
        contacto.numero = datosContacto.numero;
    }
}
