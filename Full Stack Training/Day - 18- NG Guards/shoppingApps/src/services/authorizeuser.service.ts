import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, GuardResult, MaybeAsync, RouterStateSnapshot } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthorizeuserService implements CanActivate{

  public loginResult = false;
  

  userLogin(username:string,password:string):boolean

 
  
  {
    if(username=='admin' && password=="admin1234")
    {
      this.loginResult=true;
    }
    else
    {
      this.loginResult=false;
    }
    return this.loginResult;
  }


  canActivate(): boolean 
  {
    return this.loginResult    
  }

  logout(){
    this.loginResult=false;
  }

  constructor() { }
}
