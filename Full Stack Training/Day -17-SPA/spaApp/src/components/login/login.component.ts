import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  componentName: string = "Login"
  description:string = "You are in the Login Page"
  developer:string ="Shobhit Jaiswal"

}
