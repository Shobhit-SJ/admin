import { Routes } from '@angular/router';
import { HomeComponent } from '../components/home/home.component';
import { ContactComponent } from '../components/contact/contact.component';
import { AboutComponent } from '../components/about/about.component';
import { LoginComponent } from '../components/login/login.component';
import { RegisterComponent } from '../components/register/register.component';
import { WorkComponent } from '../components/work/work.component';

export const routes: Routes = [
    {path:'',redirectTo:'home', pathMatch:'full'},
    {path:'home',component:HomeComponent},
    {path:'Contact',component:ContactComponent}, //this Contact is casesensitive should match with app.component.html
    {path:'About',component:AboutComponent},
    {path:'Login',component:LoginComponent},
    {path:'Register',component:RegisterComponent},
    {path:'Work',component:WorkComponent}


];
