import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { ReactiveFormsModule} from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { StadiumDetailsComponent } from './stadium-details/stadium-details.component';
import { HomeComponent } from './home/home.component';
import { MatchDetailsComponent } from './match-details/match-details.component';
import { LoginComponent } from './login/login.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ToastrModule } from 'ngx-toastr';
import { StadiumMainComponent } from './stadium-main/stadium-main.component';
import { MatchMainComponent } from './match-main/match-main.component';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    StadiumDetailsComponent,
    HomeComponent,
    MatchDetailsComponent,
    LoginComponent,
    NavbarComponent,
    StadiumMainComponent,
    MatchMainComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
