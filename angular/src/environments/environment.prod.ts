import { Environment } from '@abp/ng.core';

const baseUrl = 'http://89.117.53.210:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Docker',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'http://89.117.53.210:44342/',
    redirectUri: baseUrl,
    clientId: 'Docker_App',
    responseType: 'code',
    scope: 'offline_access Docker',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'http://89.117.53.210:44342',
      rootNamespace: 'LongLearn.Docker',
    },
  },
} as Environment;
