using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Enables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
