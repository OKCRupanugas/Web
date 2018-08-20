import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {
    model = {
        left: true,
        middle: false,
        right: false
    };
    constructor() { }
    // tslint:disable-next-line:member-ordering
    guests: any = [{
        guestInfoId: 1,
        firstName: 'SampleGuest1',
        lastName: 'SampleLastName1',
        emailAddress: 'SampleGuest@sample.com'
    },
    {
        guestInfoId: 2,
        firstName: 'SampleGuest2',
        lastName: 'SampleLastName2' ,
        emailAddress: 'SampleGuest@sample.com'
    },
    {
        guestInfoId: 3,
        firstName: 'SampleGuest3',
        lastName: 'SampleLastName3' ,
        emailAddress: 'SampleGuest@sample.com'
    }
]
    ngOnInit() {}
}
