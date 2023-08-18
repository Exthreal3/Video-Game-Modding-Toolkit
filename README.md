# Elden Ring FPS Unlocker and more
A small utility to remove frame rate limit, change FOV (Field of View), add widescreen supprt, alter Game Speed and various game modifications for [Elden Ring](https://en.bandainamcoent.eu/elden-ring/elden-ring) written in C#. More features soon!
Patches games memory while running, does not modify any game files. Works with every game version (legit steam & oh-not-so-legit), should work with all future updates.


## Features
* does not modify any game files, RAM patches only
* works with legit, unmodified steam version as well as with unpacked, not-so-legit versions
* unlock frame rate (remove FPS limit)
* remove forced 60 Hertz (Hz) limit in fullscreen
* increase or decrease field of view (FOV)
* disable camera auto rotate adjustment on movement (intended for mouse users)
* disable centering of camera (cam reset) on lock-on if there is no target
* add support for widescreen monitors
* game modifications
  * global game speed modifier (increase or decrease)
  * disable losing Runes on death

## Preview
[![Elden Ring FPS Unlocker and more](https://user-images.githubusercontent.com/19159295/156041448-ba5e08df-bb5e-4ac7-a8f0-772d8f039f76.png)](#)

## Usage
**Make sure the game is running in offline mode and the AntiCheat (EAC) isn't running.**. 

The graphic setup has to be done only once but as the patcher hot-patches the memory **you have to start the patcher every time you want to use any of its features**.
The game enforces VSYNC and forces 60 Hz in fullscreen even on 144 Hz monitors so we have to override these.

#### **Nvidia**: Use Nvidia Control Panel to set 'Preferred Refreshrate' to 'Highest available' on a Elden Ring Profile, if you aren't using GSYNC/FreeSYNC then set 'Vsync' to 'Off'.
#### **AMD**: Use Radeon Settings to set 'Wait for Vertical Refresh' to 'Enhanced Sync', 'Fast Sync' or 'Always Off' on a Elden Ring profile.

### Follow these steps on Nvidia (see below for GSYNC):
1. Open Nvidia Control Panel
2. Navigate to `Display -> Change resolution`
3. **Make sure your monitor is set to the highest Refresh rate possible:**
4. [![Make sure your monitor is set to the highest Refresh rate possible](https://user-images.githubusercontent.com/19159295/155911492-f6410e73-bcc9-457a-b2da-57f7625c3b68.PNG)](#)
5. Navigate to `3D Settings -> Manage 3D settings -> Program Settings -> Elden Ring`
6. **Set `Preferred refresh rate` to `Highest available`**
7. **Set `Vertical sync` to `Off`**
8. [![Preferred refresh rate to Highest available, VSYNC to Off](https://user-images.githubusercontent.com/19159295/155911494-a50af476-5367-42b1-90f1-106aaa28f368.PNG)](#)
9. Hit apply and close Nvidia Control Panel
10. Start `Elden Ring FPS Unlocker and more` and start the game through the first button
11. Set your new refresh rate limit, tick the checkbox and click `Patch game`

### Follow these steps on AMD:
1. Right click on Desktop -> `Display settings`
2. Scroll down and click `Advanced Display Settings -> Display Adapter Properties`
3. **Switch to `Monitor` tab and make sure your monitor is set to the highest Refresh rate possible:**
4. [![Make sure your monitor is set to the highest Refresh rate possible](https://camo.githubusercontent.com/8ba71a0b512eb68509f7e7506a92a78f3cd47537/68747470733a2f2f692e696d6775722e636f6d2f61774b4862774d2e706e67)](#)
5. Open Radeon Settings
6. Navigate to `Gaming -> Elden Ring` or add it manually if it's missing: `Add -> Browse -> Elden Ring`
7. **Set `Wait for Vertical Refresh` to `Enhanced Sync`, `Fast Sync` or `Always Off`**:
8. [![Wait for Vertical Refresh Enhanced Sync](https://camo.githubusercontent.com/7c00daebb59c7e46c455e30b6caa055c63185dcb/68747470733a2f2f692e696d6775722e636f6d2f456e77595146322e706e67)](#)
9. Apply and close Radeon Settings
10. Start `Elden Ring FPS Unlocker and more` and start the game through the first button
11. Set your new refresh rate limit, tick the checkbox and click `Patch game`

### To play the game with GSYNC do these additional steps (Nvidia):
1. Under Nvidia Control Panel navigate to `3D Settings -> Manage 3D settings -> Program Settings -> Elden Ring`
2. Set `Monitor Technology` to `G-SYNC`
3. You can keep `Vertical sync` on `Use the 3D application setting` now to help remove frame time stutters ([see here](https://www.blurbusters.com/gsync/gsync101-input-lag-tests-and-settings/15/))
4. Make sure that `Preferred refresh rate` is still set to `Highest available`
5. [![GSYNC Settings](https://user-images.githubusercontent.com/19159295/155911496-5fda4bc9-1b8e-4f79-a76d-4a130d65fbe6.PNG)](#)
6. Don't forget to Apply and close Nvidia Control Panel
7. Use a 3rd party frame rate limiter like [RTSS](https://www.guru3d.com/files-details/rtss-rivatuner-statistics-server-download.html) and set a frame rate limit just a few fps below your monitor refresh rate, on a 144Hz Monitor use 138
8. Start `Elden Ring FPS Unlocker and more` and start the game through the first button
9. Set your new refresh rate limit, tick the checkbox and click `Patch game`

### On 'Change FOV by (%)'
Increase or decrease the games Field Of Fiew (FOV) between -95% and +95%.

### On 'Widescreen support'
Adds your monitors **native resolution** to the games video options overwriting the default 1920x1080 resolution. This will allow widescreen monitors to use their full resolution and aspect ratio.

### On 'Disable Steam check'
Normally you don't have to tick this checkbox (except when you are drinking rum while sailing the sea). Ticking this will tell the utility to not start Steam when it tries to launch the game. If your game isn't starting then untick this.

### On 'Disable camera auto rotate on movement':
Will disable the automatic camera rotation adjustments when you are moving. This is mostly intended for mouse users, enabling it on non-native windows controllers might not work correctly.

## On 'Disable camera reset on lock-on':
If you press your target lock-on key and no target is in sight the game will reset the camera position and disable your input while it's doing so. Ticking this checkbox will remove this behaviour of the game.

### On 'Disable Runes loss on death':
Like 'Unseen Aid' in Sekiro you will not lose any Runes upon death with this option enabled.

### On 'Game speed':
Slow down the game to beat a boss like a game journalist or speed it up and become gud. Game speed acts as a global time scale and is used by the game itself to create a dramatic effect in a few cutscenes. All game physics (even opening the menu) will be affected equally: all time-critical windows like dodge and deflect will be proportionally prolonged or shortened while the amount of damage given and taken as well as all other damage physics will be unaltered. A hit from an enemy on 150% game speed will do the exact same damage as on 80%, the deflect window on 50% is exactly twice as long as on 100% and so on. Of course, your character will be affected by the speed too so even though a time window might be different now, the speed which you can react on it is different too. Be aware that the speed modifier can potentially crash the game in certain cutscenes and NPC interactions so use it with caution.

### On 'Open Camera':
Opens [Otis_inf]'s IGCS Camera mod

### On 'Cheat Table':
Opens [Hexinton]'s Cheat Engine table

### On 'ID Spreadsheet':
Opens [Hexinton]'s ID Spreadsheet

### On 'Save Manager':
Opens [avoidthedog]'s Elden Ring Save Manager.

### On 'Exit All':
Runs a .bat file which will kill all tasks opened by the application.


## Troubleshooting:
* Make sure you followed the appropriate steps and didn't skip any
* Try disabling `Fullscreen optimization` for Elden Ring: right mouse click on `eldenring.exe -> Compatibility-> tick 'Disable fullscreen optimizations'`
* If you are using ReShade make sure your preset doesn't enforce 60 Hz, try removing ReShade and see if it solves the problem
* Game isn't starting when you click "Start game"? Untick 'Disable Steam check'
* Try adding the whole game folder and `Elden Ring FPS Unlocker and more` to your antivirus's exclusion list
* Try disabling `Steam Broadcast` (streaming via overlay)
* Try to force disable VSYNC even when you are using GSYNC/FreeSync/FastSync
* Close and disable all screen recording and streaming applications
* Close and disable all overlays
* Close and disable all performance "booster" programs and alike
* Do a clean reinstall of your graphic driver:
  1. Download latest graphics driver for your GPU
  2. Download [DDU](https://www.guru3d.com/files-get/display-driver-uninstaller-download,1.html)
  3. Disconnect internet so windows update won't auto-install minimal driver as soon as you uninstall them
  4. Boot into safe mode
  5. Completely uninstall graphics driver and all of their utilities using DDU
  6. Reboot
  7. Install the latest driver you previously downloaded
  8. Reconnect internet

## Prerequisites
* .NET Framework 4.8
* administrative privileges (for patching)
* 64 bit OS

## Contributing
Feel free to open an issue or create a pull request at any time

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Credits
* huovnn for their contribution to disable the automatic camera adjustments on movement

## Limitations
* the game has forced VSYNC so unlocking the frame rate when your monitor has 60Hz will do nothing. You'll have to disable VSYNC in Nvidia Control Panel or AMD Radeon Settings first, see Usage
* in fullscreen the game forces the monitor to 60 Hz so you'll have to handle this with driver override too, see Usage
* your monitor has to natively support the widescreen resolution otherwise it won't show up correctly
* game speed modification can potentially crash the game in certain cutscenes and NPC interactions, use with caution

## Version History
* v1.0 Initial Release *
- Program stripped by X3L and rebuilt.
- Original Programs belong to:
- https://github.com/FransBouma - IGCSClient
- https://github.com/uberhalit/EldenRingFpsUnlockAndMore - Elden Ring Unlocker [base]
- https://www.nexusmods.com/eldenring/mods/48 - Cheat Engine Table + ID Spreadsheet