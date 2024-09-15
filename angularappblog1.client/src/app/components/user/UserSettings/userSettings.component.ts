import { Component } from "@angular/core";
import { UserSettingsModel } from "../../models/UserSettingModel";
import { UserService } from "../../services/userService";




@Component({
  selector: 'app-userSettings',
  templateUrl: './userSettings.component.html',
  styleUrls: ['userSettings.css']
})
export class UserSettingsComponent {
  userSettingModel!:UserSettingsModel
  constructor(private userService:UserService) {

  }


  ngOnInit(): void {


  }
  submitForm() {
    this.userSettingModel.userId = String(localStorage.getItem("userId"));
    this.userService.updateUserSettings(this.userSettingModel)
  }
}


