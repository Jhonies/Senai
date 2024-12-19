import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { CardComponent } from './card/card.component'; // Componente filho
import { HomecardComponent } from './homecard/homecard.component'; // Componente pai

@NgModule({
  declarations: [
    AppComponent,
    HomecardComponent,// Componente pai
    CardComponent //Componente filho
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }