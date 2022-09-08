/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using WebSocketSharp;
using WebSocketSharp.Net.WebSockets;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public interface IWebSocketSession // TypeDefIndex: 10296
	{
		// Properties
		WebSocketState ConnectionState { get; }
		WebSocketContext Context { get; }
		string ID { get; }
		string Protocol { get; }
		DateTime StartTime { get; }
	}
}
