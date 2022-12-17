import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class AbpUploadServiceService {
  apiName = 'AbpUploadService';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/AbpUploadService/sample' },
      { apiName: this.apiName }
    );
  }
}
