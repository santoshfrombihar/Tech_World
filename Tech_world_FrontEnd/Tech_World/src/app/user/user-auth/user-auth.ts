import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-user-auth',
  imports: [CommonModule],
  templateUrl: './user-auth.html',
  styleUrl: './user-auth.css'
})
export class UserAuth {
    authHeadingText = 'Login Here';
    loginFlag = false;

    changeUserForm(value: any){
      if(value == "Register"){
        this.authHeadingText = "Register Here"
        this.loginFlag = true;
      }
      else{
        this.loginFlag = false;
        this.authHeadingText = 'Login Here';
      }
    }
}
