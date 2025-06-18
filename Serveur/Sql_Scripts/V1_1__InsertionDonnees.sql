-- Ajouter des données dans nos tables 

USE SimpsonsEpisodeGenerator;
GO

INSERT INTO Episodes (SeasonNumber, EpisodeNumber, Title, Description) VALUES
-- Season 1
(1, 1, 'Simpsons Roasting on an Open Fire', 'The Simpsons family prepares for Christmas.'),
(1, 2, 'Bart the Genius', 'Bart swaps IQ tests with Martin Prince.'),
(1, 3, 'Homer''s Odyssey', 'Homer becomes a safety advocate after being fired.'),
(1, 4, 'There''s No Disgrace Like Home', 'Homer tries to improve his family''s behavior.'),
(1, 5, 'Bart the General', 'Bart leads a rebellion against Nelson Muntz.'),

-- Season 2
(2, 1, 'Bart Gets an F', 'Bart struggles to pass a history test.'),
(2, 2, 'Simpson and Delilah', 'Homer gets a promotion with the help of a miracle hair tonic.'),
(2, 3, 'Treehouse of Horror', 'The first Halloween special with three spooky stories.'),
(2, 4, 'Two Cars in Every Garage and Three Eyes on Every Fish', 'Homer runs for office after a three-eyed fish is discovered.'),
(2, 5, 'Dancin'' Homer', 'Homer becomes a baseball mascot.');