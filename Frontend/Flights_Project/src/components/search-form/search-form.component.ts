import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JourneyService } from '../../service/journey.service';

@Component({
  selector: 'app-search-form',
  standalone: true,
  imports: [],
  templateUrl: './search-form.component.html',
  styleUrl: './search-form.component.scss'
})
export class SearchFormComponent {
  searchParams = {
    origin: '',
    destination: '',
    currency: 'USD',
    roundtrip: false,
  };

  constructor(private journeyService: JourneyService, private router: Router) {}

  onSearch() {
    this.journeyService.getJourneys(this.searchParams).subscribe({
      next: (results) => {
        if (results.length) {
          this.router.navigate(['/results'], { state: { results } });
        } else {
          alert('No results found for your search.');
        }
      },
      error: () => alert('An error occurred while fetching journeys.'),
    });
  }
}
