import { Component } from '@angular/core';
import { DiscountPipe } from '../pipes/discount.pipe';
import { CurrencyPipe, NgFor, UpperCasePipe } from '@angular/common';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [DiscountPipe,NgFor,CurrencyPipe,UpperCasePipe],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent {

  productList=[
    {pId: 101, pName: "Shobhit", pCategory: "cloth", pPrice: 100, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "cloth", pPrice: 90, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "cloth", pPrice: 80, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "cloth", pPrice: 140, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Shoes", pPrice: 44, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Shoes", pPrice: 104, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Shoes", pPrice: 110, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Shoes", pPrice: 120, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Shoes", pPrice: 90, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Accessory", pPrice: 19, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Accessory", pPrice: 50, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Accessory", pPrice: 10, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Accessory", pPrice: 30, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Accessory", pPrice: 180, pIsInStock: true},
    {pId: 101, pName: "Shobhit", pCategory: "Accessory", pPrice: 200, pIsInStock: true},
  ]

}
