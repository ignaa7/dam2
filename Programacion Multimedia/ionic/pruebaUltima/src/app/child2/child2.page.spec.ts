import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Child2Page } from './child2.page';

describe('Child2Page', () => {
  let component: Child2Page;
  let fixture: ComponentFixture<Child2Page>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(Child2Page);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
