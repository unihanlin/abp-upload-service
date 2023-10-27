import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AbpUploadService } from '@one-dispatch/abp-upload-service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  isModalOpen = false;
  form: FormGroup;

  constructor(private fb: FormBuilder, private uploadService: AbpUploadService) {}

  buildForm() {
    this.form = this.fb.group({
      singleFile: [null, [Validators.required]],
      files: [null, []],
      text: [null, []],
      timestamp: [null, [Validators.required]],
    });
  }

  showForm() {
    this.buildForm();
    this.isModalOpen = true;
  }

  submitForm() {
    this.uploadService
      .uploadAsync<boolean>(
        {
          method: 'POST',
          url: '/api/AbpUploadService/sample/upload',
          fields: this.form,
        },
        { apiName: 'AbpUploadService' }
      )
      .subscribe(result => console.log('result', result));
  }
}
