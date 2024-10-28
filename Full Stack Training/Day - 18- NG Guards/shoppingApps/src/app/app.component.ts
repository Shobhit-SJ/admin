import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { AuthorizeuserService } from '../services/authorizeuser.service';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,RouterLink, NgIf],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'shoppingApps';

  _authorizeruser:AuthorizeuserService;

  constructor(authorizeuser:AuthorizeuserService)
  {
     this._authorizeruser =authorizeuser
  }
}
