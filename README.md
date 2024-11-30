# Directional Sprite
Directional sprite for Unity (using animator and blend tree method)
![alt text](https://github.com/adskoe96/Directional_Sprite/blob/master/Result.gif)

## How to use
1. Download the script "DirectionalSprite.cs" and put it somewhere in your player (it doesn't matter where, the script doesn't use local object transform).
2. Download the script "SpriteBillboard.cs" and add it to your player (where his SpriteRenderer is located)
3. Specify to the script "DirectionalSprite" parent, which will be rotated, basically it is the main parent of the player, where the CharacterController or Rigidbody is located, also specify to it an animator, which will use variables, for example x and z.
4. Enjoy the result.

## What should Camera.main be used for?
This method was invented by me so that it could be used in multiplayer (The main thing is to synchronize the rotation of your players, leave the rest to the script)
Basically, this method is more suitable for those who don't need to use multiple main cameras.
Also this method works for any type of camera, orbit or other 3-person cameras, and if it's multiplayer, even 1-person players will be able to show you where they turned.

## What should be the coordinates in the Blend Tree?
![alt text](https://raw.githubusercontent.com/adskoe96/Directional_Sprite/master/Example.png)
