import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule} from '@angular/material/table';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LivrosComponent } from './views/livros/livros.component';
import { OverviewComponent } from './views/overview/overview.component';

@NgModule({
  declarations: [
    AppComponent,
    LivrosComponent,
    OverviewComponent
  ],
  imports: [
    MatToolbarModule,
    MatButtonModule,
    MatTableModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
