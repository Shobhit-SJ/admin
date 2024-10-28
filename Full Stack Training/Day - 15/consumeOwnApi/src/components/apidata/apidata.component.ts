import { Component } from '@angular/core';
import { ConsumerestService } from '../../services/consumerest.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-apidata',
  standalone: true,
  imports: [NgFor],
  templateUrl: './apidata.component.html',
  styleUrl: './apidata.component.css'
})
export class ApidataComponent {

  restpdata:ConsumerestService;
  constructor(restpdataRef:ConsumerestService)
  {
    this.restpdata=restpdataRef;
  }

}
