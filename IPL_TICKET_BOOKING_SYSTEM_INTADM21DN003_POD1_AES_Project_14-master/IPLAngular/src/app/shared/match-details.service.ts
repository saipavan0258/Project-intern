import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class MatchDetailsService {
  readonly url="http://localhost:51985/Api/MatchDetails/Add_MatchDetails";
  constructor(private http:HttpClient) {

   }
   addmatch(value:any){
    const details={
    //Match_Id:value.Match_Id,
      Location:value.Location,
      Date:value.Date,
      Battle:value.Battle
     
    }
    console.log(details);
    //return data;
   return this.http.post(this.url,details);
  }
}
