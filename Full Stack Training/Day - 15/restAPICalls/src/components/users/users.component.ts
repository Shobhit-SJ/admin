import { Component } from '@angular/core';
import { MakeapicallsService } from '../../services/makeapicalls.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-users',
  standalone: true,
  imports: [NgFor],
  templateUrl: './users.component.html',
  styleUrl: './users.component.css'
})
export class UsersComponent {

  restUserData:MakeapicallsService;
  constructor(restUserDataRef:MakeapicallsService)
  {
    this.restUserData=restUserDataRef;

  }

}
