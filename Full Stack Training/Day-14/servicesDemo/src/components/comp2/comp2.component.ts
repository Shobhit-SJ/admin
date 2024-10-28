import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { GreetserviceService } from '../../services/greetservice.service';

@Component({
  selector: 'app-comp2',
  standalone: true,
  imports: [NgFor],
  templateUrl: './comp2.component.html',
  styleUrl: './comp2.component.css'
})
export class Comp2Component {
  // greet:GreetserviceService = new GreetserviceService();
  greet:GreetserviceService = new GreetserviceService();




}
