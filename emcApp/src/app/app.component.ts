import { Component } from '@angular/core';
import { Router, RouterModule, RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NgIf } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,
    FormsModule,
    RouterModule,
    MatToolbarModule,
    MatButtonModule,
    MatListModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    NgIf
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'emcApp';
  
  restUserData: AdminService;

  // constructor(restUserDataRef:AdminService)
  // {
  //   this.restUserData=restUserDataRef;

  // }
  constructor(private router: Router, public restUserDataRef: AdminService) {
    this.restUserData= restUserDataRef;
  }

  // Method to check if the current route is the home page
  isHomePage(): boolean {
    return this.router.url === '/';
  }
}
