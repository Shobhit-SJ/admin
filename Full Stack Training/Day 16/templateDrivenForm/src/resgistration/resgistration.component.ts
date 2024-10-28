import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-resgistration',
  standalone: true,
  imports: [FormsModule,NgFor],
  templateUrl: './resgistration.component.html',
  styleUrl: './resgistration.component.css'
})
export class ResgistrationComponent {

  cities:String[]=['KOL','BLR','DEL','IXD']

  registerUser(newUserInfo:any){

    //uh can call aservice method which will post the data to rest
    console.log(newUserInfo.value);
    console.log(newUserInfo.value.username);
    console.log(newUserInfo.value.email)
  }

}
