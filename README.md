# Workflow

- Change pixels per unit of each sprite to 24 from 100, rgba to 32, max size to 256, filter from bilinear to point
- Add rigid body to detect collisions, but make kinematic so that it doesn't fall from gravity
- Circle collider makes circle around object for collision
- Use quad to render a texture
- Create material unlit/texture -> drag background texture into "none"
- Change quad to tiling of 4 and change background image to repeat instead of clamp
  - Can then change the offset with a script and make it seem like its going forever
- use trigger for box collider to let us see when collision occurred without physics
- Once you've created your prefab, you can drag it into your folder and then delete it from hierarchy

## How to manage state

- Create Game Manager object with GameManager script attached to it
- Click three dots at top right to turn on debug mode and see private variables changing during game

## Text

- Scale with Screen Size for legacy mode of Canvas
- Change match to 1 for this

## Game Object

- Pull game object from scene into button for more features than just from script
