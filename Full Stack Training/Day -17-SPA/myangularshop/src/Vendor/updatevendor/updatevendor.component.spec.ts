import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatevendorComponent } from './updatevendor.component';

describe('UpdatevendorComponent', () => {
  let component: UpdatevendorComponent;
  let fixture: ComponentFixture<UpdatevendorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdatevendorComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdatevendorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
