import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Episode {
  id: number;
  seasonNumber: number;
  episodeNumber: number;
  title: string;
  description: string | null;
}

@Injectable({
  providedIn: 'root'
})
export class EpisodeService {

  private apiUrl = 'http://localhost:5167/api/episodes';

  constructor(private http: HttpClient) { }

  getRandomEpisode(): Observable<Episode> {
    let x = this.http.get<Episode>(`${this.apiUrl}/random`);
    console.log(x);
    return x;
  }

}
