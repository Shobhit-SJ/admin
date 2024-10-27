import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { AdminService } from '../../../services/admin.service';

@Component({
  selector: 'app-delete',
  standalone: true,
  imports: [
    MatCardModule, MatFormFieldModule, MatInputModule, MatButtonModule,FormsModule
  ],
  templateUrl: './delete.component.html',
  styleUrl: './delete.component.css'
})
export class DeleteComponent {

  restUserData: AdminService;
  router: any;
  constructor(restUserDataRef:AdminService)
  {
    this.restUserData=restUserDataRef;

  }

}
