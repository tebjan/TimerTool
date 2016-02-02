TimerTool
=========

![Screenshot](http://vvvv.org/sites/default/files/imagecache/large/TimerTool_0.png)

Little tool to get and set the windows system timer values. It uses the following WinAPI methods to retrieve and set the values:

```
NtQueryTimerResolution
NtSetTimerResolution
TimeBeginPeriod
TimeEndPeriod
```

It can also set 0.5 ms as timer resolution.

Verison 3 minimizes to system tray and can be started with command line arguments "-t peroidVal" and "-minimized".
e.g. put a .bat file into your autostart with the following code:
```
C:\PathToTool\TimerTool.exe -t 0.5 -minimized
```

Download the compiled program here: http://vvvv.org/contribution/windows-system-timer-tool

If you find this useful, [please donate some dev bucks on PayPal](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2DNX2JBBKED8Q), thanks!
