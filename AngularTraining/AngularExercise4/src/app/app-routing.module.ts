import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { ProductInfoComponent } from './product-info/product-info.component';
import { MainPageComponent } from './main-page/main-page.component'
const routes: Routes = [
  { path: 'product-Info', component: ProductInfoComponent  },
  { path: 'welcome', component: AppComponent  },
  {path: 'home',component : MainPageComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
