import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EpisodeService, Episode } from '../services/episode.service';

@Component({
  selector: 'app-random-episode',
  imports: [CommonModule,],
  templateUrl: './random-episode.component.html',
  styleUrl: './random-episode.component.css'
})
export class RandomEpisodeComponent {

  episode: Episode | null = null;
  loading = false;
  error = '';

  constructor(private episodeService: EpisodeService) { }

  getRandomEpisode() {
    this.loading = true;
    this.error = '';
    this.episodeService.getRandomEpisode().subscribe({
      next: (ep) => {
        this.episode = ep;
        this.loading = false;
      },
      error: () => {
        this.error = "Error: Impossible to find an episode.";
        this.loading = false;
      }
    });
  }

}
