import { Component } from '@angular/core';
import { MakeapicallsService } from '../../services/makeapicalls.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [NgFor],
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {

  restProductData:MakeapicallsService;

  constructor(restProductDataRef:MakeapicallsService)
  {
    this.restProductData=restProductDataRef;
  }

}
