Hi
This document describe tricks used in this project.
It is fast made prototype without architecture.

On start remove text ReadMe from Hierarchy/ReadMe

Camera has disabled aspect ratio and canvas is set to be scalable and look as designer wanted.

We can see few scripts like:
- IconBlinking (turn-light)
- Icon_Animation (icon_ani) based on delay and array decide which image should be shown
- Slider_Controller (Petrol Slider) Change slider value by time

Why code?
- Fast changes, parameters fixes available
- Fast working / Fast linear values calculation
- Less memory and cpu consumable than animator (animator need to map animation to time, we are making few simple calculations).

Tricks:
- Icon animation got array - you can put all images (for example 60 in one time) into array (click,shitf+click), but you need to disable Insector view before! Fast changes even big things if you know tricks.
- We can make optimization for images - put it into atlases and drawcalls should decrease.
- [SerializeField] mean private variable which you can saw in editor
- [RequireComponent(typeof(Slider))] - requires from unity to add a component, less chance for null pointer error
- the pointer is inside a game object that serves as a pivot
- Post-proceses stack - make it more glow / fancy

It was hard to simulate a speed, so I decided to animate speed as value in my script which control counter, pointer and background.
Of course I guess that calculating values are better / faster than animation. What can be an issue especially on embedded devices.