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

    
    public set nombre(v : string) {
        this._nombre = v;
    }
    

    
    public get numero() : string {
        return this._numero;
    }

    
    public set numero(v : string) {
        this._numero = v;
    }
    
    
    
}
