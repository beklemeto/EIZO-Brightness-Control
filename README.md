A small *private* project showing how to control your EIZO monitor parameters from C# code.

How to use:
1) Download & Install EIZO Screen In-Style (https://www.eizoglobal.com/products/flexscan/screen-instyle/). Tested with version 1.1.13, but newer version shouldn't be a problem.
2) From the install location copy 7! dll files: libcolour.dll, libemc.dll, libeyesys.dll, libHIDmctrl.dll, libmctrl.dll, libminfo2.dll and libmptag.dll.
3) Compile the project and put the dlls into the output folder.
4) Done! You can now extend the sample program by writing your own control code. After that you don't need Screen In-Style installed anymore...

This private sample project exhibits the API to access libemc.dll which provides a lot of control functions for color channels, brightness, contrast, gamma, satturation, ecoview etc.
It seems that libemc.dll needs all the other files to work, so you'll have to move all of them together.

I wanted to share this approach to all unhappy with the standard EIZO software wishing to write their own utility that suits them better. It should work for all FlexScan models.
