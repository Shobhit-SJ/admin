import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddvendorComponent } from './addvendor.component';

describe('AddvendorComponent', () => {
  let component: AddvendorComponent;
  let fixture: ComponentFixture<AddvendorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddvendorComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddvendorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
