import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { routes } from './app/app-routing.module';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async'; // Rotas exportadas

bootstrapApplication(AppComponent, {
  providers: [provideRouter(routes), provideAnimationsAsync()]
}).catch(err => console.error(err));
