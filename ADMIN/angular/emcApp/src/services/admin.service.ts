import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, ɵɵdeferPrefetchOnViewport } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  usersdata:any;
  addData:any;
  UpdateData:any;
  delData:any;

  _https:HttpClient;

  constructor(_httpRef:HttpClient){
    this._https=_httpRef;
  }
  
  httpOptions = {
    headers: new HttpHeaders({'Content-Type':'application/json'})
  }

  getAllDriverDetails()
{
  this._https.get("https://consultantwebapiazure.azurewebsites.net/api/Consultants")
  .subscribe((data=>{
    this.usersdata=data;
  }))

  

  
}
usertabledata:any;

addCnsultantFromFORMProfileinfo(data:any){
  // let newData = JSON.stringify(data.value);
  const userTable={
    userName: data.value.userName,
    phoneNum: data.value.phoneNum,
    userEmailId: data.value.userEmailId,
    userPassword: data.value.userPassword,


  }

  this._https.post("https://consultantwebapiazure.azurewebsites.net/api/users",userTable)
  .subscribe(result=>{
    this.usertabledata=result;


    const conTable ={

      userId: this.usertabledata.userId,
      profileInfo: data.value.profileInfo

    }
    // i am doing consultant table api call

    this._https.post("https://consultantwebapiazure.azurewebsites.net/api/Consultants",conTable) // where and what data
    .subscribe(response=>{
      console.log("data added:", response)
      alert("added")
    });
    
  })  
  // this._https.post("https://consultantwebapiazure.azurewebsites.net/api/Consultants",data.value) // where and what data
  // .subscribe(response=>{
  //   console.log("data added:", response)
  //   alert("added")
  // });
}

updateDriverDetails(data:any)
{
console.log(data.value);
  var test = {
    "driverUserId": 7,
    "driverName": "Shobhit",
    "driverPhoneNumber": 9900,
    "driverVehicleNumber": "jfjkdjf"
   };
this._https.put('https://localhost:7272/api/Drivers/' + data.value.driverUserId,JSON.stringify(data.value),this.httpOptions)
.subscribe(result =>{
  console.log(result)
})

}


updateDriverFromFORM(updatedata:any){
   // let newData = JSON.stringify(updatedata.value);
  // console.log(newData);
  // console.log(updatedata.value.driverUserId);
  console.log(updatedata);
  
  this._https.put(`https://consultantwebapiazure.azurewebsites.net/api/Consultants/${updatedata.value.consultantId}`,updatedata.value) // where and what data
  .subscribe(response=>{
    console.log("data udpdate:", response);
    alert("updated");
  })
}


// Update consultant information
// updateConsultant(updatedConsultant: any) {
//   const index = this..findIndex(c => c.id === updatedConsultant.id);
//   if (index !== -1) {
//     this.consultants[index] = updatedConsultant;
//   }
// }



updateDriverFromFORM1(updatedData: any) {
  const consultantId = updatedData.consultantId; // Ensure this field is available in the form data

  this._https.put(`https://consultantwebapiazure.azurewebsites.net/api/Consultants/${consultantId}`, updatedData.value)
    .subscribe(response => {
      console.log("Data updated:", response);
      alert("Consultant updated successfully!");
    }, error => {
      console.error("Error updating data:", error);
      alert("Failed to update consultant.");
    });
}





delDetails(delInfo:any)
  {
    let data = JSON.stringify(delInfo.value.consultantId);
    console.log(data);
    this._https.delete("https://consultantwebapiazure.azurewebsites.net/api/Consultants/"+data,this.httpOptions)
    .subscribe(response => {
      console.log('deleted',response);
      alert("deleted");
    })
  }



 //-------------------------------- // client-------------------------------------------

//  buyProduct() {
//   const userId = localStorage.getItem('clientId');
//   const productPrice = 10; // Deduct ₹10 for the product

//   this._https.put(`https://consultantwebapiazure.azurewebsites.net/api/Clients/${userId}`, { walletBalance: productPrice }).subscribe(
//     (response: any) => {
//       if (response.success) {
//         this.walletBalance = response.newBalance;  // Update the local balance after deduction
//         alert('Purchase successful! ₹10 deducted from your wallet.');
//       } else {
//         alert('Insufficient balance or transaction failed.');
//       }
//     },
//     (error) => {
//       console.error("Error deducting wallet balance", error);
//     }
//   );
// }



updateClient(updateClientdata:any){
  // let newData = JSON.stringify(updatedata.value);
 // console.log(newData);
 // console.log(updatedata.value.driverUserId);
 console.log(updateClientdata.value);
//  var clientid = clientId;
 
 //working fine
 //this._https.put('https://consultantwebapiazure.azurewebsites.net/api/Clients/updateWallet/1',JSON.stringify({newBalance:990}),this.httpOptions).subscribe(result =>{ console.log(result) });
 
 this._https.put(`https://consultantwebapiazure.azurewebsites.net/api/Clients/updateWallet/${updateClientdata.clientId}`,JSON.stringify({newBalance : updateClientdata.walletBalance}),this.httpOptions) // where and what data
//  //this._https.put("https://consultantwebapiazure.azurewebsites.net/api/Clients/updateWallet/1",updateClientdata.walletBalance) // where and what data
.subscribe(response=>{
   console.log("data udpdate:", response);
   alert("updated");
 })
}


  
}
