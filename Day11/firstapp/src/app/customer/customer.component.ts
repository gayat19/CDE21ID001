import { Component, OnInit } from '@angular/core';
import { Customer } from '../models/customer.model';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  customer:Customer
  customers:Customer[];
  constructor(private customerService:CustomerService) {
    //this.customer = 
   // new Customer(101,"Ramu",23,"assets/pic1.jfif");
   this.customer = new Customer();
   this.customers = this.customerService.getCustomers();
   }
   addCustomer(){
     this.customerService.addCustomer(this.customer);
     this.customer = new Customer();
   }
  ngOnInit(): void {
  }

}
