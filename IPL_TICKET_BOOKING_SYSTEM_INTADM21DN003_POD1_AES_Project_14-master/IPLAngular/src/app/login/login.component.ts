import { Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginform!: FormGroup;

  constructor(private fb: FormBuilder,
    private router: Router) { }

  ngOnInit(): void {

    this.loginform = this.fb.group({
      email: ['',[Validators.email,Validators.required]],
      password: ['',[Validators.minLength(3),Validators.required]],
      usertype: ['', Validators.required]
    })

  }

  get usertype(){
    return this.loginform.get('usertype');
  }

  login(){
    if(this.usertype?.value == 1){
       this.router.navigate(['home']);
    }
  }

}
