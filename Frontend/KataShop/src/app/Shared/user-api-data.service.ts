import { Login } from './../Models/Login';
import { Registration } from './../Models/Registration';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserApiDataService {

  constructor(private client: HttpClient) { }

  Registration(registration: Registration): Observable<Registration>
  {
    // tslint:disable-next-line:quotemark
    return this.client.post<Registration>("https://localhost:44354/api/Account/register", registration);
  }
  Login(login: Login): Observable<Login>
  {
    // tslint:disable-next-line:quotemark
    return this.client.post<Login>("https://localhost:44354/api/Account/login", login);
  }
}
