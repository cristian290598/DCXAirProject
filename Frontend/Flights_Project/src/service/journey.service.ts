import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JourneyService {
  private apiUrl = 'http://localhost:5079/journey/journeys';

  constructor(private http: HttpClient) { }

  getJourneys(params: any): Observable<any[]> {
    const { origin, destination, currency, roundtrip } = params;
    return this.http.get<any[]>(`${this.apiUrl}?origin=${origin}&destination=${destination}&currency=${currency}&roundtrip=${roundtrip}`);
  }
}
