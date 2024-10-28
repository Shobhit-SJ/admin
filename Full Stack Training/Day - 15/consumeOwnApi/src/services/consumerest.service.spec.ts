import { TestBed } from '@angular/core/testing';

import { ConsumerestService } from './consumerest.service';

describe('ConsumerestService', () => {
  let service: ConsumerestService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConsumerestService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
