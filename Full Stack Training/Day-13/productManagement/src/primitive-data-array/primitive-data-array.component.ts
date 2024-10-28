import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-primitive-data-array',
  standalone: true,
  imports: [NgFor, ], // write NgFor, NgSwitch ,etc and press tab here to work for loop, if else, swtich etc
  templateUrl: './primitive-data-array.component.html',
  styleUrl: './primitive-data-array.component.css'
})
export class PrimitiveDataArrayComponent {

  techList:string[] = ["Angular","React","Vue","C++","Dart","Flutter"];


}
