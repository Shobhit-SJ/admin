import { Component } from '@angular/core';
import { AdminService } from '../../../services/admin.service';
import { NgFor } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [NgFor,RouterModule],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent {

  restUserData: AdminService;
  router: any;
  constructor(restUserDataRef:AdminService)
  {
    this.restUserData=restUserDataRef;

  }
  navigateToUpdatePage(id: number) {
    this.router.navigate(['/update', id]);
  }
  

}
