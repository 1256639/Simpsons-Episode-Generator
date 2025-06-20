import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { RandomEpisodeComponent } from './random-episode/random-episode.component';

@Component({
  selector: 'app-root',
  imports: [RandomEpisodeComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'SimpsonsEpisodeGenerator';
}
