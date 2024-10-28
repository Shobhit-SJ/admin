import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'profitLoss',
  standalone: true
})
export class ProfitLossPipe implements PipeTransform {

  transform(value: number, cur: number):string {

    if(value< cur)
    {
      return "Profit";
    }
    else
    {
      return "Loss";
    }
    
  }
}
