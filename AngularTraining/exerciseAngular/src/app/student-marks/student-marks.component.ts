import { Component, OnInit } from '@angular/core';
import { StudentDetails, StudentMarkService } from '../student-mark.service';

@Component({
  selector: 'app-student-marks',
  templateUrl: './student-marks.component.html',
  styleUrls: ['./student-marks.component.css']
})
export class StudentMarksComponent implements OnInit {
data : StudentDetails[] = [];
  constructor(private studentMarkService:StudentMarkService) { }

  ngOnInit(): void {
    this.data = this.studentMarkService.studentData;
  }

  average(item:StudentDetails){
    return (item.Math + item.Science + item.English)/3;
  }

}
