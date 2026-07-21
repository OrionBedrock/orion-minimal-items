# Orion Minimal Items

Opt-in sample plugin loaded via McMaster (`plugin.json` + DLL). Enable `Plugins.Enabled` in `config/server.json`.

- **Manifest id:** `orion:minimal-items`
- **PackageId:** `Orion.Plugins.MinimalItems`
- **Provides:** `orion:creative-tab-fillers`

Registers sample items in Bedrock creative tabs (Construction, Equipment, Items):

- `minecraft:cobblestone`
- `minecraft:wooden_sword`
- `minecraft:stick`

> Renamed from `orion:creative-fillers` / `Orion.Plugins.CreativeFillers`.

## Build

```bash
dotnet build OrionMinimalItems.csproj -c Release
```

Deploy `plugin.json` and `orion.minimal-items.dll` under `plugins/orion:minimal-items/`.

## CI

GitHub Actions smoke-boots the server with this plugin loaded after a Release build.
