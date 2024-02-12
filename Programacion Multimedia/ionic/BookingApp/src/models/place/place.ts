export class Place {
  public owner: string | undefined;
  public renter: string | undefined;

    constructor(
        public id: string,
        public title: string,
        public description: string,
        public imageUrl: string,
        public price: number,
      ) {}
}
