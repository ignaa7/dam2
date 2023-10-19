import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Header2ComponentComponent } from './header2-component.component';

describe('Header2ComponentComponent', () => {
  let component: Header2ComponentComponent;
  let fixture: ComponentFixture<Header2ComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Header2ComponentComponent]
    });
    fixture = TestBed.createComponent(Header2ComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
