import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Register} from '../../models/Register';

@Injectable({
  providedIn: 'root'
})

export class RegisterService {

  private registerUrl = 'https://localhost:44301/api/user/create';
  constructor(
    private http: HttpClient
  ) { }

  public register(form: Register): void {

    this.http.post(this.registerUrl, form)
      .subscribe(
        data => {
         // alert('ok');
        },
        error => {
         // console.log(error);
        });
  }
}
