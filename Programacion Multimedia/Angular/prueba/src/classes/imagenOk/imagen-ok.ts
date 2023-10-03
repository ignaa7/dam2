export class ImagenOk {
    private ruta : string;
    private colorFondo : string;

    constructor(ruta : string) {
        this.ruta = ruta;
    }
    
    public getRuta() {
        return this.ruta;
    }

    public getColorFondo() {
        return this.colorFondo;
    }

    public setColorFondo(color : string) {
        this.colorFondo = color;
    }
}
