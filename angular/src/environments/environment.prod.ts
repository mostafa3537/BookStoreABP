import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44397/',
  redirectUri: baseUrl,
  clientId: 'BookStoreABP_App',
  responseType: 'code',
  scope: 'offline_access BookStoreABP',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BookStoreABP',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44397',
      rootNamespace: 'BookStoreABP',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
