import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MakeapicallsService {


  // postdata:any; // variable to hold the data//1. make variable
  // _http:HttpClient;//2. create hhtpclient object

  // constructor(_httpRef:HttpClient) //3. inject the httpclient object in the constructor
  // {
  //   this._http=_httpRef;
  // }


  // //4. make a call to get the data
  // getPostDetails() 
  // {
  //   this._http.get("https://jsonplaceholder.typicode.com/posts")
  //   .subscribe((data)=>{ //this is like asynchronous this will update data just like youtube buffering
  //     this.postdata=data;
  //   })
  // }

//************Products******************************** */

  // productsdata:any;

  // _http:HttpClient;

  // constructor(_httpRef:HttpClient){
  //   this._http=_httpRef;
  // }

  // getProductsDetails()
  // {
  //   this._http.get("https://fakestoreapi.com/products")
  //   .subscribe((data=>{
  //     this.productsdata=data;
  //   }))
  // }



//********************************Users ************************/


usersdata:any;

_http:HttpClient;

constructor(_httpRef:HttpClient){
  this._http=_httpRef;
}

getUsersDetails()
{
  this._http.get("https://jsonplaceholder.typicode.com/users")
  .subscribe((data=>{
    this.usersdata=data;
  }))
}



  
}
