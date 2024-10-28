import { Component } from '@angular/core';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  componentName: string = "Register"
  description:string = "You are in the Register Page"
  developer:string ="Shobhit Jaiswal"

}
