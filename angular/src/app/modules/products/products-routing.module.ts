import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListProductsComponent } from './list-products/list-products.component';
import { permissionGuard } from '@abp/ng.core';
import { AddProductsComponent } from './add-products/add-products.component';

const routes: Routes = [
  {
    path: 'add',
    pathMatch: 'full',
    component: AddProductsComponent,
    // نقفل الدخول عبر الروت الرابط للذي ماعندة صلاحية
    canActivate:[permissionGuard],
    data: {
        requiredPolicy: 'EcommerceApp.Products.CreateEdit', // policy key for your component
    },
  },
  {
    path: '',
    pathMatch: 'full',
    component: ListProductsComponent,
     // نقفل الدخول عبر الروت الرابط للذي ماعندة صلاحية
     canActivate:[permissionGuard],
     data: {
         requiredPolicy: 'EcommerceApp.Products.List', // policy key for your component
     },
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
