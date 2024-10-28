import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ConsumerestService {

  pData:any;
  addData:any;
  delData:any;
  searchData:any;
  _http:HttpClient;


  constructor(_httpRef:HttpClient)
  {
    this._http=_httpRef;
  }

  getOwnProductdetail(){
    this._http.get("https://localhost:7057/api/Customers")
    .subscribe((data=>{
      this.pData=data;
    }))
    
  }


  
    
  custData:any ={    
      "cId": 223422,
      "cName": "Tanvi",
      "cBalance": 4360,
      "cAddress": "098765,abc,xyz"
    
  }
  adddata= JSON.stringify(this.custData)

  upData:any ={
    "cId": 1234654356,
      "cName": "ghwduiegffhwvouwf",
      "cBalance": 4546352,
      "cAddress": "098765,abc,xyzgrfds"

  }

  httpOptions = {
    headers: new HttpHeaders({'Content-Type' : ['application/json','application/text']})
  }

  addownProductdetailFromFORM(data:any){
    let newData = JSON.stringify(data.value);
    
    this._http.post("https://localhost:7057/api/Customers"+newData,this.httpOptions) // where and what data
    .subscribe(response=>{
      console.log("data added:", response)
      alert("added")
    });
  }


  delPdata(){
    this._http.delete("https://localhost:7057/api/Customers/2")
    .subscribe(response=>{
      console.log("delete", response)
      alert("delete")
    });
  }

  updateData(){
    this._http.put("https://localhost:7057/api/Customers/1234654356",this.upData)
    .subscribe(response=>{
      console.log("update", response)
      alert("update")
    });
  }


  searchOwnProductdetail(){
    this._http.get("https://localhost:7057/api/Customers/1234654356")
    .subscribe((data=>{
      this.searchData=data;
      alert("searched")
    }))
    
  }



}
