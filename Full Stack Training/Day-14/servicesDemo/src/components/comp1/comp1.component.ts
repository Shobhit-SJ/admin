import { Component } from '@angular/core';
import { GreetserviceService } from '../../services/greetservice.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-comp1',
  standalone: true,
  imports: [NgFor],
  templateUrl: './comp1.component.html',
  styleUrl: './comp1.component.css'
})
export class Comp1Component {
  greet:GreetserviceService = new GreetserviceService();

}
