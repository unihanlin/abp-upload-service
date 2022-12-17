import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { AbpUploadServiceComponent } from './components/abp-upload-service.component';
import { AbpUploadServiceRoutingModule } from './abp-upload-service-routing.module';

@NgModule({
  declarations: [AbpUploadServiceComponent],
  imports: [CoreModule, ThemeSharedModule, AbpUploadServiceRoutingModule],
  exports: [AbpUploadServiceComponent],
})
export class AbpUploadServiceModule {
  static forChild(): ModuleWithProviders<AbpUploadServiceModule> {
    return {
      ngModule: AbpUploadServiceModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<AbpUploadServiceModule> {
    return new LazyModuleFactory(AbpUploadServiceModule.forChild());
  }
}
