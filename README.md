# PICO4UnityGettingStarted
PICO 4 Development with Unity and XRI

## Requirements
* Unity 2021.3.8f1 or greater
* [PICO Unity Integration SDK](https://developer-global.pico-interactive.com/sdk?deviceId=1&platformId=1&itemId=12)
* [PICO Preview Tool - Optional](https://developer-global.pico-interactive.com/sdk?deviceId=1&platformId=1&itemId=17)
* Unity XRI 2.3 - Add the following line to manifest.json
  * ```"com.unity.xr.interaction.toolkit": "2.3.0-pre.1"```
  
## Important
To avoid having the entire PICO Unity Integration SDK as part of this project you will need to download it and replace the following manifest.json line with your own path:
```"com.unity.xr.picoxr": "file:C:/Users/Dilmer/Code/SDKs/PICO Unity Integration SDK v212",```
