import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-result-list',
  standalone: true,
  imports: [],
  templateUrl: './result-list.component.html',
  styleUrl: './result-list.component.scss'
})

export class ResultsListComponent implements OnInit {
  results: any[] = [];
  currency = 'USD';

  constructor(private router: Router) {
    const nav = this.router.getCurrentNavigation();
    this.results = nav?.extras.state?.['results'] || [];
  }

  ngOnInit() {}
}
