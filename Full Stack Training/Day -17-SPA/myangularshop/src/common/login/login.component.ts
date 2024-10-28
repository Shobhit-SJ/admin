import { Component } from '@angular/core';
import { Router } from '@angular/router';



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
  
  constructor (private router: Router){

  }
  navigateToAttribute(){

    this.router.navigateByUrl("home")

  }
 

}
