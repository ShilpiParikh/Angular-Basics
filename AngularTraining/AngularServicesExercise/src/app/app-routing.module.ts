import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddProductComponent } from './add-product/add-product.component';
import { ProductInfoComponent } from './product-info/product-info.component';

const routes: Routes = [
  {path:'add-product', component: AddProductComponent},
  {path: 'products-info', component: ProductInfoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
