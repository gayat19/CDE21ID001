import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
username:string;
  constructor(private activeRoute:ActivatedRoute) {
    this.username = this.activeRoute.snapshot.params["un"];
   }

  ngOnInit(): void {
  }

}
