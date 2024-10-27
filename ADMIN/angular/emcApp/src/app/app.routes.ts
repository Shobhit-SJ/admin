import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from '../components/admins/add/add.component';
import { DeleteComponent } from '../components/admins/delete/delete.component';
import { UpdateComponent } from '../components/admins/update/update.component';
import { ListComponent } from '../components/admins/list/list.component';
import { RewardsComponent } from '../components/admins/rewards/rewards.component';
import { ClientsComponent } from '../components/admins/clients/clients.component';


export const routes: Routes = [
  { path: 'add', component:AddComponent },
  { path: 'delete', component: DeleteComponent},
  { path: 'update', component: UpdateComponent },
  { path: 'list', component: ListComponent },
  { path: 'rewards', component: RewardsComponent },
  { path: 'clients', component: ClientsComponent},
  { path: '', redirectTo: '/list ', pathMatch: 'full' }
];

//  @NgModule({
//    imports: [RouterModule.forRoot(routes)],
//    exports: [RouterModule]
//  })
//  export class AppRoutingModule {}
