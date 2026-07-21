using Orion.PluginContracts;
using Orion.PluginContracts.Registry;

namespace OrionMinimalItems;

/// <summary>
/// Minimal Bedrock content extracted from the Orion host: six blocks, Nature creative
/// entries, non-creative placeables, plus sample Construction / Equipment / Items fillers.
/// </summary>
public sealed class OrionMinimalItemsPlugin : IOrionPlugin
{
    // Bedrock default state hashes (match Orion.Protocol.Registry.BedrockBlockStates).
    private const int AirHash = -604749536;
    private const int BedrockHash = -173245189;
    private const int DirtHash = -2108756090;
    private const int GrassBlockHash = -567203660;
    private const int BarrierHash = 951810905;
    private const int StructureVoidHash = 1150271535;

    public string Id => "orion:minimal-items";

    public Version Version { get; } = new(1, 0, 0);

    public void Load(IPluginLoadContext context)
    {
        IContentRegistries registries = context.Registries;

        registries.Blocks.Register(new BlockRegistration(
            "minecraft:air", AirHash, Solid: false, Air: true, Hardness: 0f));
        registries.Blocks.Register(new BlockRegistration(
            "minecraft:structure_void", StructureVoidHash, Solid: false, Hardness: 0f));
        registries.Blocks.Register(new BlockRegistration(
            "minecraft:bedrock", BedrockHash, Hardness: -1f));
        registries.Blocks.Register(new BlockRegistration(
            "minecraft:dirt", DirtHash, Hardness: 0.5f));
        registries.Blocks.Register(new BlockRegistration(
            "minecraft:grass_block", GrassBlockHash, Hardness: 0.6f));
        registries.Blocks.Register(new BlockRegistration(
            "minecraft:barrier", BarrierHash, Solid: false, Hardness: -1f));

        // Nature (category 2) — formerly core orion/items.json creative entries.
        registries.CreativeTabs.AddEntry(Id, 2, "minecraft:grass_block");
        registries.CreativeTabs.AddEntry(Id, 2, "minecraft:dirt");
        registries.CreativeTabs.AddEntry(Id, 2, "minecraft:bedrock");

        // Placeable but not creative (former creative: false in orion/items.json).
        registries.Items.Register(new ItemRegistration("minecraft:barrier", Creative: false));
        registries.Items.Register(new ItemRegistration("minecraft:structure_void", Creative: false));

        // Sample fillers so Construction / Equipment / Items render on Bedrock.
        registries.CreativeTabs.AddEntry(Id, 1, "minecraft:cobblestone");
        registries.CreativeTabs.AddEntry(Id, 3, "minecraft:wooden_sword");
        registries.CreativeTabs.AddEntry(Id, 4, "minecraft:stick");
    }

    public void OnEnable(IPluginContext context) => _ = context;

    public void OnWorldInitialize(IWorldInitContext context) => _ = context;

    public void OnDisable(IPluginContext context) => _ = context;
}
