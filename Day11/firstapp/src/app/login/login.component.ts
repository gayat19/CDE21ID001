import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../models/user.model';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
user:User;
message:string;
className:string;
  constructor(private userSerivce:UserService,private router:Router) {
    this.user = new User();
   }

  ngOnInit(): void {
  }
  checkLogin(){
    if(this.userSerivce.userLogin(this.user))
     {
      // this.message = "Login success";
      // this.className = "alert alert-success";
      console.log("Login success")
      this.router.navigate(["dashboard",this.user.username]);
     }
     else
     {
      this.message = "Invalid username or password";
      this.className = "alert alert-danger";
     }
     this.user = new User();
  }
  reset(){
    this.user = new User();
  }

}
