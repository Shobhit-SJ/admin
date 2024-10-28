import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GreetserviceService {

  greetUser()
  {
    alert('Welcome to services demo');

  }
  appName:string = 'Angular Service Demo';
  teamSize:number = 20;
  techList:string[] = [
    'Angular','NodeJs','MongoDB','MySql', 'ExpressJs'];

  constructor() { }
}
