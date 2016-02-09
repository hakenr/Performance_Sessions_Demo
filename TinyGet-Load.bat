echo off
cls
echo Performance counters
echo  ASP.NET Applications \ Requests Succeeded
echo  ASP.NET Applications \ Requests/s
pause
echo on
tinyget -srv:localhost -port:1282 -uri:/ -loop:4000 -threads:10