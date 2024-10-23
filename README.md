## CompileApp
CompileApp is a launcher that calls the `pawncc` compiler in order to compile `.pwn` files (filterscripts).

I used this application in a [SA-MP project](https://github.com/MrDave1999/Capture-The-Flag) and for that reason I publish it in this repository to have it saved here.

### Requirements

- Install [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) to be able to run the application.
- Download the [pawncc](https://gta-multiplayer.cz/downloads/samp037_svr_R2-2-1_win32.zip) compiler and then edit the PATH environment variable so that `cmd.exe` can take "pawncc" as a command.
- Unzip the [CompileApp.zip](https://github.com/MrDave1999/CompileApp-FS/releases/download/1.0.1/CompileApp.zip) file to the SA-MP server directory.
- Then run `CompileApp.exe` and you are done. This should compile the server's filterscripts.
