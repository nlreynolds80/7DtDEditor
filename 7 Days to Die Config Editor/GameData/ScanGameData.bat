echo off
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Schema" "E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\entityclasses.xml"
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Data" "/c" "%~dp0\Schema\entityclasses.xsd"

"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Schema" "E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\entitygroups.xml"
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Data" "/c" "%~dp0\Schema\entitygroups.xsd"

"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Schema" "E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\spawning.xml"
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Data" "/c" "%~dp0\Schema\spawning.xsd"

"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Schema" "E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\gamestages.xml"
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\xsd" "/outputdir: %~dp0\Data" "/c" "%~dp0\Schema\gamestages.xsd"
pause