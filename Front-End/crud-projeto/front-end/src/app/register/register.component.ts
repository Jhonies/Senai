import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
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

    // Aqui você pode enviar os dados para o backend usando HttpClient
    // Simulação: Se o e-mail já existir, redirecionar para o login
    if (this.user.email === 'teste@email.com') {
      alert('Usuário já cadastrado! Redirecionando para login...');
      this.router.navigate(['/login']);
    } else {
      alert('Cadastro realizado com sucesso!');
    }
  }
}