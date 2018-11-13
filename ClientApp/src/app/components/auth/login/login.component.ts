import { Component, OnInit } from '@angular/core';
import {Login} from '../../../models/Login';
import {AuthService} from '../../../services/auth/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  form = new Login();

  constructor(
    private authService: AuthService
  ) { }

  ngOnInit() {
  }

  public login() {

  }

}
