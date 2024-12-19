import { Component } from '@angular/core';

@Component({
  selector: 'app-homecard',
  imports: [],
  templateUrl: './homecard.component.html',
  styleUrl: './homecard.component.css'
})
export class HomecardComponent {
  products = [
    {
      title: 'Notebook',
      description: 'Notebook de alta performance, 16GB RAM',
      price: 'R$ 5.000,00',
      image: 'assets/notebook.png',
    },
    {
      title: 'Periféricos',
      description: 'Mouse e teclado sem fio',
      price: 'R$ 200,00',
      image: 'assets/perifericos.png',
    },
  ];
}
