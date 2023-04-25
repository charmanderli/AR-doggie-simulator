# AR-doggie-simulator
Mixed reality course project

![IMG_7229 - Copy](https://user-images.githubusercontent.com/54521837/234148932-973f225a-4eb5-4ea8-b752-0b77d285a1e3.JPG)  

Project Hu-sky (for when my doggie did not spawn at the correct place)  

## AR Doggie Simulator Demo

https://youtu.be/gYZASOOnZBM  

AR Doggie Simulator is an augmented reality mobile application that lets you play with a virtual dog in your real environment, to simulate the dog owner tasks. 
Using AR technology, the app superimposes a 3D dog model onto the user's camera feed, creating a realistic and fun experience.

## Getting Started
To get started with AR Doggie Simulator, you'll need an Android device that supports ARCore. You can download the Google play services for AR app 
from the Google Play Store. You can download the apk. in Builds folder to install or open the project in uniy and build and run. 

## How to Use
Once you've installed the app, simply open it, hold your phone at a normal angle and height. The app will detect the surface and place a virtual dog on it.
You can go through the opening animation and click on the tasks, enter the interactive task scenes.

## Scenes and Technologies Used
Unity + C# scripts

### Text dialogue scenes: 
beginning scene + vet scene, dialogue manager with scripts (Unity animation) for a bit of story context and pet knowledge, used partical system for the rain effect, with rain sound affect audio

### Simple AR interactive scenes: 
walk scene + feed (touch and drag the food to the doggie) scene, plane detection with Unity ARPlaneManager and spawn doggie

### AR mini game scenes: 
shop scene (adapted from scary cube game, items will "chase" you) + fetch scene (swipe and shoot, rigidbody) 

### UI scenes: 
Task lists of day and week, designed by myself in Figma, implemented with Unity UI toolkit (UXML, USS and C#)

### Doggie: 
FBX models downloaded with animations from PolyPizza, controlled with Unity animator, different scenes with different animations

### Optimazation: 
baked light map for a smaller file and easier load

## Credit
Sketchfab!Poly pizza!
