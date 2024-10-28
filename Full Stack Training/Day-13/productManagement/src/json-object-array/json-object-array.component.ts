import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-json-object-array',
  standalone: true,
  imports: [NgFor],
  templateUrl: './json-object-array.component.html',
  styleUrl: './json-object-array.component.css'
})
export class JsonObjectArrayComponent {

  productList:any[] = [
    {pId:101,pName:"Mobile",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:102,pName:"Pepsi",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:103,pName:"Head Phone",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:104,pName:"Laptop",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:105,pName:"Fossil",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    
  ];

}
