import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LabReportsService {

  url='https://localhost:7239/LabReport';
  
  constructor(private http:HttpClient) 
  {
    
  }
    labReports():Observable<any>
      {
        return this.http.get(this.url);
      }

}
