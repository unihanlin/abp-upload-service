import type { SampleDto } from './models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { UploadDto } from '../models';

@Injectable({
  providedIn: 'root',
})
export class SampleService {
  apiName = 'AbpUploadService';
  

  get = () =>
    this.restService.request<any, SampleDto>({
      method: 'GET',
      url: '/api/AbpUploadService/sample',
    },
    { apiName: this.apiName });
  

  getAuthorized = () =>
    this.restService.request<any, SampleDto>({
      method: 'GET',
      url: '/api/AbpUploadService/sample/authorized',
    },
    { apiName: this.apiName });
  

  upload = (input: UploadDto) =>
    this.restService.request<any, boolean>({
      method: 'POST',
      url: '/api/AbpUploadService/sample/upload',
      params: { text: input.text, timestamp: input.timestamp },
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
