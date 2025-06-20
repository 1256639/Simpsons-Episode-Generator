import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RandomEpisodeComponent } from './random-episode.component';

describe('RandomEpisodeComponent', () => {
  let component: RandomEpisodeComponent;
  let fixture: ComponentFixture<RandomEpisodeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RandomEpisodeComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RandomEpisodeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
