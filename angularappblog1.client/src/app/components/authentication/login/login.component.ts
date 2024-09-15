import { Component } from '@angular/core';
import { LoginUser } from '../../models/LoginUser';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AccountService } from '../../services/accountService';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['login.css']
})
export class LoginComponent {
  loginForm!: FormGroup
  loginModel = new LoginUser();
  constructor(private formBuilder: FormBuilder, private accountService: AccountService, private router: Router) { }
  ngOnInit(): void {
    this.createLoginForm();
  }
  createLoginForm() {
    this.loginForm = this.formBuilder.group({
      email: new FormControl("", [Validators.required]),
      password: new FormControl("", [Validators.required])
    })
  }
  submitForm() {
    this.accountService.login(this.loginModel)
    if (this.accountService.loggedIn) {
      this.router.navigate(['topic'])
    } else {
      console.log("hatalı giriş")
    }
 
  }
}
