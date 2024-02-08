import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LabReportsComponent } from './lab-reports/lab-reports.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AllPatientsComponent } from './patients/all-patients/all-patients.component';
import { PostPatientsComponent } from './patients/post-patients/post-patients.component';
import { ModifyPatientsComponent } from './patients/modify-patients/modify-patients.component';
import { CratePatientsComponent } from './patients/crate-patients/crate-patients.component';
import { PatientsComponent } from './patients/patients.component';

const routes: Routes = [

  {path:'',component:HomeComponent},
  {path:'LabReports',component:LabReportsComponent},
  {path:'Patients', component:PatientsComponent,
  children:[
    {path:'All', component:AllPatientsComponent},
    {path:'Post', component:PostPatientsComponent},
    {path:'Modify', component:ModifyPatientsComponent},
    {path:'Delete', component:CratePatientsComponent},
  ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
