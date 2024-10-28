import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColdDrinkProductComponent } from './cold-drink-product.component';

describe('ColdDrinkProductComponent', () => {
  let component: ColdDrinkProductComponent;
  let fixture: ComponentFixture<ColdDrinkProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ColdDrinkProductComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ColdDrinkProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
