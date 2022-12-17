import { TestBed } from '@angular/core/testing';

import { AbpUploadServiceService } from './abp-upload-service.service';

describe('AbpUploadServiceService', () => {
  let service: AbpUploadServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AbpUploadServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
