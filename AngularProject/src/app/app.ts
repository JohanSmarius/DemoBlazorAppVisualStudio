import { Component, signal } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('AngularProject');

  constructor(private router: Router) {}

  get isCounterPage(): boolean {
    return this.router.url === '/counter';
  }
}
