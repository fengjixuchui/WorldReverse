/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Timers;
using IFix.Core;
using WebSocketSharp;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public class WebSocketSessionManager // TypeDefIndex: 10307
	{
		// Fields
		private bool _clean; // 0x10
		private object _forSweep; // 0x18
		private Logger _log; // 0x20
		private Dictionary<string, IWebSocketSession> _sessions; // 0x28
		private ServerState _state; // 0x30
		private bool _sweeping; // 0x34
		private Timer _sweepTimer; // 0x38
		private object _sync; // 0x40
		private TimeSpan _waitTime; // 0x48
	
		// Properties
		internal ServerState State { /* [XID] */ /* 0x0000000189950CD0-0x0000000189950CF0 */ get => default; } // 0x00000001857E8EE0-0x00000001857E8F80 
		public IEnumerable<string> ActiveIDs { /* [XID] */ /* 0x0000000189B4B180-0x0000000189B4B1A0 */ get => default; } // 0x00000001857E8580-0x00000001857E86A0 
		public int Count { /* [XID] */ /* 0x0000000189B52980-0x0000000189B529A0 */ get => default; } // 0x00000001857E86A0-0x00000001857E87F0 
		public IEnumerable<string> IDs { /* [XID] */ /* 0x0000000189B5A3C0-0x0000000189B5A3E0 */ get => default; } // 0x00000001857E87F0-0x00000001857E89D0 
		public IEnumerable<string> InactiveIDs { /* [XID] */ /* 0x0000000189B618A0-0x0000000189B618C0 */ get => default; } // 0x00000001857E89D0-0x00000001857E8AF0 
		public IWebSocketSession this[string id] { /* [XID] */ /* 0x0000000189B69490-0x0000000189B694B0 */ get => default; } // 0x00000001857E8AF0-0x00000001857E8C50 
		public bool KeepClean { /* [XID] */ /* 0x0000000189B70930-0x0000000189B70950 */ get => default; /* [XID] */ /* 0x000000018971B9F0-0x000000018971BA10 */ set {} } // 0x00000001857E8C50-0x00000001857E8D00 0x00000001857E9150-0x00000001857E9300
		public IEnumerable<IWebSocketSession> Sessions { /* [XID] */ /* 0x0000000189798C10-0x0000000189798C30 */ get => default; } // 0x00000001857E8D00-0x00000001857E8EE0 
		public TimeSpan WaitTime { /* [XID] */ /* 0x0000000189B87050-0x0000000189B87070 */ get => default; /* [XID] */ /* 0x0000000189AC8C60-0x0000000189AC8C80 */ set {} } // 0x00000001857E8F80-0x00000001857E9020 0x00000001857E9300-0x00000001857E9540
	
		// Constructors
		public WebSocketSessionManager() {} // Dummy constructor
		internal WebSocketSessionManager(Logger log) {} // 0x00000001857E74E0-0x00000001857E7620
	
		// Methods
		// [IDTag] // 0x0000000189B95660-0x0000000189B956A0
		// [XID] // 0x0000000189B95660-0x0000000189B956A0
		private void broadcast(Opcode opcode, byte[] data, Action completed) {} // 0x00000001857E7940-0x00000001857E7CA0
		// [IDTag] // 0x0000000189B9FBC0-0x0000000189B9FC00
		// [XID] // 0x0000000189B9FBC0-0x0000000189B9FC00
		private void broadcast(Opcode opcode, Stream stream, Action completed) {} // 0x00000001857E7CA0-0x00000001857E8100
		// [IDTag] // 0x0000000189BAA260-0x0000000189BAA2A0
		// [XID] // 0x0000000189BAA260-0x0000000189BAA2A0
		private void broadcastAsync(Opcode opcode, byte[] data, Action completed) {} // 0x00000001857E7620-0x00000001857E77B0
		// [IDTag] // 0x0000000189BB4850-0x0000000189BB4890
		// [XID] // 0x0000000189BB4850-0x0000000189BB4890
		private void broadcastAsync(Opcode opcode, Stream stream, Action completed) {} // 0x00000001857E77B0-0x00000001857E7940
		// [XID] // 0x0000000189BBEA90-0x0000000189BBEAB0
		private Dictionary<string, bool> broadping(byte[] frameAsBytes) => default; // 0x00000001857E8100-0x00000001857E8390
		// [XID] // 0x0000000189BC66D0-0x0000000189BC66F0
		private bool canSet(out string message) {
			message = default;
			return default;
		} // 0x00000001857E8390-0x00000001857E8490
		// [XID] // 0x0000000189BCE3B0-0x0000000189BCE3D0
		private static string createID() => default; // 0x00000001857E8490-0x00000001857E8580
		// [XID] // 0x0000000189BD5650-0x0000000189BD5670
		private void setSweepTimer(double interval) {} // 0x00000001857E9020-0x00000001857E9150
		// [XID] // 0x00000001899FC000-0x00000001899FC020
		private void stop(PayloadData payloadData, bool send) {} // 0x00000001857E9540-0x00000001857E98E0
		// [XID] // 0x000000018975F8B0-0x000000018975F8D0
		private bool tryGetSession(string id, out IWebSocketSession session) {
			session = default;
			return default;
		} // 0x00000001857E98E0-0x00000001857E9A80
		// [XID] // 0x0000000189628740-0x0000000189628760
		internal string Add(IWebSocketSession session) => default; // 0x00000001857E3DD0-0x00000001857E3F60
		// [IDTag] // 0x00000001895F8EC0-0x00000001895F8F00
		// [XID] // 0x00000001895F8EC0-0x00000001895F8F00
		internal void Broadcast(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache) {} // 0x00000001857E4D30-0x00000001857E4F60
		// [IDTag] // 0x00000001896034C0-0x0000000189603500
		// [XID] // 0x00000001896034C0-0x0000000189603500
		internal void Broadcast(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache) {} // 0x00000001857E5130-0x00000001857E5360
		// [IDTag] // 0x000000018960DCD0-0x000000018960DD10
		// [XID] // 0x000000018960DCD0-0x000000018960DD10
		internal Dictionary<string, bool> Broadping(byte[] frameAsBytes, TimeSpan timeout) => default; // 0x00000001857E5360-0x00000001857E5600
		// [XID] // 0x0000000189618050-0x0000000189618070
		internal bool Remove(string id) => default; // 0x00000001857E6140-0x00000001857E62A0
		// [XID] // 0x000000018961FBF0-0x000000018961FC10
		internal void Start() {} // 0x00000001857E6C00-0x00000001857E6D60
		// [XID] // 0x00000001899F49C0-0x00000001899F49E0
		internal void Stop(ushort code, string reason) {} // 0x00000001857E6D60-0x00000001857E6EE0
		// [IDTag] // 0x000000018962E8A0-0x000000018962E8E0
		// [XID] // 0x000000018962E8A0-0x000000018962E8E0
		public void Broadcast(byte[] data) {} // 0x00000001857E4F60-0x00000001857E5130
		// [IDTag] // 0x00000001896393C0-0x0000000189639400
		// [XID] // 0x00000001896393C0-0x0000000189639400
		public void Broadcast(string data) {} // 0x00000001857E4750-0x00000001857E49C0
		// [IDTag] // 0x00000001896439C0-0x0000000189643A00
		// [XID] // 0x00000001896439C0-0x0000000189643A00
		public void Broadcast(Stream stream, int length) {} // 0x00000001857E49C0-0x00000001857E4D30
		// [IDTag] // 0x000000018964E200-0x000000018964E240
		// [XID] // 0x000000018964E200-0x000000018964E240
		public void BroadcastAsync(byte[] data, Action completed) {} // 0x00000001857E3F60-0x00000001857E4150
		// [IDTag] // 0x00000001896588E0-0x0000000189658920
		// [XID] // 0x00000001896588E0-0x0000000189658920
		public void BroadcastAsync(string data, Action completed) {} // 0x00000001857E44D0-0x00000001857E4750
		// [IDTag] // 0x0000000189662D50-0x0000000189662D90
		// [XID] // 0x0000000189662D50-0x0000000189662D90
		public void BroadcastAsync(Stream stream, int length, Action completed) {} // 0x00000001857E4150-0x00000001857E44D0
		// [IDTag] // 0x000000018966D650-0x000000018966D6C0
		[Obsolete] // 0x000000018966D650-0x000000018966D6C0
		// [XID] // 0x000000018966D650-0x000000018966D6C0
		public Dictionary<string, bool> Broadping() => default; // 0x00000001857E5600-0x00000001857E5740
		// [IDTag] // 0x000000018967B320-0x000000018967B380
		[Obsolete] // 0x000000018967B320-0x000000018967B380
		// [XID] // 0x000000018967B320-0x000000018967B380
		public Dictionary<string, bool> Broadping(string message) => default; // 0x00000001857E5740-0x00000001857E59E0
		// [IDTag] // 0x0000000189689000-0x0000000189689040
		// [XID] // 0x0000000189689000-0x0000000189689040
		public void CloseSession(string id) {} // 0x00000001857E5D00-0x00000001857E5E60
		// [IDTag] // 0x0000000189693AF0-0x0000000189693B30
		// [XID] // 0x0000000189693AF0-0x0000000189693B30
		public void CloseSession(string id, ushort code, string reason) {} // 0x00000001857E5B70-0x00000001857E5D00
		// [IDTag] // 0x000000018969E1C0-0x000000018969E200
		// [XID] // 0x000000018969E1C0-0x000000018969E200
		public void CloseSession(string id, CloseStatusCode code, string reason) {} // 0x00000001857E59E0-0x00000001857E5B70
		// [IDTag] // 0x00000001896A82B0-0x00000001896A82F0
		// [XID] // 0x00000001896A82B0-0x00000001896A82F0
		public bool PingTo(string id) => default; // 0x00000001857E5E60-0x00000001857E5FC0
		// [IDTag] // 0x00000001896B22A0-0x00000001896B22E0
		// [XID] // 0x00000001896B22A0-0x00000001896B22E0
		public bool PingTo(string message, string id) => default; // 0x00000001857E5FC0-0x00000001857E6140
		// [IDTag] // 0x00000001896BCA40-0x00000001896BCA80
		// [XID] // 0x00000001896BCA40-0x00000001896BCA80
		public void SendTo(byte[] data, string id) {} // 0x00000001857E68F0-0x00000001857E6A70
		// [IDTag] // 0x00000001896C7150-0x00000001896C7190
		// [XID] // 0x00000001896C7150-0x00000001896C7190
		public void SendTo(string data, string id) {} // 0x00000001857E6770-0x00000001857E68F0
		// [IDTag] // 0x00000001896D1440-0x00000001896D1480
		// [XID] // 0x00000001896D1440-0x00000001896D1480
		public void SendTo(Stream stream, int length, string id) {} // 0x00000001857E6A70-0x00000001857E6C00
		// [IDTag] // 0x00000001896DBA60-0x00000001896DBAA0
		// [XID] // 0x00000001896DBA60-0x00000001896DBAA0
		public void SendToAsync(byte[] data, string id, Action<bool> completed) {} // 0x00000001857E65E0-0x00000001857E6770
		// [IDTag] // 0x00000001896E5E40-0x00000001896E5E80
		// [XID] // 0x00000001896E5E40-0x00000001896E5E80
		public void SendToAsync(string data, string id, Action<bool> completed) {} // 0x00000001857E62A0-0x00000001857E6430
		// [IDTag] // 0x00000001896F01F0-0x00000001896F0230
		// [XID] // 0x00000001896F01F0-0x00000001896F0230
		public void SendToAsync(Stream stream, int length, string id, Action<bool> completed) {} // 0x00000001857E6430-0x00000001857E65E0
		// [XID] // 0x0000000189851930-0x0000000189851950
		public void Sweep() {} // 0x00000001857E6EE0-0x00000001857E7320
		// [XID] // 0x0000000189702300-0x0000000189702320
		public bool TryGetSession(string id, out IWebSocketSession session) {
			session = default;
			return default;
		} // 0x00000001857E7320-0x00000001857E7480
	}
}
