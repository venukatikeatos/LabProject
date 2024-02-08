import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LabReportsComponent } from './lab-reports/lab-reports.component';
import { HomeComponent } from './home/home.component';
import{ HttpClient, HttpClientModule }from '@angular/common/http'
import { PatientsModule } from './patients/patients.module';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LabReportsComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,PatientsModule
  ],
  providers: [],
  bootstrap: [AppComponent],
 exports:[
  NavbarComponent
 ]
})
export class AppModule { }
