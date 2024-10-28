import { Routes } from '@angular/router';
import { HomeComponent } from '../common/home/home.component';
import { ProducthomeComponent } from '../Products/producthome/producthome.component';
import { CustomerhomeComponent } from '../Customers/customerhome/customerhome.component';
import { VendorhomeComponent } from '../Vendor/vendorhome/vendorhome.component';
import { OrderhomeComponent } from '../Orders/orderhome/orderhome.component';
import { AboutComponent } from '../common/about/about.component';
import { ContactComponent } from '../common/contact/contact.component';
import { LoginComponent } from '../common/login/login.component';
import { RegisterComponent } from '../common/register/register.component';
import { AddcustomerComponent } from '../Customers/addcustomer/addcustomer.component';
import { CustomerlistComponent } from '../Customers/customerlist/customerlist.component';
import { DeletecustomrsComponent } from '../Customers/deletecustomrs/deletecustomrs.component';
import { SearchcustomerComponent } from '../Customers/searchcustomer/searchcustomer.component';
import { UpdatecustomerComponent } from '../Customers/updatecustomer/updatecustomer.component';
import { AddProductComponent } from '../Products/add-product/add-product.component';
import { ProductListComponent } from '../Products/product-list/product-list.component';
import { DeleteProductComponent } from '../Products/delete-product/delete-product.component';
import { SearchProductComponent } from '../Products/search-product/search-product.component';
import { UpdateProductComponent } from '../Products/update-product/update-product.component';
import { AddorderComponent } from '../Orders/addorder/addorder.component';
import { OrderlistComponent } from '../Orders/orderlist/orderlist.component';
import { DeleteorderComponent } from '../Orders/deleteorder/deleteorder.component';
import { SearchorderComponent } from '../Orders/searchorder/searchorder.component';
import { UpdateorderComponent } from '../Orders/updateorder/updateorder.component';
import { AddvendorComponent } from '../Vendor/addvendor/addvendor.component';
import { VendorlistComponent } from '../Vendor/vendorlist/vendorlist.component';
import { DeletevendorComponent } from '../Vendor/deletevendor/deletevendor.component';
import { SearchvendorComponent } from '../Vendor/searchvendor/searchvendor.component';
import { UpdatevendorComponent } from '../Vendor/updatevendor/updatevendor.component';

export const routes: Routes = [
    // {path:'', redirectTo:'home',pathMatch:'full'},
    // {path:'home',component:HomeComponent},
    // {path:'producthome',component:ProducthomeComponent,children:[
    //     {path:'',redirectTo:'producthome',pathMatch:'full'},
    //     {path:'addproduct',component:AddProductComponent},
    //     {path:'productlink',component:ProductListComponent},
    //     {path:'delteproduct',component:DeleteProductComponent},
    //     {path:'searchproduct',component:SearchProductComponent},
    //     {path:'updateproduct',component:UpdateProductComponent},


    // ]},
    // {path:'customerhome',component:CustomerhomeComponent,children:[
    //     {path:'',redirectTo:'customerhome',pathMatch:'full'},
    //     {path:'addcustomer',component:AddcustomerComponent},
    //     {path:'customerlink',component:CustomerlistComponent},
    //     {path:'deltecustomer',component:DeletecustomrsComponent},
    //     {path:'searchcustomer',component:SearchcustomerComponent},
    //     {path:'updatecustomer',component:UpdatecustomerComponent},


    // ]},
    // {path:'vendorhome',component:VendorhomeComponent,children:[
    //     {path:'',redirectTo:'vendorhome',pathMatch:'full'},
    //     {path:'addvendor',component:AddvendorComponent},
    //     {path:'vendorlink',component:VendorlistComponent},
    //     {path:'deltevendor',component:DeletevendorComponent},
    //     {path:'searchvendor',component:SearchvendorComponent},
    //     {path:'updatevendor',component:UpdatevendorComponent},


    // ]},
    // {path:'ordershome',component:OrderhomeComponent,children:[
    //     {path:'',redirectTo:'ordershome',pathMatch:'full'},
    //     {path:'addorder',component:AddorderComponent},
    //     {path:'orderlink',component:OrderlistComponent},
    //     {path:'delteorder',component:DeleteorderComponent},
    //     {path:'searchorder',component:SearchorderComponent},
    //     {path:'updateorder',component:UpdateorderComponent}



    // ]},
    // {path:'about',component:AboutComponent},
    // {path:'contact',component:ContactComponent},
    // {path:'login',component:LoginComponent},
    // {path:'register',component:RegisterComponent},



    {path:'login', component:LoginComponent},
    {path:'register', component:RegisterComponent},
    {path:'home', component:HomeComponent}


    

    
    

    



];
