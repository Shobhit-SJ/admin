import { Component } from '@angular/core';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent {

  componentName: string = "Contact"
  description:string = "You are in the Contact Page"
  developer:string ="Shobhit Jaiswal"

}
