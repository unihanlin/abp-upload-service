# AbpUploadService

An upload service base on ABP for angular.

## Install

```
npm install @unihanlin/abp-upload-service
```

## Usage

```typescript
import { AbpUploadService } from '@unihanlin/abp-upload-service';

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
