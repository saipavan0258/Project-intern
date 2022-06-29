import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RegisterService } from '../shared/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  data = false;    
  IPLForm!: FormGroup;    
  massage:string='';

  constructor(private formbulider: FormBuilder,
    private registerservice: RegisterService,
    private toaster: ToastrService,
    private router: Router) { }

  ngOnInit(): void {

      this.IPLForm = this.formbulider.group({  
      FirstName: ['', [Validators.required,Validators.minLength(3)]],    
      LastName: ['', [Validators.required,Validators.minLength(3)]],
      Email: ['', [Validators.required,Validators.email]],     
      Password: ['', [Validators.required,Validators.minLength(6)]],    
      PhoneNumber: ['', [Validators.required,Validators.minLength(10)]],    
        
    });
  }

  get firstname(){
    return this.IPLForm.get('FirstName');
  }
  get LastName(){
    return this.IPLForm.get('LastName');
  }
  get Email(){
    return this.IPLForm.get('Email');
  }
  get Password(){
    return this.IPLForm.get('Password');
  }
  get PhoneNumber(){
    return this.IPLForm.get('PhoneNumber');
  }


  onFormSubmit(){

   this.registerservice.login(this.IPLForm.value).subscribe((Data)=> {
     alert('Successfully Registered!');
     });
    this.toaster.success('Successfully Registered!');
      this.router.navigate(['/']);
    
  }

}
