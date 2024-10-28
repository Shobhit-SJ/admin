import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule,RouterModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  constructor (private router: Router){

  }

  navigateTologin(){

    this.router.navigateByUrl("login")

  }



  onSubmit(){
    console.log("successfull");
  }



}
