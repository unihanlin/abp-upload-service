import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AbpUploadServiceComponent } from './components/abp-upload-service.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: AbpUploadServiceComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AbpUploadServiceRoutingModule {}
