# AbpUploadService

An upload service base on ABP for angular.

## Install

```
npm install @one-dispatch/abp-upload-service
```

## Usage

```typescript
import { AbpUploadService } from '@one-dispatch/abp-upload-service';

constructor(
    private uploadService: AbpUploadService
){
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
      .subscribe(result => (console.log(result)));
  }
```
