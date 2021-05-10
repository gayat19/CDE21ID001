import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { CustomerComponent } from './customer/customer.component';
import { CustomerService } from './services/customer.service';
import { FlowersComponent } from './flowers/flowers.component';
import { Route,RouterModule } from '@angular/router';
import { FlowerComponent } from './flower/flower.component';
import { LoginComponent } from './login/login.component';
import { UserService } from './services/user.service';
import { DashboardComponent } from './dashboard/dashboard.component';
var myRoutes:Route[] =[
  {path:"dashboard/:un",component:DashboardComponent},
  {path:"",component:LoginComponent},
  {path:"home",component:EmployeeComponent},
  {path:"customer",component:CustomerComponent},
  {path:"flower",component:FlowersComponent,children:[
    {path:"flw",component:FlowerComponent}
  ]}

]
@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    CustomerComponent,
    FlowersComponent,
    FlowerComponent,
    LoginComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot(myRoutes)
  ],
  providers: [CustomerService,UserService],
  bootstrap: [AppComponent]
})


export class AppModule { }
