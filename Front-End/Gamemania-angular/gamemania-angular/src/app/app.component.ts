import { Component } from '@angular/core';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { NavButtonComponent } from './nav-button/nav-button.component';
import { HomecardComponent } from './homecard/homecard.component';

@Component({
  selector: 'app-root',
  imports: [HomeComponent, NavButtonComponent, HomecardComponent, FooterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'gamemania-angular';
}