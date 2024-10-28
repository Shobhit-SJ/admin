import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AuthorizeuserService } from '../../services/authorizeuser.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  _authorizeruser:AuthorizeuserService;

  constructor(authorizeuser:AuthorizeuserService)
  {
     this._authorizeruser =authorizeuser
  }

}
