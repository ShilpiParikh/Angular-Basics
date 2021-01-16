import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentMarkService {

studentData:StudentDetails[] = [
  {
    Name : 'Shilpi',
    Math:80,
    Science:50,
    English:80
  },
  {
    Name : 'Purva',
    Math:80,
    Science:90,
    English:90
  }
]
constructor() { }
}
export class StudentDetails{
Name:string = '';
Math:number = 0;
Science:number = 0;
English:number = 0;
}
