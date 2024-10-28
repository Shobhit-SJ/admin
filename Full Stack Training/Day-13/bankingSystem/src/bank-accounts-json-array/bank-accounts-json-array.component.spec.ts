import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BankAccountsJsonArrayComponent } from './bank-accounts-json-array.component';

describe('BankAccountsJsonArrayComponent', () => {
  let component: BankAccountsJsonArrayComponent;
  let fixture: ComponentFixture<BankAccountsJsonArrayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BankAccountsJsonArrayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BankAccountsJsonArrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
