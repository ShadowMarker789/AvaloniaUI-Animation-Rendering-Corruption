# AvaloniaUI-Animation-Rendering-Corruption
AvaloniaUI-Animation-Rendering-Corruption

## Okay but why tho? 

I found very weird and interesting visual corruption issues when running AvaloniaUI on a high frequency monitor while there are low frequency monitors attached. 

This seems to occur most often when animations are playing, as they hit the render clock as fast as possible. 

This is a minimalistic example (ish) of reproducing said problem. I have a 60 Hz non-primary monitor and a 144 Hz primary monitor, and was able to observe the visual corruption. 

The visual corruption lets you see partially through the window in certain spots and may cause issues for people with visual sensory sensitivities. 

## Reproducing

For best reproduction chance, set up a station with a 60 Hz monitor, and a 144 Hz monitor. Then launch the built app twice, one on each monitor and go full-screen on both of them with the F11 key. 

<video src="https://raw.githubusercontent.com/ShadowMarker789/AvaloniaUI-Animation-Rendering-Corruption/main/Animation-Corruption-Camera-Video.mp4"></video>
