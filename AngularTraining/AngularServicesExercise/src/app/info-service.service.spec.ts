import { TestBed } from '@angular/core/testing';

import { InfoServiceService } from './info-service.service';

describe('InfoServiceService', () => {
  let service: InfoServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InfoServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
