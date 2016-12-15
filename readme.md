## BattleCry - A plugin for Hearthstone Deck Tracker

[Download](https://github.com/falconmick/BattleCryPluggin/releases/)

[Youtube video](https://www.youtube.com/watch?v=qjy3qTTFtnw)

Currently in early development. All you have to do is extract the zip into your pluggin folder
Then you go into Options -> Tracker -> Pluggins -> Battle Cry -> Enable

If you want to customise what card triggers what sound go into the AudioFiles directory inside of pluggins and modify cardsoundconfig.xml
to add another, coppy the SoundPlaySetting node and modify:
* FileName: what file (relitive to AudioFiles directory) do you want to play
* CardId: what CardId is it (see ~~[here](https://github.com/falconmick/BattleCryPluggin/blob/master/cardDB.enUS.xml)~~ [hearthstoneapi.com](http://hearthstoneapi.com/cards) for card list)
* Delay: How long to wait until playing audio file (in milliseconds)
* CardSource: 'All' to play it if either player plays it
* CardSource: 'Player' to play it ONLY when you play a card
* CardSource: 'Opponent' to play it ONLY when your opponent plays a card
* 

##### I would love to see what all you guys bind :) Please tweet at me [@falconmick](https://twitter.com/falconmick) your bindings or even better a video showing me your setups!!

## Working

* Play SFX on either your or your oponents play
* Time Delay

## Current BattleCry SFX

* Mysterious Challenger

## Needs to be done

* Add Other events, like on draw, on death, on win/loose game
* Add menu option to add/remove sounds for when you play a card

## Contributing

Feel free to submit a pull request. It's not the tidiest solution, but try to follow my folder setup. Mainly don't put any files in the project root as I like to keep only the point of entry at the root (the IPluggin in this case)

## Hearthstone Deck Tracker
See https://github.com/Epix37/Hearthstone-Deck-Tracker for the project page this plugin was developed against.
