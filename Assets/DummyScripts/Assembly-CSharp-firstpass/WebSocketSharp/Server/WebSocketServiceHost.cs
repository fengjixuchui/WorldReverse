/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using WebSocketSharp;
using WebSocketSharp.Net.WebSockets;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public abstract class WebSocketServiceHost // TypeDefIndex: 10301
	{
		// Fields
		private Logger _log; // 0x10
		private string _path; // 0x18
		private WebSocketSessionManager _sessions; // 0x20
	
		// Properties
		internal ServerState State { /* [XID] */ /* 0x00000001899976D0-0x00000001899976F0 */ get; } // 0x00000001857DFC90-0x00000001857DFD40 
		protected Logger Log { /* [XID] */ /* 0x00000001896F0170-0x00000001896F0190 */ get; } // 0x00000001857DFAB0-0x00000001857DFB50 
		public bool KeepClean { /* [XID] */ /* 0x00000001899EDA00-0x00000001899EDA20 */ get; /* [XID] */ /* 0x0000000189A7F040-0x0000000189A7F060 */ set; } // 0x00000001857DFA00-0x00000001857DFAB0 0x00000001857DFDF0-0x00000001857DFEC0
		public string Path { /* [XID] */ /* 0x0000000189704B70-0x0000000189704B90 */ get; } // 0x00000001857DFB50-0x00000001857DFBF0 
		public WebSocketSessionManager Sessions { /* [XID] */ /* 0x00000001899BD3E0-0x00000001899BD400 */ get; } // 0x00000001857DFBF0-0x00000001857DFC90 
		public abstract System.Type BehaviorType { get; }
		public TimeSpan WaitTime { /* [XID] */ /* 0x00000001899C4E10-0x00000001899C4E30 */ get; /* [XID] */ /* 0x00000001899CC3B0-0x00000001899CC3D0 */ set; } // 0x00000001857DFD40-0x00000001857DFDF0 0x00000001857DFEC0-0x00000001857DFF80
	
		// Constructors
		protected WebSocketServiceHost() {} // Dummy constructor
		protected WebSocketServiceHost(string path, Logger log) {} // 0x00000001857DF950-0x00000001857DFA00
	
		// Methods
		// [XID] // 0x00000001899D3B00-0x00000001899D3B20
		internal void Start() {} // 0x00000001857DF7C0-0x00000001857DF870
		// [XID] // 0x0000000189BC9810-0x0000000189BC9830
		internal void StartSession(WebSocketContext context) {} // 0x00000001857DF6E0-0x00000001857DF7C0
		// [XID] // 0x00000001899ECC80-0x00000001899ECCA0
		internal void Stop(ushort code, string reason) {} // 0x00000001857DF870-0x00000001857DF950
		protected abstract WebSocketBehavior CreateSession();
	}
}
