import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductserviceService {

  productList:any[] = [
    {pId:101,pName:"Mobile",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:102,pName:"Pepsi",pPrice:20000,pCategory:"ColdDrink",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:222,pName:"mirinda",pPrice:20,pCategory:"ColdDrink",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:103,pName:"Head Phone",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:105,pName:"Fossil",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    {pId:104,pName:"Laptop",pPrice:20000,pCategory:"Electronics",pDescription:"Mobile is a portable device",pImage:"https://rukminim1.flixcart.com/image/416/416/kk3lcy80/mobile/x/q/u/-original-imagbyq7kzvqk4f3.jpeg?q=70"},
    
  ];

  electronicsProducts:any[] = [];
  coldDrinkProducts:any[] = [];

  segegrateData()
  {
    for(let i=0;i<this.productList.length;i++)
    {
      if(this.productList[i].pCategory == "Electronics"){
        this.electronicsProducts.push(this.productList[i]);
      }
      else
      {
        this.coldDrinkProducts.push(this.productList[i]);
      }
    }


  }

  constructor() { }
}
