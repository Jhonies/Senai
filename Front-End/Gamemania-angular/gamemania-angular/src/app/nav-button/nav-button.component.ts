import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-button',
  imports: [],
  templateUrl: './nav-button.component.html',
  styleUrl: './nav-button.component.css'
})
export class NavButtonComponent {
  navigateTo(section: string) {
    // Navega para a seção correspondente
    const element = document.getElementById(section);
    if (element) {
      element.scrollIntoView({ behavior: 'smooth' });
    }
  }
}
