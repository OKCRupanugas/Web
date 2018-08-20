import { Component, OnInit } from '@angular/core';
import { GuestInfoService } from '../../shared/services/guestInfo.service';
import { GuestInfo } from '../../shared/models/guestInfo';
import { FormGroup, FormControl, FormArray, FormBuilder, Validators, ReactiveFormsModule } from '@angular/forms';



@Component({
  selector: 'app-guestinfo',
  templateUrl: './guestinfo.component.html',
  styleUrls: ['./guestinfo.component.css']
})
export class GuestInfoComponent implements OnInit {
  guests: GuestInfo[];
  webGuests: GuestInfo[]= new Array<GuestInfo>();
    errorMsg: string;
    guestForm: FormGroup;

  constructor(private guestInfoService: GuestInfoService) {

    }

    RegisterGuest() {
        this.webGuests.push(this.guestForm.value);
        console.log(this.guestForm.value);

        this.guestInfoService.RegisterGuest(this.guestForm.value);
    }

  ngOnInit() {
    this.guests = this.guestInfoService.getGuests();
    this.guestInfoService.getGuestsWeb().subscribe(
      guests => this.webGuests = guests,
      error => this.errorMsg = error
      );
      this.guestForm = new FormGroup({
          username: new FormControl(''),
          firstname: new FormControl(''),
          lastname:  new FormControl(''),
          phone:     new FormControl(''),
          email:     new FormControl(''),
          password:      new FormControl(''),
          confirmpassword:      new FormControl(''),
          confirmemail:     new FormControl('')
              //  new FormControl(''),

      });
  }

}
