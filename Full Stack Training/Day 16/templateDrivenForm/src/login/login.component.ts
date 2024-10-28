import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule,NgFor,NgClass],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  result: string = "";

  loginUser(loginInfo:any){
    if(loginInfo.value.username == "admin" && loginInfo.value.password =="admin1234")
    {
      this.result = "Login Successful, welcome" + loginInfo.value.username;

    }
    else
    {
      this.result="Login Failed";

    }
  }

}
