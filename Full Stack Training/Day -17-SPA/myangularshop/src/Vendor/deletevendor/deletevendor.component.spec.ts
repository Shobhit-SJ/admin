import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletevendorComponent } from './deletevendor.component';

describe('DeletevendorComponent', () => {
  let component: DeletevendorComponent;
  let fixture: ComponentFixture<DeletevendorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DeletevendorComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeletevendorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
