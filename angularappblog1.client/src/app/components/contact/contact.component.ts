import { Component } from '@angular/core';
import { ContactModel } from '../models/ContactModel';
import { UserService } from '../services/userService';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['contact.css']
})
export class ContactComponent {
  constructor(private userService: UserService) { }
  public contactModel = new ContactModel
  ngOnInit(): void {
    this.userService.getContactInfo().then(inf => this.contactModel = inf as ContactModel).then(inf=> console.log(inf))

  }


}

