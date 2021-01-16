import { TestBed } from '@angular/core/testing';

import { StudentMarkService } from './student-mark.service';

describe('StudentMarkService', () => {
  let service: StudentMarkService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StudentMarkService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
