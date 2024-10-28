import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'salaryStandard',
  standalone: true
})
export class SalaryStandardPipe implements PipeTransform {

  transform(value: any):string {
    if(value<10000)
    {
      return "vary low salary"; 
    }
    else if(value>10000 && value<20000)
    {
      return "Moderate Salary";
    }
    else if(value>20000 && value <= 30000)
    {
      return "Good Salary";
    }
  else if(value>30000 && value<50000)
    {
     return "Very good Salary";

    }
  else (value>50000)
  {
    return "Excellent Salary";

  }
  }

}
