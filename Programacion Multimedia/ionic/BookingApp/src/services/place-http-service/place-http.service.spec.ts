import { TestBed } from '@angular/core/testing';

import { PlaceHttpService } from './place-http.service';

describe('PlaceHttpService', () => {
  let service: PlaceHttpService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PlaceHttpService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
