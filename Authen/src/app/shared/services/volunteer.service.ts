import { Injectable } from '@angular/core';
import { Volunteer, ServiceType } from '../models/models';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/observable';
import { catchError, tap } from 'rxjs/operators';
import { HttpHeaders } from '@angular/common/http';
import { Http, Response, RequestMethod, Headers, RequestOptions } from '@angular/http';


@Injectable()
export class VolunteerService {
    private url= 'https://localhost:44315/api/';
    constructor(private http: HttpClient, private httppost:Http){}

    // tslint:disable-next-line:one-line
    getAllServiceTypes(): Observable<ServiceType []>{
    return this.http.get<ServiceType []>(this.url + 'Volunteer/GetAllServiceTypes').pipe(
        tap(data => console.log('Data from Server: ' + JSON.stringify(data))),
        catchError(this.handleError)
    );
    }

    RegisterVolunteer(volunteer: Volunteer): any {
       // const headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });
        const headers = new Headers({ 'Content-Type': 'application/json', 'accept': '*/*' });
        const options = new RequestOptions({ headers: headers, method: RequestMethod.Post });

        const mydat =
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

}
