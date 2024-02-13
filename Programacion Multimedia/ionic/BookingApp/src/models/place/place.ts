export class Place {
  public id: string | undefined;
  public owner: string | undefined;
  public renter: string | undefined;

    constructor(
        public title: string,
        public description: string,
        public imageUrl: string,
        public price: number,
      ) {}
}
