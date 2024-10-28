import { Component } from '@angular/core';
import { ProductserviceService } from '../../services/productservice.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-cold-drink-product',
  standalone: true,
  imports: [NgFor],
  templateUrl: './cold-drink-product.component.html',
  styleUrl: './cold-drink-product.component.css'
})
export class ColdDrinkProductComponent {


  drink:ProductserviceService= new ProductserviceService();
}
