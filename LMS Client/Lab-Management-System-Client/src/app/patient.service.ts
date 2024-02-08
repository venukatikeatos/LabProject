import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'


@Injectable({
  providedIn: 'root'
})
export class PatientService {
url='https://localhost:7239/LabReport';
  
    constructor(private http:HttpClient) 
    {
        

  
}
patients()
        {
          return this.http.get(this.url);
        }
}
