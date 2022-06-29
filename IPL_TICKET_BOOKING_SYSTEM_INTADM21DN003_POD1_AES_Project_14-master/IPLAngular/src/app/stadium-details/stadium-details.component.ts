import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { StadiumDetailsService} from '../shared/stadium-details.service';
import { ToastrService } from 'ngx-toastr';

import { Router } from '@angular/router';
@Component({
  selector: 'app-stadium-details',
  templateUrl: './stadium-details.component.html',
  styleUrls: ['./stadium-details.component.css']
})
export class StadiumDetailsComponent implements OnInit {
  data = false;    
  IPLForm!: FormGroup; 
  constructor( private formbulider: FormBuilder,
    private stadiumdetails:StadiumDetailsService,
    private toaster: ToastrService,
    private router: Router) { }

  ngOnInit(): void {
    this.IPLForm = this.formbulider.group({  
      Match_Id:[''], 
      Location: ['', [Validators.required,Validators.minLength(4)]],    
      Name: ['', [Validators.required,Validators.minLength(4)]],
      Capacity: ['', [Validators.required,Validators.minLength(1)]] ,
     Home_To : ['', [Validators.required,Validators.minLength(4)]] ,
     Ends: ['', [Validators.required,Validators.minLength(4)]] ,
    
    });
  }
  get Location(){
    return this.IPLForm.get('Location');
  }
  get Name(){
    return this.IPLForm.get('Name');
  }
  get Capacity(){
    return this.IPLForm.get('Capacity');
  }
  get Home_To(){
    return this.IPLForm.get('Home_To');
  }
  get Ends(){
    return this.IPLForm.get('Ends');
  }
  onFormSubmit(){
  
    this.stadiumdetails.addstadium(this.IPLForm.value).subscribe((Data)=> {
      console.log('nnn',Data);
     
      this.toaster.error('Successfully Registered','....!');
      //this.router.navigate(['match-details']);
  this.IPLForm.reset();
  alert('Stadium Details Added Successfully');
      this.router.navigate(['match-main']);
      
     
     });
    

}
  }
