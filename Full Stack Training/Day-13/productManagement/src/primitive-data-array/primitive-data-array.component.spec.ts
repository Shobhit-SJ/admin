import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrimitiveDataArrayComponent } from './primitive-data-array.component';

describe('PrimitiveDataArrayComponent', () => {
  let component: PrimitiveDataArrayComponent;
  let fixture: ComponentFixture<PrimitiveDataArrayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PrimitiveDataArrayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PrimitiveDataArrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
