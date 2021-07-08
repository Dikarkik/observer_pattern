# observer_pattern

Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

In this example we want decoupled code for a Player that Jumps, so we made a component for every aspect of the 'Jump' feature: PlayerAnimation, PlayerPhysics and AudioManager. To keep this simple, those components just have an method called 'Jump' to print a message on the console. To Invoke all those methods when the user pess the Space bar key we need to achieve two things:

1. Subscribe those methods to an event, in this case we have the 'OnPlayerJump' event, wish is a member of the component EventManager.

![Diagram subscribe](https://github.com/karodev3/observer_pattern/blob/assets/Diagram-subscribe.jpg?raw=true)


2. Invoke that event when the Space bar key is pressed, we do this since the component InputManager calling a method inside the EventManager which Invoke the 'OnPlayerJump' event.

![Diagram invoke](https://github.com/karodev3/observer_pattern/blob/assets/Diagram-invoke.jpg?raw=true)

## Documentation:
- Observer pattern: https://refactoring.guru/design-patterns/observer
- Delegates, events, actions: https://answers.unity.com/questions/1739085/when-to-decide-between-using-a-delegate-event-or-a.html
- Events: https://docs.microsoft.com/en-us/dotnet/standard/events/
- Actions: https://docs.microsoft.com/en-us/dotnet/api/system.action?view=netcore-3.1
- Delegates: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
- Events in Unity: https://youtu.be/OuZrhykVytg

Special thanks to [@AndersenCastaneda](https://github.com/AndersenCastaneda) for introduced me to the topic.

## About me:
Unity Developer. Passionate about: virtual reality, casual games, multiplayer.

<a href="https://www.linkedin.com/in/dianacarolinaquinterocaro/">
	<img src="https://github.com/karodev3/observer_pattern/blob/assets/linkedIn-icon.png?raw=true" width="40"/>
</a>

<a href="https://twitter.com/KaroDev3">
	<img src="https://github.com/karodev3/observer_pattern/blob/assets/twitter-icon.png?raw=true" width="40"/>
</a>

<a href="https://www.twitch.tv/karodev">
	<img src="https://github.com/karodev3/observer_pattern/blob/assets/twitch-icon.png?raw=true" width="40"/>
</a>