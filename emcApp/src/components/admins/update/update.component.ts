import { Component, OnInit } from '@angular/core';
import { NgFor } from '@angular/common';
import { FormBuilder, FormGroup, FormsModule } from '@angular/forms';
import { AdminService } from '../../../services/admin.service';
import { ActivatedRoute } from '@angular/router';



@Component({
  selector: 'app-update',
  standalone: true,
  imports: [NgFor, FormsModule],
  templateUrl: './update.component.html',
  styleUrl: './update.component.css'
})
export class UpdateComponent {
  // consultant: any;
  restUserData: AdminService;
  constructor(restUserDataRef:AdminService)
  {
    this.restUserData=restUserDataRef;

  }
  // constructor(
  //   public restUserData: AdminService,
  //   private route: ActivatedRoute
  // ) {}

  // ngOnInit() {
  //   const id = +this.route.snapshot.paramMap.get('id')!;
  //   this.consultant = this.restUserData.getAllDriverDetails().find(c=> c.id === id);
  //   //.find(c => c.id === id);
  // }

  // updateConsultant(form: any) {
  //   if (form.valid) {
  //     this.restUserData.updateConsultant(form.value);
  //     alert('Consultant updated successfully!');
  //   }
  // }

}
