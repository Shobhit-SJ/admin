import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchvendorComponent } from './searchvendor.component';

describe('SearchvendorComponent', () => {
  let component: SearchvendorComponent;
  let fixture: ComponentFixture<SearchvendorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SearchvendorComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SearchvendorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
