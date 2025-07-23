import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UserAuth } from './user/user-auth/user-auth';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet, UserAuth],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Tech_World';
}
