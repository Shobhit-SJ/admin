import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JsonObjectArrayComponent } from './json-object-array.component';

describe('JsonObjectArrayComponent', () => {
  let component: JsonObjectArrayComponent;
  let fixture: ComponentFixture<JsonObjectArrayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [JsonObjectArrayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(JsonObjectArrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
