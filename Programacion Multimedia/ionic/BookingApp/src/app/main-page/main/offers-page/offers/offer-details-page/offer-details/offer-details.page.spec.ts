import { ComponentFixture, TestBed } from '@angular/core/testing';
import { OfferDetailsPage } from './offer-details.page';

describe('OfferDetailsPage', () => {
  let component: OfferDetailsPage;
  let fixture: ComponentFixture<OfferDetailsPage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(OfferDetailsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
