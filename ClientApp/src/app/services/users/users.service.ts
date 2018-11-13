import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {User} from '../../models/User';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  private registerUrl = 'https://localhost:44301/api/user/create';

  constructor(
    private http: HttpClient
  ) { }

  public register(user: User): void {

    this.http.post(this.registerUrl, user)
      .subscribe(
      data => {
        //alert('ok');
      },
      error => {
        ///console.log(error);
      });
  }
}
