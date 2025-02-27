import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CartService } from '../../services/cart.service';
import { SnackbarService } from '../../services/snackbar.service';

@Component({
  selector: 'app-product-list',
  imports: [CommonModule],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css',
  standalone: true // Se for standalone
})
export class ProductListComponent {
  products = [
    { name: 'Produto 1', price: 2500, image: 'assets/images/xbox.jpg' },
    { name: 'Produto 2', price: 5000, image: 'assets/images/ps5pro.jpg' },
    { name: 'Produto 3', price: 10000, image: 'assets/images/pc.jpg' }
  ];

  constructor(private cartService: CartService, private snackbarService: SnackbarService) {}

  addToCart(product: any) {
    this.cartService.addToCart(product);
    this.snackbarService.showMessage(`${product.name} foi adicionado ao carrinho!`);
  }
}