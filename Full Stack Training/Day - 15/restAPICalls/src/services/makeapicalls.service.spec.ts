import { TestBed } from '@angular/core/testing';

import { MakeapicallsService } from './makeapicalls.service';

describe('MakeapicallsService', () => {
  let service: MakeapicallsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MakeapicallsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
