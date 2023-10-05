export class Contacto {
    private _nombre : string;
    private _numero : string;

    constructor(nombre : string, numero : string) {
        this._nombre = nombre;
        this._numero = numero;
    }

    
    public get nombre() : string {
        return this._nombre;
    }

    
    public get numero() : string {
        return this._numero;
    }
    
    
}
