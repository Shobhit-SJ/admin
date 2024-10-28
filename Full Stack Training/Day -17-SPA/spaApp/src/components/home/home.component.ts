import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  componentName: string = "home"
  description:string = "You are in the Home Page"
  developer:string ="Shobhit Jaiswal"

}
