import { Injectable } from '@angular/core';
import { Rest, RestService } from '@abp/ng.core';
import { FormRequest } from '../models/form-request';
import { fieldsToFormData } from '../utils/utils';

@Injectable({
  providedIn: 'root',
})
export class AbpUploadService {
  constructor(private restService: RestService) {}

  uploadAsync = <T = any>(request: FormRequest<any>, config?: Rest.Config, api?: string) => {
    const formData = fieldsToFormData(request.fields);
    request = {
      ...request,
      body: formData,
    };

    return this.restService.request<any, T>(request, config, api);
  };
}
