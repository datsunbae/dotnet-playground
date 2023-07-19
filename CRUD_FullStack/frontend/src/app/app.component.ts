import { Component } from '@angular/core';
import { Router } from '@angular/router';
import * as $ from 'jquery';
import 'bootstrap';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  activeItem: string = '';
  constructor(private router: Router) {}
  ngOnInit() {}

  setActiveItem(item: string) {
    this.activeItem = item;
  }
}
