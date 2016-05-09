# Elite:Dangerous Screenshot Service

A Windows service that (along with a dedicated taskbar UI) automatically converts those disk-chewing `.BMP` screenshot files into either `.JPG` or `.PNG` formats.

## Installation

Download either a pre-built `setup.exe` file or, if you're so inclined, the source code from [GitHub](https://github.com/ablewhite/edscreenshotutility).  The service was created with [MS Visual Studio 2013](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx), using .NET 4.5.

### Automatic install

Run `setup.exe` and follow the instructions. You'll be prompted to start the service after the install finishes; if you'd prefer to run this at a later time, browse to `Start` > `All programs` > `CMDR Lenslok` > `Elite Dangerous Screenshot Utility` and run the EXE found there.

> Obviously this will be in a different location if you changed the default install location during installation.

### Manual install
Copy both `EDScreenshotService.exe` and `EDScreenshotUI.exe` into a new folder, then run `EDScreenshotUI.exe`.

> **Please note:** the screenshot utility runs as a taskbar application, so this will display as a white E:D icon next to the clock (Windows may decide to auto-hide this; if so, click the arrow next to the visible icons to show the list of running taskbar apps).  To view settings, double-click the taskbar icon.

### Installing the service
You should now have access to the screenshot service UI (runs as a taskbar icon next to the clock). Before we can start converting bitmaps, we need to ensure a dedicated Windows service is up and running (this is what watches for the bitmaps):

- Ensure the **Screenshot folder** is set to the correct location. The app has a stab at setting this atuomatically, but use **View** to check it looks right or **Browse** to switch to a different folder.
> **Note** Only bitmaps created within this folder will be processed.

- Choose your preferred method of what to do with the source `.BMP` file once it's been converted to `.JPG` or `.PNG` (always delete, only delete if it was a 4K screenshot, or never delete)

- Select your preferred image format (`.JPG` or `.PNG`)

- When converting to `.JPG` format, the compression / quality tradeoff can be set by tweaking the **JPG quality** slider.   

- Click **Install service**. After a brief pause, you should see a "Service running status" of **Running**. Screenshots generated at this point should now be converted in line with your preferences :) 

- Switching bitmap removal options and / or your preferred image format should be honoured immediately while the service is running.
> **Please note:** changes made to the screenshot folder and / or JPG quality options will only take affect the next time the service is installed (i.e. click **Uninstall service** then **Install service** again).    

## Uninstalling

To remove the service:

- Run the app located under `Start` > `All programs` > `CMDR Lenslok` > `Elite Dangerous Screenshot Utility` (or `EDScreenshotUI.exe` if installed manually)
- Click **Uninstall service**.  After a brief pause, the service installation status should read **Not installed**
- Close the Elite Dangerous Screenshot Utility window
- Navigate to **Add and remove programs** within the Windows **Control panel**
> On Windows 7 at least, bringing up the Start menu (`Ctrl` + `Esc`) and typing `remove programs` in the search box should show a shortcut to the **Add and remove programs** control panel pane  

- Look for **Elite Dangerous Screenshot Service** and right-click once on the row
- Left-click **Uninstall** from the menu that appears, then follow the on-screen instructions

## Contributing

This has been a fun little side project to work on, and I've already got a few ideas for improvements - however, the day job and chasing a mini CMDR around the house tends to eat into my time somewhat.  If you'd like to have a play with the source code and use it for your own projects and / or suggest improvements, jump right in! 

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

Right on, CMDR! o7

## History

v1.0 - Coded late 2015, released 9th May 2016
v1.1 - user settings now editable in non-admin environments (9th May 2016)

## Credits

Icons by [Marc Grützmacher](https://thenounproject.com/whoismarc/) via the fabulous [Noun Project](https://thenounproject.com/).

## Problems?

Feel free to give me a nudge / drop me a line in-game (I'm on as CMDR Lenslok).

## License

Code released under the MIT license.
> TL;DR - you're free to do what you want with it, as long as I'm not held liable :)
