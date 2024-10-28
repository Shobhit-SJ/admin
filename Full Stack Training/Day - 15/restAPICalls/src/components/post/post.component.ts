import { Component, NgModule } from '@angular/core';
import { MakeapicallsService } from '../../services/makeapicalls.service';
import { NgFor } from '@angular/common';


@Component({
  selector: 'app-post',
  standalone: true,
  imports: [NgFor],
  templateUrl: './post.component.html',
  styleUrl: './post.component.css'
})
export class PostComponent {

  restData:MakeapicallsService;
  constructor(restDataref:MakeapicallsService)
  {
    this.restData=restDataref;
  }

}
