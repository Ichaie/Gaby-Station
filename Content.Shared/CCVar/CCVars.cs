using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

/// <summary>
/// Contains all the CVars used by content.
/// </summary>
/// <remarks>
/// NOTICE FOR FORKS: Put your own CVars in a separate file with a different [CVarDefs] attribute. RT will automatically pick up on it.
/// </remarks>
[CVarDefs]
public sealed partial class CCVars : CVars
{
    // Only debug stuff lives here.

    /// <summary>
    /// A simple toggle to test <c>OptionsVisualizerComponent</c>.
    /// </summary>
    public static readonly CVarDef<bool> DebugOptionVisualizerTest =
        CVarDef.Create("debug.option_visualizer_test", false, CVar.CLIENTONLY);

    /// <summary>
    /// Set to true to disable parallel processing in the pow3r solver.
    /// </summary>
    public static readonly CVarDef<bool> DebugPow3rDisableParallel =
        CVarDef.Create("debug.pow3r_disable_parallel", true, CVar.SERVERONLY);

    #region Light Cycle

    // Tempo inicial
    public static readonly CVarDef<float> InitialTime =
        CVarDef.Create("light_cycle.initial_time", 1000f, desc: "(float)", flag: CVar.REPLICATED);

    // Multiplicador do tempo (isto é, o quanto ele é acelerado em relação ao tempo normal)
    public static readonly CVarDef<float> TimeScale =
        CVarDef.Create("light_cycle.scale", 24f, desc: "(float)", flag: CVar.REPLICATED);

    // Se o ciclo de luz está ativo
    public static readonly CVarDef<bool> CycleEnabled =
        CVarDef.Create("light_cycle.light_cycle", true, desc: "(bool)", flag: CVar.SERVERONLY);

    // Se o ciclo de cor está ativo
    public static readonly CVarDef<bool> ColorEnabled =
        CVarDef.Create("light_cycle.color_cycle", true, desc: "(bool)", flag: CVar.SERVERONLY);

    // Se os anúncios estão ativos
    public static readonly CVarDef<bool> AnnouncementEnabled =
        CVarDef.Create("light_cycle.announcement", true, desc: "(bool)", flag: CVar.SERVERONLY);

    public static readonly CVarDef<int> UpdatePerTick =
        CVarDef.Create("light_cycle.update_per_tick", 3, desc: "(integer)", flag: CVar.SERVERONLY);

    #endregion

    public static readonly CVarDef<bool> MOTDBuletinEnable =
        CVarDef.Create("chat.motd_buletin_enable", true, CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE, "If the MOTD buletin appears in lobby");

}
