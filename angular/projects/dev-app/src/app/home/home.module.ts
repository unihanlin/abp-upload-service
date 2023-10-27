import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { NgFileInputDirectiveModule } from '@one-dispatch/ng-file-input-directive';

@NgModule({
  declarations: [HomeComponent],
  imports: [SharedModule, HomeRoutingModule, NgFileInputDirectiveModule],
})
export class HomeModule {}
