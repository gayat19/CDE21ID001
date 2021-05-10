import { Customer } from "../models/customer.model";


export class CustomerService{
    customers:Customer[];

    constructor() {
    // this.customers = [
    //     new Customer(101,"Ramu",23,"assets/pic1.jfif"),
    //     new Customer(102,"Somu",25,"assets/pic2.jfif")
    // ];
    this.customers =[];
    }

    addCustomer(customer){
        this.customers.push(customer);
    }
    getCustomers(){
        return this.customers;
    }
    deleteCustomer(id){
        let idx = -1;
        for (let index = 0; index < this.customers.length; index++) {
           if(this.customers[index].id == id)
                idx = index;
        }
        if(idx>-1)
            this.customers.splice(idx,1);
    }
}