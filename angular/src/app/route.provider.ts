import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: 'products',
        name: 'Products',
        iconClass: 'fas fa-box',
        order: 2,
        layout: eLayoutType.application,
         //بولسي ماتظهرش الايقونه دي الا للي معاهم صلاحيه
         requiredPolicy: 'EcommerceApp.Products.List',
      },
      {
        path: 'categories',
        name: 'Categories',
        iconClass: 'fas fa-list',
        order: 3,
        layout: eLayoutType.application,
       
      },
    ]);
  };
}
