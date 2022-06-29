import { StadiumMainComponent } from './stadium-main/stadium-main.component';
import { MatchMainComponent } from './match-main/match-main.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StadiumDetailsComponent } from './stadium-details/stadium-details.component';
import { MatchDetailsComponent } from './match-details/match-details.component';
import { HomeComponent } from './home/home.component';
const routes: Routes = [
  {
    path: '', component: LoginComponent
  },
  {
    path: 'register', component: RegisterComponent
  },
  {
    path: 'home', component: HomeComponent
  },
  {
    path: 'match-main', component: MatchMainComponent
  },
  {
    path: 'match-details', component: MatchDetailsComponent
  },
  {
    path: 'stadium-main', component: StadiumMainComponent
  },
  {
    path: 'stadium-details', component: StadiumDetailsComponent
  },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
