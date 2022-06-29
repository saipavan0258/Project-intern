import { Injectable } from '@angular/core';
import {BehaviorSubject, Subject, throwError} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {catchError, map, retry} from 'rxjs/operators';
//import { CompanyService } from '../company.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {
  url : string = "http://localhost:52682/api/auth";
  private isLoggedIn = new BehaviorSubject<boolean> (false);
  private CallMethodSource  = new Subject<any>();
  CallMethodSource$ = this.CallMethodSource.asObservable();
  SetAuthenticated() {
    this.CallMethodSource.next();
  }
  OnLoggedIn = this.isLoggedIn.asObservable();
  flag: any;
  constructor(private http : HttpClient, 
    private router: Router) { }
   isAuthenticated(status : boolean) {
     this.isLoggedIn.next(status);
   }

 

  get logout() {
    return this.http.get(this.url + '/logout')
        .pipe(map((response) => {
        
          return response}))
        
}




}
