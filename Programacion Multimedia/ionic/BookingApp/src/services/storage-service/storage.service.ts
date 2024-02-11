import { Injectable } from '@angular/core';
import { Storage } from '@ionic/storage-angular';

@Injectable({
  providedIn: 'root'
})
export class StorageService {

  constructor(private storage: Storage) {
    this.createDatabase();
  }

  async createDatabase() {
    await this.storage.create();
  }

  async getFromStorage(key: string): Promise<string | null> {
    return (await this.storage.get(key));
  }

  async setOnStorage(key: string, value: string): Promise<void> {
      await this.storage.set(key, value);
  }

  async removeFromStorage(key: string): Promise<void> {
    this.storage.remove(key);
  }
}
