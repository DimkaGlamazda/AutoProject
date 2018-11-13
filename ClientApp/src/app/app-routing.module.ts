import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {RegisterComponent} from './components/auth/register/register.component';
import {CatalogueComponent} from './components/catalogue/catalogue.component';
import {LoginComponent} from './components/auth/login/login.component';

const routes: Routes = [
  { path: 'register', component:  RegisterComponent },
  { path: 'login', component:  LoginComponent },
  { path: 'catalogue', component: CatalogueComponent },
  { path: '', redirectTo: '/catalogue', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
