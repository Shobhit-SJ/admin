import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { StockInfoComponent } from '../components/stock-info/stock-info.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,StockInfoComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'equtiyManagement';
}
