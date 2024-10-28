import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IodComponent } from './iod.component';

describe('IodComponent', () => {
  let component: IodComponent;
  let fixture: ComponentFixture<IodComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [IodComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IodComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
