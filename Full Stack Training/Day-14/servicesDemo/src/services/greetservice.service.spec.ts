import { TestBed } from '@angular/core/testing';

import { GreetserviceService } from './greetservice.service';

describe('GreetserviceService', () => {
  let service: GreetserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GreetserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
