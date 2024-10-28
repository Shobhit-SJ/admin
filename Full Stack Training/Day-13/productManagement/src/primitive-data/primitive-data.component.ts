import { Component } from '@angular/core';

@Component({
  selector: 'app-primitive-data',
  standalone: true,
  imports: [],
  templateUrl: './primitive-data.component.html',
  styleUrl: './primitive-data.component.css'
})
export class PrimitiveDataComponent {

  productsId: number =  101;
  productsName:string = "Mirinda";
  productsPrice: number =50;
  productsQuantity:number =5;
  productsCategories:string ="Cold-Drink";
  productsIsInStock:boolean=true;

}
