/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using WebSocketSharp;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public class WebSocketServiceManager // TypeDefIndex: 10304
	{
		// Fields
		private bool _clean; // 0x10
		private Dictionary<string, WebSocketServiceHost> _hosts; // 0x18
		private Logger _log; // 0x20
		private ServerState _state; // 0x28
		private object _sync; // 0x30
		private TimeSpan _waitTime; // 0x38
	
		// Properties
		public int Count { /* [XID] */ /* 0x00000001899F8EF0-0x00000001899F8F10 */ get => default; } // 0x00000001857E2DD0-0x00000001857E2F20 
		public IEnumerable<WebSocketServiceHost> Hosts { /* [XID] */ /* 0x0000000189755DA0-0x0000000189755DC0 */ get => default; } // 0x00000001857E2F20-0x00000001857E30A0 
		public WebSocketServiceHost this[string path] { /* [XID] */ /* 0x0000000189A07C50-0x0000000189A07C70 */ get => default; } // 0x00000001857E30A0-0x00000001857E3310 
		public bool KeepClean { /* [XID] */ /* 0x0000000189A0F260-0x0000000189A0F280 */ get => default; /* [XID] */ /* 0x0000000189A16880-0x0000000189A168A0 */ set {} } // 0x00000001857E3310-0x00000001857E33C0 0x00000001857E37C0-0x00000001857E3A80
		public IEnumerable<string> Paths { /* [XID] */ /* 0x0000000189A1DD80-0x0000000189A1DDA0 */ get => default; } // 0x00000001857E33C0-0x00000001857E3540 
		[Obsolete] // 0x0000000189B08310-0x0000000189B08340
		public int SessionCount { /* [XID] */ /* 0x0000000189A25430-0x0000000189A25450 */ get => default; } // 0x00000001857E3540-0x00000001857E3720 
		public TimeSpan WaitTime { /* [XID] */ /* 0x0000000189A2C9E0-0x0000000189A2CA00 */ get => default; /* [XID] */ /* 0x0000000189AC1330-0x0000000189AC1350 */ set {} } // 0x00000001857E3720-0x00000001857E37C0 0x00000001857E3A80-0x00000001857E3DD0
	
		// Constructors
		public WebSocketServiceManager() {} // Dummy constructor
		internal WebSocketServiceManager(Logger log) {} // 0x00000001857E1ED0-0x00000001857E1FE0
	
		// Methods
		// [IDTag] // 0x0000000189A3B7D0-0x0000000189A3B810
		// [XID] // 0x0000000189A3B7D0-0x0000000189A3B810
		private void broadcast(Opcode opcode, byte[] data, Action completed) {} // 0x00000001857E2730-0x00000001857E2A70
		// [IDTag] // 0x0000000189A461E0-0x0000000189A46220
		// [XID] // 0x0000000189A461E0-0x0000000189A46220
		private void broadcast(Opcode opcode, Stream stream, Action completed) {} // 0x00000001857E2300-0x00000001857E2730
		// [IDTag] // 0x0000000189A50A20-0x0000000189A50A60
		// [XID] // 0x0000000189A50A20-0x0000000189A50A60
		private void broadcastAsync(Opcode opcode, byte[] data, Action completed) {} // 0x00000001857E2170-0x00000001857E2300
		// [IDTag] // 0x0000000189A5AF00-0x0000000189A5AF40
		// [XID] // 0x0000000189A5AF00-0x0000000189A5AF40
		private void broadcastAsync(Opcode opcode, Stream stream, Action completed) {} // 0x00000001857E1FE0-0x00000001857E2170
		// [XID] // 0x0000000189A65B20-0x0000000189A65B40
		private Dictionary<string, Dictionary<string, bool>> broadping(byte[] frameAsBytes, TimeSpan timeout) => default; // 0x00000001857E2A70-0x00000001857E2CD0
		// [XID] // 0x0000000189A61050-0x0000000189A61070
		private bool canSet(out string message) {
			message = default;
			return default;
		} // 0x00000001857E2CD0-0x00000001857E2DD0
		internal void Add<TBehavior>(string path, Func<TBehavior> creator)
			where TBehavior : WebSocketBehavior {}
		// [XID] // 0x0000000189A74920-0x0000000189A74940
		internal bool InternalTryGetServiceHost(string path, out WebSocketServiceHost host) {
			host = default;
			return default;
		} // 0x00000001857E1250-0x00000001857E13F0
		// [XID] // 0x0000000189A7C3E0-0x0000000189A7C400
		internal void Start() {} // 0x00000001857E17D0-0x00000001857E1A00
		// [XID] // 0x0000000189A83DA0-0x0000000189A83DC0
		internal void Stop(ushort code, string reason) {} // 0x00000001857E1A00-0x00000001857E1C50
		public void AddService<TBehavior>(string path, Action<TBehavior> initializer)
			where TBehavior : WebSocketBehavior, new() {}
		// [IDTag] // 0x0000000189A8B7E0-0x0000000189A8B840
		[Obsolete] // 0x0000000189A8B7E0-0x0000000189A8B840
		// [XID] // 0x0000000189A8B7E0-0x0000000189A8B840
		public void Broadcast(byte[] data) {} // 0x00000001857E0770-0x00000001857E0940
		// [IDTag] // 0x0000000189A990D0-0x0000000189A99140
		[Obsolete] // 0x0000000189A990D0-0x0000000189A99140
		// [XID] // 0x0000000189A990D0-0x0000000189A99140
		public void Broadcast(string data) {} // 0x00000001857E0940-0x00000001857E0BB0
		// [IDTag] // 0x0000000189AA62A0-0x0000000189AA6300
		[Obsolete] // 0x0000000189AA62A0-0x0000000189AA6300
		// [XID] // 0x0000000189AA62A0-0x0000000189AA6300
		public void BroadcastAsync(byte[] data, Action completed) {} // 0x00000001857DFF80-0x00000001857E0170
		// [IDTag] // 0x0000000189AB3AD0-0x0000000189AB3B30
		[Obsolete] // 0x0000000189AB3AD0-0x0000000189AB3B30
		// [XID] // 0x0000000189AB3AD0-0x0000000189AB3B30
		public void BroadcastAsync(string data, Action completed) {} // 0x00000001857E04F0-0x00000001857E0770
		// [IDTag] // 0x0000000189AC1570-0x0000000189AC15D0
		[Obsolete] // 0x0000000189AC1570-0x0000000189AC15D0
		// [XID] // 0x0000000189AC1570-0x0000000189AC15D0
		public void BroadcastAsync(Stream stream, int length, Action completed) {} // 0x00000001857E0170-0x00000001857E04F0
		// [IDTag] // 0x0000000189ACED30-0x0000000189ACED90
		[Obsolete] // 0x0000000189ACED30-0x0000000189ACED90
		// [XID] // 0x0000000189ACED30-0x0000000189ACED90
		public Dictionary<string, Dictionary<string, bool>> Broadping() => default; // 0x00000001857E0E50-0x00000001857E0F90
		// [IDTag] // 0x0000000189ADCE50-0x0000000189ADCEC0
		[Obsolete] // 0x0000000189ADCE50-0x0000000189ADCEC0
		// [XID] // 0x0000000189ADCE50-0x0000000189ADCEC0
		public Dictionary<string, Dictionary<string, bool>> Broadping(string message) => default; // 0x00000001857E0BB0-0x00000001857E0E50
		// [XID] // 0x0000000189681420-0x0000000189681440
		public void Clear() {} // 0x00000001857E0F90-0x00000001857E1250
		// [XID] // 0x00000001899C02D0-0x00000001899C02F0
		public bool RemoveService(string path) => default; // 0x00000001857E13F0-0x00000001857E17D0
		// [XID] // 0x0000000189AF9900-0x0000000189AF9920
		public bool TryGetServiceHost(string path, out WebSocketServiceHost host) {
			host = default;
			return default;
		} // 0x00000001857E1C50-0x00000001857E1ED0
	}
}
