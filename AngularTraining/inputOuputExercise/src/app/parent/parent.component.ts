import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {

  ng = 'Angular'
  result = ''
  constructor() { }
    
  onClickMethod(st:string): void {
    this.result = "This is the app component. I received a string '" + st + "' from the hello component" 
    + " and I capitalize it here " + st.toUpperCase()
  }
  ngOnInit(): void {
  }

}
