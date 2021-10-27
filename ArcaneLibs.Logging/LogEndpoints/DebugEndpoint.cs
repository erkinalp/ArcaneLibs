using System.Diagnostics;
using System.Xml;

namespace ArcaneLibs.Logging.LogEndpoints;

public class DebugEndpoint : BaseEndpoint
{
    public override void Write(string text)
    {
        Debug.WriteLine(text);
    }
}