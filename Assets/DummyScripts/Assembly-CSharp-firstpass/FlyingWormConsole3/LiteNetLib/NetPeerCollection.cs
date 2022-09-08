/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	internal sealed class NetPeerCollection // TypeDefIndex: 6920
	{
		// Fields
		private readonly Dictionary<NetEndPoint, NetPeer> _peersDict; // 0x10
		private readonly NetPeer[] _peersArray; // 0x18
		private int _count; // 0x20
	
		// Properties
		public int Count { /* [XID] */ /* 0x0000000189A123C0-0x0000000189A123E0 */ get => default; } // 0x00000001863CA220-0x00000001863CA2C0 
		public NetPeer this[int index] { /* [XID] */ /* 0x00000001898577B0-0x00000001898577D0 */ get => default; } // 0x00000001863CA2C0-0x00000001863CA3A0 
	
		// Constructors
		public NetPeerCollection() {} // Dummy constructor
		public NetPeerCollection(int maxPeers) {} // 0x00000001863CA160-0x00000001863CA220
	
		// Methods
		// [XID] // 0x0000000189AB9920-0x0000000189AB9940
		public bool TryGetValue(NetEndPoint endPoint, out NetPeer peer) {
			peer = default;
			return default;
		} // 0x00000001863CA070-0x00000001863CA160
		// [XID] // 0x00000001898C7F00-0x00000001898C7F20
		public void Clear() {} // 0x00000001863C9AB0-0x00000001863C9B80
		// [XID] // 0x000000018986D9E0-0x000000018986DA00
		public void Add(NetEndPoint endPoint, NetPeer peer) {} // 0x00000001863C9960-0x00000001863C9AB0
		// [XID] // 0x0000000189874E30-0x0000000189874E50
		public bool ContainsAddress(NetEndPoint endPoint) => default; // 0x00000001863C9B80-0x00000001863C9C50
		// [XID] // 0x000000018987C930-0x000000018987C950
		public NetPeer[] ToArray() => default; // 0x00000001863C9F80-0x00000001863CA070
		// [XID] // 0x00000001898839B0-0x00000001898839D0
		public void RemoveAt(int idx) {} // 0x00000001863C9C50-0x00000001863C9E40
		// [XID] // 0x000000018988B1A0-0x000000018988B1C0
		public void Remove(NetEndPoint endPoint) {} // 0x00000001863C9E40-0x00000001863C9F80
	}
}
