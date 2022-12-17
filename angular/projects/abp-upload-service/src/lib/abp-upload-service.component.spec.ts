import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AbpUploadServiceComponent } from './abp-upload-service.component';

describe('AbpUploadServiceComponent', () => {
  let component: AbpUploadServiceComponent;
  let fixture: ComponentFixture<AbpUploadServiceComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AbpUploadServiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AbpUploadServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
