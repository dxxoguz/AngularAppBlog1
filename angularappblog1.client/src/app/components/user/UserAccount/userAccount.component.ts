import { Component } from '@angular/core';
import { RegisterModel } from '../../models/RegisterModel';
import { AccountService } from '../../services/accountService';



@Component({
  selector: 'app-userAccount',
  templateUrl: './userAccount.component.html',
  styleUrls: ['userAccount.css']
})
export class UserAccountComponent {

  constructor(public accountService: AccountService) {


  }

  ngOnInit(): void {




  }


}
