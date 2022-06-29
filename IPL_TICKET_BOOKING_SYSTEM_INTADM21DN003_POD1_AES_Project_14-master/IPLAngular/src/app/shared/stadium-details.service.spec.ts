import { TestBed } from '@angular/core/testing';

import { StadiumDetailsService } from './stadium-details.service';

describe('StadiumDetailsService', () => {
  let service: StadiumDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StadiumDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
