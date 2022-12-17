import { Component, OnInit } from '@angular/core';
import { AbpUploadServiceService } from '../services/abp-upload-service.service';

@Component({
  selector: 'lib-abp-upload-service',
  template: ` <p>abp-upload-service works!</p> `,
  styles: [],
})
export class AbpUploadServiceComponent implements OnInit {
  constructor(private service: AbpUploadServiceService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
