export class Libro {
    private _id: number;
    private _titulo: string;
    private _autor: string;
    private _editorial: string;
    private _fechaPublicacion: Date;

    constructor(id : number, titulo : string, autor : string, editorial : string, fechaPublicacion : Date) {
        this._id = id;
        this._titulo = titulo;
        this._autor = autor;
        this._editorial = editorial;
        this._fechaPublicacion = fechaPublicacion;
    }

    public get id(): number {
        return this._id;
    }
    public set id(value: number) {
        this._id = value;
    }

    public get titulo(): string {
        return this._titulo;
    }
    public set titulo(value: string) {
        this._titulo = value;
    }

    public get autor(): string {
        return this._autor;
    }
    public set autor(value: string) {
        this._autor = value;
    }

    public get editorial(): string {
        return this._editorial;
    }
    public set editorial(value: string) {
        this._editorial = value;
    }

    public get fechaPublicacion(): Date {
        return this._fechaPublicacion;
    }
    public set fechaPublicacion(value: Date) {
        this._fechaPublicacion = value;
    }
}
