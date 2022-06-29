import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  readonly url="http://localhost:51985/Api/Register/createAccount";
  constructor(private http: HttpClient) {

   }

   login(value:any){
     const data= {
       FirstName: value.FirstName,
       LastName: value.LastName,
       Email: value.Email,
       PhoneNumber: value.PhoneNumber,
       Password: value.Password
     }
     console.log(data);
    return this.http.post(this.url,data);
   }

}
