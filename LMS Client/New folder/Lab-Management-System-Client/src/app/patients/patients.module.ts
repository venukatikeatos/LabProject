import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppModule } from '../app.module';
import { PatientsComponent } from './patients.component';



@NgModule({
  declarations: [
    PatientsComponent
  ],
  imports: [
    CommonModule,
    AppModule
  ]
})
export class PatientsModule { }
