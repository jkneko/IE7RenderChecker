# IE7RenderChecker

<a href="https://flatt.tech/oss/gmo/trampoline" target="_blank"><img src="https://flatt.tech/assets/images/badges/gmo-oss.svg" height="24px"/></a>

IE7RenderChecker is a small Windows Forms utility for checking how a web page renders under different Internet Explorer document modes. It wraps the built-in `WebBrowser` control and lets you switch the IE emulation mode per app.

## Features

- Select IE document modes (IE7 through IE11) from a dropdown.
- Simple navigation controls (back, forward, reload, go).
- Optional auto-reload with a configurable interval.
- Persists the last URL and reload interval in the current user registry.

## Requirements

- Windows
- .NET Framework 4.7.1
- Visual Studio (or Build Tools) with .NET Framework support to build from source

## Build

From a Developer Command Prompt:

```bat
msbuild IE7RenderChecker.sln /p:Configuration=Release
```

The executable is generated at `IE7RenderChecker\bin\Release\IE7RenderChecker.exe`.

## Usage

1. Launch `IE7RenderChecker.exe`.
2. Enter a URL and press Enter or click **Go**.
3. Choose the desired IE mode from the dropdown.
4. When prompted, restart the app to apply the new mode.
5. (Optional) Enable **Auto reload** and set the interval in seconds.

## How the IE mode is applied

The app sets the IE emulation mode by writing to the current user registry under:

- `HKCU\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION`

The selected value is stored using the executable name as the key. The app also stores UI settings under:

- `HKCU\Software\Kanetech\IE7RenderChecker`

## Installer (optional)

`installer.nsi` is an NSIS script that builds an installer using the release build output. It is not required to run the app during development.

## License

See `LICENSE`.
