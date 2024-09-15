import { Component } from '@angular/core';
import { IndictinationModel } from '../models/IndictinationModel';
import { NgModel } from '@angular/forms';
import { UserService } from '../services/userService';



@Component({
  selector: 'app-indictination',
  templateUrl: './indictination.component.html',
  styleUrls: ['indictination.css']
})
export class IndictinationComponent {
  formModel = new IndictinationModel;
  constructor(private userService: UserService) { }
  ngOnInit(): void {


  } submitForm() {

    this.userService.addIndictination(this.formModel)
  }


}
