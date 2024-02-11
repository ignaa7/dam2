import { User } from "../user/user";

export class Place {
    constructor(
        public id: string,
        public title: string,
        public description: string,
        public imageUrl: string,
        public price: number,
        public ownerEmail: string,
      ) {}
}
