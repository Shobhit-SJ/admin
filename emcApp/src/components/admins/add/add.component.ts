import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { AdminService } from '../../../services/admin.service';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-add',
  standalone: true,
  imports: [
    FormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ],
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  username: string = '';

  restUserData: AdminService;
  constructor(restUserDataRef:AdminService)
  {
    this.restUserData=restUserDataRef;

  }

 // Method to filter phone number input
 filterPhoneNumber(event: any) {
  const input = event.target;
  const value = input.value;

  // Remove all non-numeric characters
  input.value = value.replace(/[^0-9]/g, '');

  // Validate the length of the phone number
  if (input.value.length > 10) {
    input.value = input.value.slice(0, 10); // Limit to 10 digits
  }
}

}
