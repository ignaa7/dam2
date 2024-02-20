export class Product {
    private _name: string;
    private _price: number;
    private _isInShoppingCart: boolean;
    private _quantity;

    constructor(name: string, price: number) {
        this._name = name;
        this._price = price;
        this._isInShoppingCart = false;
        this._quantity = 0;
    }

    public get name(): string {
        return this._name;
    }
    public set name(value: string) {
        this._name = value;
    }

    public get price(): number {
        return this._price;
    }
    public set price(value: number) {
        this._price = value;
    }

    public get isInShoppingCart(): boolean {
        return this._isInShoppingCart;
    }
    public set isInShoppingCart(value: boolean) {
        this._isInShoppingCart = value;
    }

    public get quantity() {
        return this._quantity;
    }
    public set quantity(value) {
        this._quantity = value;
    }

    
}
