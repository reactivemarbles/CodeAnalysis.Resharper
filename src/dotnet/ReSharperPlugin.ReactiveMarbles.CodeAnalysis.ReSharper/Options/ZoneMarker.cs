using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.Application.UI.Options.OptionPages;

namespace ReSharperPlugin.ReactiveMarbles.CodeAnalysis.ReSharper.Options
{
    [ZoneMarker]
    public class ZoneMarker : IRequire<IToolsOptionsPageImplZone>
    {
    }
}