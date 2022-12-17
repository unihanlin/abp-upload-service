import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44398/',
  redirectUri: baseUrl,
  clientId: 'AbpUploadService_App',
  responseType: 'code',
  scope: 'offline_access AbpUploadService',
  requireHttps: true
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpUploadService',
    logoUrl: '',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44398',
      rootNamespace: 'Unihanlin.AbpUploadService',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
    AbpUploadService: {
      url: 'https://localhost:44329',
      rootNamespace: 'Unihanlin.AbpUploadService',
    },
  },
} as Environment;
