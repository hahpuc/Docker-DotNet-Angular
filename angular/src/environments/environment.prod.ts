import { Environment } from '@abp/ng.core';

const baseUrl = 'http://154.26.128.219:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Docker',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'http://154.26.128.219:44342/',
    redirectUri: baseUrl,
    clientId: 'Docker_App',
    responseType: 'code',
    scope: 'offline_access Docker',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'http://154.26.128.219:44342',
      rootNamespace: 'LongLearn.Docker',
    },
  },
} as Environment;
