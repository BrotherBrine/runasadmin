# runasadmin
A simple console application for launching a program or file as administrator. 

This was made specifically to launch Visual Studio as admin from [Rainmeter](https://www.rainmeter.net) where launching shortcuts (even with admin rights set on the shortcut) would still run normally. I'm sure there are other use cases.

Example usage

-Rainmeter:
  LeftMouseUpAction=["C:\Users\BrotherBrine\Documents\Rainmeter\Skins\Simple\@Resources\runasadmin.exe" "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe"]
- CMD: 
  C:\Users\BrotherBrine\Documents\Rainmeter\Skins\Simple\@Resources\runasadmin.exe notepad.exe  
