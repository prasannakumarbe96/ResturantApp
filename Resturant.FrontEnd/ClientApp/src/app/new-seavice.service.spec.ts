import { TestBed, inject } from '@angular/core/testing';

import { NewSeaviceService } from './new-seavice.service';

describe('NewSeaviceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NewSeaviceService]
    });
  });

  it('should be created', inject([NewSeaviceService], (service: NewSeaviceService) => {
    expect(service).toBeTruthy();
  }));
});
