import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  standalone: true, // Certifique-se de que este componente é standalone
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  imports: [FormsModule], // Importa FormsModule para usar ngModel
})
export class RegisterComponent {
  user = {
    name: '',
    email: '',
    phone: '',
    password: '',
  };

  constructor(private router: Router) {}

  onSubmit() {
    console.log('Usuário cadastrado:', this.user);

    // Simulação de verificação e redirecionamento
    if (this.user.email === 'teste@email.com') {
      alert('Usuário já cadastrado! Redirecionando para login...');
      this.router.navigate(['/login']);
    } else {
      alert('Cadastro realizado com sucesso!');
    }
  }
}
