import { Component } from '@angular/core';
import { ProductserviceService } from '../../services/productservice.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-electronic-product',
  standalone: true,
  imports: [NgFor],
  templateUrl: './electronic-product.component.html',
  styleUrl: './electronic-product.component.css'
})
export class ElectronicProductComponent {

  prodSer:ProductserviceService= new ProductserviceService();

}
