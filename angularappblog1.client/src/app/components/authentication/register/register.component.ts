import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CityModel } from '../../models/CityModel';
import { DistrictModel } from '../../models/DistrictModel';
import { UserService } from '../../services/userService';
import { RegisterModel } from '../../models/RegisterModel';
import { AccountService } from '../../services/accountService';
import { Router } from '@angular/router';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['register.css']
})
export class RegisterComponent {
  registerForm!: FormGroup
  Cities:CityModel[] = [];
  Districts: DistrictModel[] = [];
  currentCityId: number = 0
  userModel = new RegisterModel; 
  constructor(private accountService: AccountService,private userService: UserService, private formBuilder: FormBuilder,private router:Router) {
   

  }

  ngOnInit(): void {

    this.getCities();
    this.createRegisterForm();

  }
  createRegisterForm() {
    this.registerForm = this.formBuilder.group({
      gender: new FormControl("", [Validators.required]),
      firstName: new FormControl("", [Validators.required]),
      lastName: new FormControl("", [Validators.required]),
      userName: new FormControl("", [Validators.required, Validators.minLength(4)]),
      password: new FormControl("", [Validators.required]),
      userEmail: new FormControl("", [Validators.required, Validators.email]),
      city: new FormControl("", [Validators.required]),
      district: new FormControl("", [Validators.required]),
      dateOfBirth: new FormControl("", [Validators.required]),
      customer_inform: new FormControl("", []),
      customer_allow: new FormControl("", [Validators.required] ),
      userId:new FormControl("",[])



    })
  }
  submitForm() {
    this.accountService.register(this.userModel).then(x => console.log(x))
      this.router.navigate([ ""])
 

    
  }
  getCities() {
    this.userService.getCities().then(res => {
      this.Cities = res as CityModel[];
    }).catch(error => {
      console.error('Error fetching cities:', error);
    });
  }

  onCityChange(event: Event) {
    const target = event.target as HTMLSelectElement
    const value = target.value
    this.getDistricts(Number(value));

  }

  getDistricts(cityId: number) {
    this.userService.getDistricts(cityId).then(res =>  this.Districts =res as DistrictModel[]);
  }

}


