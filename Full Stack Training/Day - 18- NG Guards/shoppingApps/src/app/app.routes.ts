import { Routes } from '@angular/router';
import { HomeComponent } from '../components/home/home.component';
import { NotFoundComponent } from '../components/not-found/not-found.component';
import { AboutComponent } from '../components/about/about.component';
import { ContactComponent } from '../components/contact/contact.component';
import { CartComponent } from '../components/cart/cart.component';
import { OrdersComponent } from '../components/orders/orders.component';
import { LoginComponent } from '../components/login/login.component';
import { WalletComponent } from '../components/wallet/wallet.component';
import { AuthorizeuserService } from '../services/authorizeuser.service';

export const routes: Routes = [

    {path:'', redirectTo:'home', pathMatch:'full'},
    {path:'home',component:HomeComponent},
    {path:'about', component:AboutComponent},
    {path:'contact', component:ContactComponent},
    {path:'cart', component:CartComponent,canActivate:[AuthorizeuserService]},
    {path:'orders', component:OrdersComponent,canActivate:[AuthorizeuserService]},
    {path:'login', component:LoginComponent},
    {path:'wallet', component:WalletComponent,canActivate:[AuthorizeuserService]},
    {path:'**', component:NotFoundComponent},
];
