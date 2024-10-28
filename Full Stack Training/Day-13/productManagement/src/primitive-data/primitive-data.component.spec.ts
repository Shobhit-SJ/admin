import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrimitiveDataComponent } from './primitive-data.component';

describe('PrimitiveDataComponent', () => {
  let component: PrimitiveDataComponent;
  let fixture: ComponentFixture<PrimitiveDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PrimitiveDataComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PrimitiveDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
