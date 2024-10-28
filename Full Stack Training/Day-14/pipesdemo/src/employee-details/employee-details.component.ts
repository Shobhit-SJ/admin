import { CurrencyPipe, DatePipe, JsonPipe, NgFor, UpperCasePipe } from '@angular/common';
import { Component } from '@angular/core';
import { GenderpipePipe } from '../pipes/genderpipe.pipe';
import { SalaryStandardPipe } from '../pipes/salary-standard.pipe';

@Component({
  selector: 'app-employee-details',
  standalone: true,
  imports: [UpperCasePipe, CurrencyPipe, DatePipe, NgFor,JsonPipe,GenderpipePipe, SalaryStandardPipe],
  templateUrl: './employee-details.component.html',
  styleUrl: './employee-details.component.css'
})
export class EmployeeDetailsComponent {

  empNo: number =101;
  empName: string  = "Shobhit JeeT AnaNd"
  empSalary: number = 800000;
  empIsPermanent: boolean = true;
  empDOB = new Date();

  employeeInfo = [
    {empNo:101, empLastName:"jaiswal", empName: "Shobhit JeeT AnaNd",empSalary: 8000,empIsPermanent: true,empDOB: new Date()  , empGender: 'Male'},
    {empNo:102, empLastName:"jaiswal", empName: " JeeT AnaNd SHobhit",empSalary: 41000,empIsPermanent: false,empDOB: new Date(), empGender: 'Male'},
    {empNo:103, empLastName:"jaiswal", empName: "Shobhit AnaNd JEET",empSalary: 22000,empIsPermanent: false,empDOB: new Date() , empGender: 'Male' },
    {empNo:104, empLastName:"jaiswal", empName: " JeeT Shobhit AnaNd",empSalary: 60000,empIsPermanent: true,empDOB: new Date() , empGender: 'Female' },
    {empNo:105, empLastName:"jaiswal", empName: "Suhani JeeT AnaNd",empSalary: 70000,empIsPermanent: false,empDOB: new Date()  , empGender: 'Female'},
    {empNo:106, empLastName:"jaiswal", empName: "Shobhit anurag AnaNd",empSalary: 10000,empIsPermanent: true,empDOB: new Date(), empGender: 'Male' },
    {empNo:107, empLastName:"jaiswal", empName: "Anurag JeeT AnaNd",empSalary: 240000,empIsPermanent: true,empDOB: new Date()   , empGender: 'Female' },
    {empNo:108, empLastName:"jaiswal", empName: "Suhani aunrag AnaNd",empSalary: 30000,empIsPermanent: false,empDOB: new Date(), empGender: 'Female'},
  ]

}
