using Solid;

INumberGenerator numberGenerator = new NumberGenerator(1, 100);
IGameSettings gameSettings = new DefaultGameSettings();
IGamePlay gamePlay = new ConsoleGamePlay(numberGenerator, gameSettings);
gamePlay.Play();
