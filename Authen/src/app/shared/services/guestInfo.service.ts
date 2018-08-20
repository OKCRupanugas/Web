import { Injectable } from '@angular/core';
import { GuestInfo } from '../models/guestInfo';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/observable';
import { catchError, tap } from 'rxjs/operators';
import { HttpHeaders } from '@angular/common/http';
import { Http, Response,RequestMethod, Headers, RequestOptions } from '@angular/http';


@Injectable()
export class GuestInfoService {
    private url= 'https://localhost:44315/api/';
    constructor(private http: HttpClient, private httppost:Http){}

    // tslint:disable-next-line:one-line
    getGuestsWeb(): Observable<GuestInfo []>{
    return this.http.get<GuestInfo []>(this.url + 'Volunteer/GetGuests').pipe(
        tap(data => console.log('Data from Server: ' + JSON.stringify(data))),
        catchError(this.handleError)
    );
    }

    RegisterGuest(guest: GuestInfo): any {
       // const headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });
        let headers = new Headers({ 'Content-Type': 'application/json', 'accept': '*/*' });
        let options = new RequestOptions({ headers: headers,method:RequestMethod.Post });
       
        let mydat = 
        {
            'userName': 'test3',
            'firstName': 'tFest3',
            'lastName': 'tLest3',
            'phone': '4564646545',
            'emailAddress': 'test3@test.com',
            'password': 'password',
            'active': 'true'
        }
        //formdata.append('username', 'test3');
        return this.httppost.post(this.url + 'GuestInfo', mydat, options).subscribe(data => {
            console.log(data);
        }, err => {
            console.log(err);
        });
    }

    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            console.error('An error occurred:', error.error.message);
          } else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            console.error(
              `Backend returned code ${error.status}, ` +
              `body was: ${error.error}`);
          }
          // return an observable with a user-facing error message
          return Observable.throw ('Something bad happened; please try again later.');
    }
getGuests(): GuestInfo [] {
    return [
        {
            'guestInfoId': 2,
            'phone': 99999999,
            'userName':'SampleGuest2',
                'firstName': 'SampleGuestFN2',
                 'lastName': 'SampleGuestLN2',
                 'emailAddress': 'SampleGuest2@SampleGuest',
                 'addressId': null,
                 'dob': null,
                 'age': null,
                'active': true
         }
         ,
        {
            'guestInfoId': 2,
        'phone': 99999999,
        'userName': 'SampleGuest2',
            'firstName': 'SampleGuestFN2',
            'lastName': 'SampleGuestLN2',
            'emailAddress': 'SampleGuest2@SampleGuest',
            'addressId': null,
            'dob': null,
            'age': null,
            'active': true

        },
        {

            'guestInfoId': 3,
            'phone': 99999999,
            'userName': 'SampleGuest3',
            'firstName': 'SampleGuestFN3',
            'lastName': 'SampleGuestLN3',
            'emailAddress': 'SampleGuest3@SampleGuest.com',
            'addressId': null,
            'dob': null,
            'age': null,
            'active': true
        }
        ,
        {

            'guestInfoId': 4,
            'phone': 99999999,
            'userName': 'SampleGuest4',
            'firstName': 'SampleGuestFN4',
            'lastName': 'SampleGuestLN4',
            'emailAddress': 'SampleGuest4@SampleGuest.com',
            'addressId': null,
            'dob': null,
            'age': null,
            'active': true
        }
        ,
        {

            'guestInfoId': 5,
            'phone': 99999999,
            'userName': 'SampleGuest5',
            'firstName': 'SampleGuestFN5',
            'lastName': 'SampleGuestLN5',
            'emailAddress': 'SampleGuest5@SampleGuest.com',
            'addressId': null,
            'dob': null,
            'age': null,
            'active': true
        }
      ];
}

}
