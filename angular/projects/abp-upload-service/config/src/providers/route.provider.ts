import { eLayoutType, RoutesService } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';
import { eAbpUploadServiceRouteNames } from '../enums/route-names';

export const ABP_UPLOAD_SERVICE_ROUTE_PROVIDERS = [
  {
    provide: APP_INITIALIZER,
    useFactory: configureRoutes,
    deps: [RoutesService],
    multi: true,
  },
];

export function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/abp-upload-service',
        name: eAbpUploadServiceRouteNames.AbpUploadService,
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        order: 3,
      },
    ]);
  };
}
