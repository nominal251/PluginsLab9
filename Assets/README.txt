Design Patterns:

Observer- The score system uses the observer design pattern. A score manager observes when
enemies are destroyed, and increments the score counter when this occurs

Object Pooling: When fired bullets "despawn," instead of being fully destroyed they are
disabled and pooled, and reused when the player fires again

Builder: A spawner tells an enemy builder to spawn enemies with specific values. The
builder can take in size, speed, starting direction, and position.