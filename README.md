# runasadmin
A simple console application for launching a program or file as administrator. 

This was made specifically to launch Visual Studio as admin from [Rainmeter](https://www.rainmeter.net) where launching shortcuts (even with admin rights set on the shortcut) would still run normally. I'm sure there are other use cases.

compile yourself, or download directly: 
- [runasadmin.exe (x64)](http://bit.ly/runasadminx64) 
- [runasadmin.exe (x86)](http://bit.ly/runasadminx86)



Example usage
- Rainmeter:
  LeftMouseUpAction=["C:\Users\BrotherBrine\Documents\Rainmeter\Skins\Simple\@Resources\runasadmin.exe" "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe"]
- CMD: 
  C:\Users\BrotherBrine\Documents\Rainmeter\Skins\Simple\@Resources\runasadmin.exe notepad.exe  

If you have any issues or other use cases, please share!
