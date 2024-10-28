import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderhomeComponent } from './orderhome.component';

describe('OrderhomeComponent', () => {
  let component: OrderhomeComponent;
  let fixture: ComponentFixture<OrderhomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [OrderhomeComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OrderhomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
