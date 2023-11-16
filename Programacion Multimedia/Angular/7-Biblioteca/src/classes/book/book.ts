export class Book {
    private _title: string;
    private _author: string;
    private _isbn: string;
    private _date: Date;

    constructor(title: string, author: string, isbn: string, date: Date) {
        this._title = title;
        this._author = author;
        this._isbn = isbn;
        this._date = date;
    }

    public get title(): string {
        return this._title;
    }

    public get author(): string {
        return this._author;
    }

    public get isbn(): string {
        return this._isbn;
    }

    public get date(): Date {
        return this._date;
    }
}
