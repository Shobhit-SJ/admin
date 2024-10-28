import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ResgistrationComponent } from "../resgistration/resgistration.component";
import { LoginComponent } from "../login/login.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ResgistrationComponent, LoginComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'templateDrivenForm';
}
