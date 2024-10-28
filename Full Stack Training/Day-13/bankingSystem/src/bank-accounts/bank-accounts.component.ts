import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-bank-accounts',
  standalone: true,
  imports: [NgFor, NgClass],
  templateUrl: './bank-accounts.component.html',
  styleUrl: './bank-accounts.component.css'
})
export class BankAccountsComponent {
  accountDetails:any[] = [
    {accNo:101,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:102,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:103,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:false},
    {accNo:104,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:105,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:false},
    {accNo:106,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:107,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:false},
    {accNo:108,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:109,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:110,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:true},
    {accNo:111,accName:"Mobile",accType:20000,accBalance:50000,accIsActive:false}
    
    
  ];

  uniqueAccTypes:string[] = ["Savings","Current","Loan"];

}
