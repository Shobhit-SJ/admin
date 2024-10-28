import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddapidataComponent } from './addapidata.component';

describe('AddapidataComponent', () => {
  let component: AddapidataComponent;
  let fixture: ComponentFixture<AddapidataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddapidataComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddapidataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
