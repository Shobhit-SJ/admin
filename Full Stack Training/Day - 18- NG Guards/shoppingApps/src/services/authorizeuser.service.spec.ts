import { TestBed } from '@angular/core/testing';

import { AuthorizeuserService } from './authorizeuser.service';

describe('AuthorizeuserService', () => {
  let service: AuthorizeuserService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AuthorizeuserService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
