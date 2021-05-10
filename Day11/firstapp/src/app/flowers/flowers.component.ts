import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-flowers',
  templateUrl: './flowers.component.html',
  styleUrls: ['./flowers.component.css']
})
export class FlowersComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  clickEmp(){
    this.router.navigate(["home"])
  }
  clickFlower(){
    this.router.navigate(["flower/flw"])
  }
}
