import { Component, OnInit } from '@angular/core';
import {Register} from '../../../models/Register';
import {RegisterService} from '../../../services/auth/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  form = new Register();

  constructor(
    private service: RegisterService
  ) { }

  ngOnInit() {
  }

  save(): void {
    this.service.register(this.form);
  }
}
