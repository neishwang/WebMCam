WebMCam
=======

Capture frames in real-time and save them as WebM.

This is a fork of [michaelmob/WebMCam](https://github.com/michaelmob/WebMCam)
(formerly `thetarkus/WebMCam`), modernised for current Windows: the project now
targets **.NET 10** and is properly DPI-aware, so it behaves correctly on the
scaled displays (125%, 150%, 200%) that the original build could not handle.

Releases / Downloads:
https://github.com/neishwang/WebMCam/releases

Releases are self-contained: **no .NET runtime to install**, and FFmpeg is
bundled next to the executable, so there is nothing to configure on first run.
Unzip and run `WebMCam.exe`.

FFmpeg Website:
https://www.ffmpeg.org/


What this fork changes
----------------------

**Migrated to .NET 10.** The project was on .NET Framework 4.5 with a
`packages.config`; it is now an SDK-style project targeting `net10.0-windows`
with `PackageReference`. This is what makes the app buildable and runnable on a
current machine without installing legacy targeting packs.

**Fixed recording on scaled displays.** The original app was DPI-unaware, so
Windows virtualised its coordinates while `Graphics.CopyFromScreen` returned
real physical pixels. The two disagreed at any scaling other than 100%, and the
recorded video did not match the on-screen preview. The process now runs as
Per-Monitor-V2 DPI aware, which puts every coordinate in the same space.

**Rebuilt the main window layout.** The control panel used hardcoded pixel
positions, which broke as soon as the system font grew with the display scale
(clipped labels, controls overflowing their panel). It is now an auto-sizing
layout measured from the rendered font, verified at 100%, 125%, 150% and 200%.

**Fixed opening links and output files.** `Process.Start(url)` silently relied
on a .NET Framework default (`UseShellExecute = true`) that changed in .NET
Core. Under .NET 10 it threw instead of opening anything, which crashed the app
on the Help/FFmpeg/version links and on the *Open* button after encoding.

**More reliable encode completion.** Detecting "FFmpeg is done" by parsing its
text output proved unreliable, sometimes leaving the *Open* button disabled on a
finished video. The app now also listens for the process exiting.

**Audio capture uses CSCore** (not NAudio, as earlier versions of this README
stated), with a fallback wave format so Headphone Virtualization does not break
capture. The default audio codec is `libvorbis` for broader site compatibility.


Hotkeys
-------

Must run as Administrator for global hotkeys to register.

* `Ctrl+F12` — Start / stop recording
* `Ctrl+F11` — Pause / resume recording
* `Ctrl+F10` — Toggle cursor following

Right-click the form to show the sizing interface.


Building
--------

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

    dotnet build WebMCam.sln -c Release

FFmpeg is not vendored in this repository: the release workflow fetches the
latest stable build at packaging time, so a release is never shipping a stale
copy. It picks the highest release branch FFmpeg publishes rather than a master
nightly, and follows new stable lines on its own.
For a local build, either drop an `ffmpeg.exe` next to the built executable or
point Options at one you already have.

Releases are cut by the `Release` workflow, run manually from the Actions tab.
It reads `VERSION`, refuses to run if that tag already exists or if
`FormMain.Designer.cs` reports a different version, publishes a self-contained
win-x64 build, bundles the latest FFmpeg, and uploads the zip to a new GitHub
release.


Screenshots
-----------

<b>Main Form</b><br/>
![ScreenShot](https://raw.githubusercontent.com/neishwang/WebMCam/master/Preview/FormMain.png)

<b>Select/Remove Frames</b><br/>
![ScreenShot](https://raw.githubusercontent.com/neishwang/WebMCam/master/Preview/FormShowFrames.png)

<b>Options Form</b><br/>
![ScreenShot](https://raw.githubusercontent.com/neishwang/WebMCam/master/Preview/FormOptions.png)


Recording massive resolutions with high framerate may not work out as expected!
Do not open an issue about this!
