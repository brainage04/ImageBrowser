# ImageBrowser
A standalone C# WinForms application for browsing images.

To get started, download the .exe file from the latest release.

To view images with this application, you can:
1. Open an image with the application by right clicking on an image in File Explorer (`Open with` > `Choose another app` > `Look for another app on this PC`)
2. Open the application, then use the `Open Picture` button to open an image.

When images are opened, all other files in the folder will be scanned to see if they are images with valid extensions and header data, and will be added to a list of image names.
You can then use the Left and Right arrow keys (or the `Previous` and `Next` buttons) to browse through the images in the folder.

You can make basic rotation/flip modifications using the `Rotate`, `Flip (X)` and `Flip (Y)` buttons.
Use the `Reset` button to reset all rotation/flip modifications.

You can send the selected image to the Recycle Bin with the `Delete` button, and copy the image to the clipboard with the `Copy` button.

You can view more advanced information about the image besides size in bytes + width/height
(file path, created/modified/accessed timestamps, pixels per inch and pixel colour format) with the `Info` button,
and you can open the folder the currently selected image belongs to in File Explorer using the `Open Folder` button.

You can zoom from 10% all the way to 100% using the combo box, the -/+ buttons, or the trackbar in the bottom right.

# Planned Features
Add support for zooming above 100% (up to 800%, like the Windows 10 Photos application)
Add support for scrolling up/down/left/right when image has a zoom of above 100%

# Known Issues/Bugs to Fix
pictureBox is not the same size as pictureBoxPanel on startup (fixed upon resizing the window/clicking the `Info` button, but oddly enough calling the methods that do this on startup does not fix this bug)
