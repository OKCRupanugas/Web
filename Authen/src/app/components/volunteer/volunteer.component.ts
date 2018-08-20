
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormArray, FormBuilder, Validators, ReactiveFormsModule } from '@angular/forms';
import { VolunteerService } from '../../shared/services/volunteer.service';
import { Volunteer } from '../../shared/models/models';

@Component({
  selector: 'app-volunteer',
  templateUrl: './volunteer.component.html',
  styleUrls: ['./volunteer.component.css']
})
export class VolunteerComponent implements OnInit {
  dropdownList = [];
  selectedItems = [];
  config = {};
    volunteerForm: FormGroup;
    dataModel: any;
    errorMsg: string;


    constructor(private volunteerService: VolunteerService) {

    }
  RegisterVolunteer() {
    const volunteer = new Volunteer();
    volunteer.emailAddress = this.email.value;
    volunteer.phone = this.phone.value;
    volunteer.Name = this.volname.value;
    volunteer.services = this.dataModel.map(x =>   x.serviceTypeName);
   this.volunteerService.RegisterVolunteer(volunteer);
}

  ngOnInit () {

    this.volunteerService.getAllServiceTypes().subscribe(
      serviceTypes => this.dropdownList = serviceTypes,
      error => this.errorMsg = error
    );
    this.volunteerForm = new FormGroup({
      volname: new FormControl(''
      , [Validators.required, Validators.minLength(4)]
    ),
      email: new FormControl(''
      , [Validators.required, Validators.pattern('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$')]),
     // services:  new FormControl(''),
      phone: new FormControl('', [Validators.required, Validators.pattern('^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}$')]
    )
      });

   this.config = {
      displayKey: 'serviceTypeName', // if objects array passed which key to be displayed defaults to description
      search: true, // true/false for the search functionlity defaults to false,
      height: 'auto', // height of the list so that if there are more no of items
      // it can show a scroll defaults to auto. With auto height scroll will never appear
      placeholder: 'Select Service', // text to be displayed when no item is selected defaults to Select,
      customComparator: () => {}, // a custom function using which user wants to sort the items. default is undefined
      // and Array.sort() will be used in that case,
      limitTo: this.dropdownList.length // a number thats limits the no of options displayed in the UI similar to angular's limitTo pipe
    }
  }
  get volname() { return this.volunteerForm.get('volname'); }
  get email() { return this.volunteerForm.get('email'); }
  get phone() { return this.volunteerForm.get('phone'); }

  onItemSelect (item: any) {
      console.log(JSON.stringify(this.dataModel));
      console.log(JSON.stringify(this.dataModel[0]));
  }
  onSelectAll (items: any) {
     console.log(JSON.stringify(this.dataModel));
     // console.log(JSON.stringify(this.dataModel.value[0].value[0]));
  }
}
