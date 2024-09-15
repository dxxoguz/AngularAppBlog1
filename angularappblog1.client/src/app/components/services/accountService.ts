
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core'
import { RegisterModel } from '../models/RegisterModel';
import { CityModel } from '../models/CityModel';
import { DistrictModel } from '../models/DistrictModel';
import { Observable } from 'rxjs';
import { IndictinationModel } from '../models/IndictinationModel';
import { LoginUser } from '../models/LoginUser';
import { Router } from '@angular/router';
import { ReturnLoginUserModel } from '../models/ReturnLoginUserModel';
import { UserModel } from '../models/UserModel';



@Injectable({
  providedIn: 'root'
})

export class AccountService {
  userExist = true;
  loggedIn: boolean = false
  apiUrl = "https://localhost:7120"
  loggedUser = new UserModel


  constructor(private http: HttpClient, private router: Router) { }

  login(user: LoginUser): void {
    console.log(user)
    this.userExist = true;
    this.loggedIn = true;
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
     this.http.post<ReturnLoginUserModel>(this.apiUrl + '/Auth/Login', user, { headers: headers }).subscribe(
      response => {
        if (response.token) {
          localStorage.setItem("userToken", String(response.token));
          localStorage.setItem("userId", String(response.loginUser.id));
          this.loggedUser = response.loginUser;
        }
      },
      error => {
        console.error('Error:', error);
      }
    )
  }
  register(user: RegisterModel) {
    console.log(user)
    return this.http.post(this.apiUrl + '/Auth/AddUser', user).toPromise()
  }


  isLoggedIn() {
    return this.loggedIn
  }
  logOut() {
    this.userExist = false;
    this.loggedIn = false
    localStorage.removeItem("isLogged")
    this.router.navigate(["/home"]);
  }


}

