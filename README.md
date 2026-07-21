# Orion Minimal Items

Opt-in first-party plugin loaded via McMaster (`plugin.json` + DLL). Enable `Plugins.Enabled` in `config/server.json`.

- **Manifest id:** `orion:minimal-items`
- **PackageId:** `Orion.Plugins.MinimalItems`
- **Provides:** `orion:minimal-items`, `orion:creative-tab-fillers`

Registers the six Bedrock blocks previously baked into the Orion host, Nature creative entries, and sample fillers for Construction / Equipment / Items:

| Kind | Identifiers |
|------|-------------|
| Blocks | `air`, `structure_void`, `bedrock`, `dirt`, `grass_block`, `barrier` |
| Nature (creative) | `grass_block`, `dirt`, `bedrock` |
| Allowlisted only | `barrier`, `structure_void` |
| Tab fillers | `cobblestone` (1), `wooden_sword` (3), `stick` (4) |

> Supersedes `orion:creative-fillers` / `Orion.Plugins.CreativeFillers`.

## Build

```bash
dotnet build OrionMinimalItems.csproj -c Release
```

Deploy `plugin.json` and `orion.minimal-items.dll` under `plugins/orion:minimal-items/`.

## CI

GitHub Actions smoke-boots the server with this plugin loaded after a Release build.
