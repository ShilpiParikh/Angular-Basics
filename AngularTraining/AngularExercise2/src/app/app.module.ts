import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PipelineExample } from './PipelineExercise.pipe';

@NgModule({
  declarations: [
    AppComponent,
    PipelineExample
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [PipelineExample],
  bootstrap: [AppComponent]
})
export class AppModule { }
