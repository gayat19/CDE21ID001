import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employeeName:string;
  constructor() { 
    this.employeeName = "Ramu";
  }

  ngOnInit(): void {
  }
  changeText(name){
    this.employeeName = name.value;
  }
}
