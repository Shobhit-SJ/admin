import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletecustomrsComponent } from './deletecustomrs.component';

describe('DeletecustomrsComponent', () => {
  let component: DeletecustomrsComponent;
  let fixture: ComponentFixture<DeletecustomrsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DeletecustomrsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeletecustomrsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
