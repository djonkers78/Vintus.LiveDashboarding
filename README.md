# Introduction 
A free tool to automatically refresh Power BI Dashboards/apps with intervals of 5, 10, 20, 60 seconds? Without relying on the backend refresh schedule?

A free tool (on top of the Chromium project) to trigger the JavaScript refresh button in the Power BI service. So if you have a report with a direct query connection you can live stream your data with a single Pro license and without detect data changes features. 

It uses a simple windows forms application with a chromium browser inside.

# Getting Started
Compile in Visual Studio and the output folder contains an executable you can use. Select your dashboard or app. Klik the refresh button after setting the interval and it will refresh your reportdata (so not the page itself).

You can run this dashboard  on a monitor without human interaction.

# Contribute
If you find difficulties please report so we can fix.