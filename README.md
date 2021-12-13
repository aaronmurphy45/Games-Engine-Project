https://www.youtube.com/watch?v=zc8ac_qUXQY

# Project Title

Name: Aaron Murphy

Student Number: C18385706

Class Group: DT211C 

# Description of the project

*Crate Shasher*

For my Games-Engine-Project, I have created Create Smasher, a game in which a Ball, controlled by the play, is thrown into a crate. The crate is smashed by the ball, and the player is rewarded with points. The player can also collect power-ups such as the magic box, which will increase the speed of the ball as the ball enters magic mode. The player can also lose points by crashing into the glass boxes, but wont lose points while in magic mode. 

# Instructions for use
When the user enters a game, they will be met by a menu where they can choose to play the game, view the rules, edit the options or exit the game. If the user presses play 
they will spawn as a ball on a narrow path facing multiple crates. The player must avoid the glass panes and stay on the path, using the left and right arrow on the keyboard, while smashing crates to pick up points. The user can also smash into the magic box in which they enter magic mode. In this magic mode the user will gain super speed and also not lose points when smashing into the glassboxes

# How it works

The game has three different scenes. The main menu scene which uses UI buttons and onclick fucntions to call the Scene Manager to start the game, or set the option page active or rules page active. Once the game is started, the user spwans as a ball on a narrow terrain, surround by spikes created with Perlin Noise. These terrains are generated sequentially as their length is iterated through in 3's, as are there are 3 terrains which interchange, by the the length of each terrain as it reaches a certain position from the next iteration it transforms to its next position in the iteration. All the cubes are generated the exact same way using an iteration of 1 instaed of 3 so they spawn on every terrain as the ball moves forward. However the cubes transform to random position in the next terrain with a min-x of the left hand side of the path and max-x of the left hand side and a random z position in the next terrain which is about to gehnerate infront. 
eg.
```
// i iterates by length of terrain and 
if (sphere.transform.position.z > (256*i)-30) {
                // Randomize x positon of the cube between 5 and 25 
                int min = 5, max = 25;
                int randx = Random.Range(min, max);
                // Randomize z positon of the cube between 256 i and 256 i + 256
                min = 256*i;
                max = 256*i + 256;
                int randz = Random.Range(min, max);
                cube.transform.position = new Vector3(randx, 2, randz);
                
                i++;// i=i+3; for the terrain 
            }
```


# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| Ball.cs | Self written |
| Crate.cs | Self written |
| CubeGeneration.cs | Self written |
| TerrainGeneration.cs | Self written |
| GlassBox.cs | Self written |
| GlassBoxGeneration.cs | Self written |
| MagicBoxGeneration.cs | Self written |
| MovingBox.cs | Self written |
| SetSound.cs | Self written |
| MovingBoxGeneration.cs | Self written |
| MainMenu.cs | Modified From [https://www.youtube.com/watch?v=zc8ac_qUXQY]() |
| PauseMenu.cs | Modified From [https://www.youtube.com/watch?v=JivuXdrIHK0]() |
| Slider | Modified from [https://www.youtube.com/watch?v=JivuXdrIHK0]() |
| PerlinNoise.cs | From Lecture Notes |
| GameOver | Significantly Modified From [https://www.youtube.com/watch?v=JivuXdrIHK0]() |

# References

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
