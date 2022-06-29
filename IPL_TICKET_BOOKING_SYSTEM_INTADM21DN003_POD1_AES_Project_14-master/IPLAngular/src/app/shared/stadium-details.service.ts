import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StadiumDetailsService {
  readonly url="http://localhost:51985/Api/StadiumDetails/Add_StadiumDetails";
  constructor(private http:HttpClient) { }
  addstadium(value:any){
    const details={
    
      Location:value.Location,
      Name:value.Name,
      Capacity:value.Capacity,
      Home_To:value.Home_To,
      Ends:value.Ends
    }
    console.log(details);
    //return data;
   return this.http.post(this.url,details);
  }
}
