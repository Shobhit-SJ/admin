import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'discount',
  standalone: true
})
export class DiscountPipe implements PipeTransform {

  transform(value: number, category:string ):number{

    if(category=="Shoes")
    {
      return value - ((15/100 )*value);
    }
    else if(category=="cloth")
    {
      return value - ((20/100 )*value);
    }
    else 
    {
      return value - ((30/100 )*value);
    }
    
  }

}
