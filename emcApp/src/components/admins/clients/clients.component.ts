import { Component } from '@angular/core';
import { AdminService } from '../../../services/admin.service';
import { NgFor } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-clients',
  standalone: true,
  imports: [NgFor,FormsModule],
  templateUrl: './clients.component.html',
  styleUrl: './clients.component.css'
})
export class ClientsComponent {
  restUserData: AdminService;
  constructor(restUserDataRef:AdminService)
  {
    this.restUserData=restUserDataRef;

  }


  submit(clientId: number , walletBalance: number){
    const updatedata = {
      clientId: clientId,
      walletBalance: walletBalance

    }
    this.restUserData.updateClient(updatedata)
  }
  // updateConsultant(consultantId: number, userId: number): void {
  //   this.restUserData.up(consultantId, userId);
  // }

  // updateClientts(clientId: number, walletBalance: number) {
  //   // Create an object to pass to the service method
  //   const updateClientData = {
  //     clientId: clientId,
  //     walletBalance: walletBalance
  //   };

  //   this.restUserData.updateClient(updateClientData);
  // }

}
