import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'genderpipe',
  standalone: true
})
export class GenderpipePipe implements PipeTransform {

  transform(value: string, gender: string):string {
    if(gender == 'Male')
    {
      return "Mr. "+value
    }
    else{
      return "Miss. "+value
    }
  }

}
