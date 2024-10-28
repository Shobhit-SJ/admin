import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PostComponent } from "../components/post/post.component";
import { ProductsComponent } from "../components/products/products.component";
import { UsersComponent } from "../components/users/users.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PostComponent, ProductsComponent, UsersComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'restAPICalls';
}
