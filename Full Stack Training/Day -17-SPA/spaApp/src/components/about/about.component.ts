import { Component } from '@angular/core';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export class AboutComponent {

  componentName: string = "About"
  description:string = "You are in the About Page"
  developer:string ="Shobhit Jaiswal"

}
