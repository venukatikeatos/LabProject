import { Component } from '@angular/core';
import { PatientsService } from '../sevrices/patients.service';
import { LabReportsService } from '../sevrices/lab-reports.service';

@Component({
  selector: 'app-lab-reports',
  templateUrl: './lab-reports.component.html',
  styleUrls: ['./lab-reports.component.css']
})
export class LabReportsComponent {
  patientsData: any;
  /**
   *
   */
  constructor(private labReportService: LabReportsService) {
    
  }
  ngOnInit(): void {
    // Call the patients() method from PatientsService to fetch patient data
    // this.patientsService.patients().subscribe(
    //   (data:any) => 
    //   {
    //     this.patientsData = data;
    //   },
    //   (error) => {
    //     console.error('Error fetching patients:', error);
    //   }
    // );
    this.getLabReports();
    
  }

  getLabReports(){
    this.labReportService.labReports().subscribe((data) =>{
      console.log('data',data);
      this.patientsData = data;

    })
  }
    
}