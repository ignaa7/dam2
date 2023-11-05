import { Libro } from "src/modelo/Libro/libro";

export class Servicio {
    private libros: Libro[];
    
    constructor() {
        this.libros = [];
        this.libros.push(new Libro(1, "El corredor del laberinto", "James Dashner", "Delacorte Press", new Date(2010,7, 24)));
        this.libros.push(new Libro(2, "Los juegos del hambre", "Suzanne Collins", "Scholastic Press", new Date(2008, 8, 14)));
        this.libros.push(new Libro(3, "Percy Jackson", "Rick Riordan", "Miramax Books", new Date(2005,5,28)));
    }

    public getLibro(id : number) : any {
        let libro : Libro = this.libros.find(libro => libro.id == id)!;

        return {id: libro.id, 
            titulo: libro.titulo, 
            autor: libro.autor, 
            editorial: libro.editorial, 
            fechaPublicacion: libro.fechaPublicacion
        };
    }
}
