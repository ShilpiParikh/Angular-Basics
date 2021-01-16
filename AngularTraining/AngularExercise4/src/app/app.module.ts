import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductInfoComponent } from './product-info/product-info.component';
import { ProductInfoClass } from './Product-Info-Class';
import { ProductInfoService } from './product-info.service';
import { SearchFunctionComponent } from './search-function/search-function.component';

import {FormsModule} from '@angular/forms';
import { MainPageComponent } from './main-page/main-page.component'
@NgModule({
  declarations: [
    AppComponent,
    ProductInfoComponent,
    SearchFunctionComponent,
    MainPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ProductInfoClass,
    FormsModule
  ],
  providers: [ProductInfoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
