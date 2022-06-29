import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatchDetailsService} from '../shared/match-details.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
@Component({
  selector: 'app-match-details',
  templateUrl: './match-details.component.html',
  styleUrls: ['./match-details.component.css']
})
export class MatchDetailsComponent implements OnInit {
  data = false;    
  IPLForm!: FormGroup;  
  constructor(
    private formbulider: FormBuilder,
    private matchdetails:MatchDetailsService,
    private toaster: ToastrService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.IPLForm = this.formbulider.group({  
      Match_Id:[''], 
      Location: ['', [Validators.required,Validators.minLength(5)]],    
      Date: ['', [Validators.required,Validators.minLength(8)]],
      Battle: ['', [Validators.required,Validators.minLength(6)]] 
        
    });
  }
  get Match_Id(){
    return this.IPLForm.get('Match_Id');
  }
  get Location(){
    return this.IPLForm.get('Location');
  }
  get Date(){
    return this.IPLForm.get('Date');
  }
  get Battle(){
    return this.IPLForm.get('Battle');
  }
 
  onFormSubmit(){
  
    this.matchdetails.addmatch(this.IPLForm.value).subscribe((Data)=> {
      console.log('nnn',Data);
     
      this.toaster.error('Successfully Registered','....!');
      //this.router.navigate(['match-details']);
  this.IPLForm.reset();
  alert('Match Details Added Successfully');
  this.router.navigate(['match-main']);
      
     
     });

}
}
