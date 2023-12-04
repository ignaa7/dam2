export class User {
    private _name: string;
    private _surnames: string;
    private _email: string;
    private _username: string;
    private _password: string;

    constructor(name: string, surnames: string, email: string, username: string, password: string) {
        this._name = name;
        this._surnames = surnames;
        this._email = email;
        this._username = username;
        this._password = password;
    }

    public get username(): string {
        return this._username;
    }
    public set username(value: string) {
        this._username = value;
    }

    public get password(): string {
        return this._password;
    }
    public set password(value: string) {
        this._password = value;
    }
}
