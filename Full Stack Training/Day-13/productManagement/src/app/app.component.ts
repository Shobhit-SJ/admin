import { Component, NgModule } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PrimitiveDataComponent } from "../primitive-data/primitive-data.component";
import { PrimitiveDataArrayComponent } from "../primitive-data-array/primitive-data-array.component";
import { JsonObjectComponent } from "../json-object/json-object.component";
import { JsonObjectArrayComponent } from "../json-object-array/json-object-array.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PrimitiveDataComponent, PrimitiveDataArrayComponent, JsonObjectComponent, JsonObjectArrayComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'productManagement';
}
