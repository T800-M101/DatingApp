import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model:any = {};
  user:string;
 

  constructor(public accountService:AccountService) { }

  ngOnInit(): void {
    this.getUser();
  }


  login(){
    this.accountService.login(this.model).subscribe(response => {
      this.getUser();
         
    }, error => {
      console.log(error);
    });
  }

  logout(){
    this.accountService.logout();
  
  }

  getUser(){
    this.accountService.currentUser$.subscribe(user => {
      this.user = user.username;
      console.log(this.user);
    })
  }

}
