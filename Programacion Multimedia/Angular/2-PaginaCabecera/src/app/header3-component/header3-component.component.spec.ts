import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Header3ComponentComponent } from './header3-component.component';

describe('Header3ComponentComponent', () => {
  let component: Header3ComponentComponent;
  let fixture: ComponentFixture<Header3ComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Header3ComponentComponent]
    });
    fixture = TestBed.createComponent(Header3ComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
