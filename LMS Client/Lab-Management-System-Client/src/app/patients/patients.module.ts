import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AllPatientsComponent } from './all-patients/all-patients.component';
import { PostPatientsComponent } from './post-patients/post-patients.component';
import { ModifyPatientsComponent } from './modify-patients/modify-patients.component';
import { CratePatientsComponent } from './crate-patients/crate-patients.component';
import { PatientsComponent } from './patients.component';
import { AppModule } from '../app.module';



@NgModule({
  declarations: [
    AllPatientsComponent,
    PostPatientsComponent,
    ModifyPatientsComponent,
    CratePatientsComponent,
    PatientsComponent
  ],
  imports: [
    CommonModule,AppModule
  ],
  exports:[
    AllPatientsComponent
  ]
})
export class PatientsModule { }
