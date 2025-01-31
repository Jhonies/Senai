import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root', // Torna o serviço acessível globalmente
})
export class SnackbarService {
  constructor(private snackBar: MatSnackBar) {}

  showMessage(message: string, action: string = 'Fechar', duration: number = 3000) {
    this.snackBar.open(message, action, {
      duration: duration,
      verticalPosition: 'bottom', // 'top' ou 'bottom'
      horizontalPosition: 'right', // 'start', 'center', 'end', 'left' ou 'right'
    });
  }
}