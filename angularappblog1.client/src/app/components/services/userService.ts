
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core'
import { RegisterModel } from '../models/RegisterModel';
import { CityModel } from '../models/CityModel';
import { DistrictModel } from '../models/DistrictModel';
import { Observable } from 'rxjs';
import { IndictinationModel } from '../models/IndictinationModel';
import { LoginUser } from '../models/LoginUser';
import { UserSettingsModel } from '../models/UserSettingModel';
import { ReturnLoginUserModel } from '../models/ReturnLoginUserModel';



@Injectable({
  providedIn: 'root'
})

export class UserService {

  apiUrl = "https://localhost:7120"     
  /* apiUrl = "https://localhost:7120 http://localhost:5290 " */

  constructor(private http: HttpClient) { }


  getCities() {
    return this.http.get<CityModel[]>(this.apiUrl + '/User/GetCities').toPromise();
  }
  getDistricts(cityId: number){
    return this.http.get(this.apiUrl + `/User/GetDistricts?cityId=${cityId}`).toPromise()
  }
  getCategories() {
    return this.http.get(this.apiUrl + `/User/GetCategories`).toPromise()
  }
  addIndictination(userIndictination: IndictinationModel) {
    return this.http.post(this.apiUrl + `/User/AddIndictination`,userIndictination).toPromise()
  }
  getContactInfo() {
   return this.http.get(this.apiUrl + "/User/GetContactInfo").toPromise();
  }
  updateUserSettings(userSettings: UserSettingsModel) {
    return this.http.post (this.apiUrl + `/User/UpdateUserSettings`, userSettings).toPromise();
  }

}



