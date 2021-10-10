import { TestBed } from '@angular/core/testing';

import { UserApiDataService } from './user-api-data.service';

describe('UserApiDataService', () => {
  let service: UserApiDataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserApiDataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
