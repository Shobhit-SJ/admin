import { Component } from '@angular/core';

@Component({
  selector: 'app-json-object',
  standalone: true,
  imports: [],
  templateUrl: './json-object.component.html',
  styleUrl: './json-object.component.css'
})
export class JsonObjectComponent {

 employeeDetails={
  "FirstName": "Shobhit",
  "LastName":"Jaiswal",
  "age": 23,
  "City":"Prayagraj",
  "State":"UP",
  "Country":"India"

 } 


}
