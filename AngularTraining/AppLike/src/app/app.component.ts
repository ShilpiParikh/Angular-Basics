import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template:'<h1>App Like Functionality</h1> <button (click)="likeFunction()">LIKE</button>',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AppLike';
  constructor(){
  console.log("unlike stated");
}
public likebutton: number = 0;
 
    likeFunction(){
       
         if(this.likebutton==0){
          this.likebutton++;
          console.log("Button: liked", "Number of Likes", this.likebutton);
         }
         else{
           this.likebutton--;
           console.log("Buton: unliked", "Number of Likes", this.likebutton);
         }
            
        }
}