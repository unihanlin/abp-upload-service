import { ModuleWithProviders, NgModule } from '@angular/core';
import { ABP_UPLOAD_SERVICE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class AbpUploadServiceConfigModule {
  static forRoot(): ModuleWithProviders<AbpUploadServiceConfigModule> {
    return {
      ngModule: AbpUploadServiceConfigModule,
      providers: [ABP_UPLOAD_SERVICE_ROUTE_PROVIDERS],
    };
  }
}
