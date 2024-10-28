import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BankAccountsprimitiveArrayComponent } from './bank-accountsprimitive-array.component';

describe('BankAccountsprimitiveArrayComponent', () => {
  let component: BankAccountsprimitiveArrayComponent;
  let fixture: ComponentFixture<BankAccountsprimitiveArrayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BankAccountsprimitiveArrayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BankAccountsprimitiveArrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
