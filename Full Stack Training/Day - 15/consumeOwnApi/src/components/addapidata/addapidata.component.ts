import { Component } from '@angular/core';
import { ConsumerestService } from '../../services/consumerest.service';
import { NgFor } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-addapidata',
  standalone: true,
  imports: [NgFor,FormsModule],
  templateUrl: './addapidata.component.html',
  styleUrl: './addapidata.component.css'
})
export class AddapidataComponent {

  restpdata:ConsumerestService;
  constructor(restpdataRef:ConsumerestService)
  {
    this.restpdata=restpdataRef;
  }

  

  customer(cusdata:any){

    cusdata=this.restpdata;

    


    

  }
}
