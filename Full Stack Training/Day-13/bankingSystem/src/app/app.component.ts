import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BankAccountsComponent } from "../bank-accounts/bank-accounts.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, BankAccountsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'bankingSystem';
}
