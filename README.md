## CompileApp
CompileApp is a launcher that calls the `pawncc` compiler in order to compile `.pwn` files (filterscripts).

I used this application in a [SA-MP](https://www.sa-mp.com/) project and for that reason I publish it in this repository to have it saved here.

### Requirements

- Install .NET Core 3.1 to be able to run the application.
- Download the [pawncc](http://files.sa-mp.com/samp037_svr_R2-1-1_win32.zip) compiler and then edit the PATH environment variable so that `cmd.exe` can take "pawncc" as a command.
- Unzip the [CompileApp.zip](https://github.com/MrDave1999/CompileApp-FS/releases/download/1.0.0/CompileApp.zip) file to the SA-MP server directory.
- Then run `CompileApp.exe` and you are done. This should compile the server's filterscripts.