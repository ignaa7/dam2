import { Injectable } from '@angular/core';
import { Storage } from '@ionic/storage-angular';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  private _jwtToken: string | null;
  private _subject: BehaviorSubject<string>;

  constructor(private storage: Storage) {
    this._jwtToken = null;
    this._subject = new BehaviorSubject<string>('');

    this.getFromStorage();
  }

  get subject(): BehaviorSubject<string> {
    return this._subject;
  }

  async getFromStorage(): Promise<void> {
    this._jwtToken = await this.storage.get('token');
    
    if (this._jwtToken) {
      this.subject.next(this._jwtToken);
    }
  }

  async setOnStorage(token: string): Promise<void> {
    if (!this._jwtToken) {
      this.storage.set('token', token);
      this._jwtToken = token;
      this.subject.next(this._jwtToken);
    }
  }

  async clearStorage(): Promise<void> {
    this.storage.clear();
  }
}
