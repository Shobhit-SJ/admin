import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ApidataComponent } from "../components/apidata/apidata.component";
import { AddapidataComponent } from '../components/addapidata/addapidata.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ApidataComponent,AddapidataComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'consumeOwnApi';
}
