# Orion Creative Fillers

Opt-in sample plugin loaded via McMaster (`plugin.json` + DLL). Enable `Plugins.Enabled` in `config/server.json`.

- **Manifest id:** `orion:creative-fillers`
- **Provides:** `orion:creative-tab-fillers`

Registers sample items in Bedrock creative tabs (Construction, Equipment, Items):

- `minecraft:cobblestone`
- `minecraft:wooden_sword`
- `minecraft:stick`

## Build

```bash
dotnet build OrionCreativeFillers.csproj -c Release
```

Deploy `plugin.json` and `orion.creative-fillers.dll` under `plugins/orion:creative-fillers/`.

## CI

GitHub Actions smoke-boots the server with this plugin loaded after a Release build.
