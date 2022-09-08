/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public struct Notify // TypeDefIndex: 28683
	{
		// Fields
		public NotifyTypes type; // 0x00
		public object body; // 0x08
		public Packet udpPacket; // 0x10
	
		// Methods
		// [IDTag] // 0x00000001897948F0-0x0000000189794930
		// [XID] // 0x00000001897948F0-0x0000000189794930
		private void InitNotify(NotifyTypes type, object body = null) {} // 0x00000001824B1630-0x00000001824B1660
		// [IDTag] // 0x000000018979FCF0-0x000000018979FD30
		// [XID] // 0x000000018979FCF0-0x000000018979FD30
		private void InitNotify(NotifyTypes type, Packet packet) {} // 0x00000001824B1560-0x00000001824B1630
		// [IDTag] // 0x00000001897AA0C0-0x00000001897AA100
		// [XID] // 0x00000001897AA0C0-0x00000001897AA100
		public static Notify CreateNotify(NotifyTypes type) => default; // 0x00000001824B1360-0x00000001824B1560
		// [IDTag] // 0x00000001897B53F0-0x00000001897B5430
		// [XID] // 0x00000001897B53F0-0x00000001897B5430
		public static Notify CreateNotify(NotifyTypes type, object body) => default; // 0x00000001824B1210-0x00000001824B1360
		// [IDTag] // 0x00000001897C0130-0x00000001897C0170
		// [XID] // 0x00000001897C0130-0x00000001897C0170
		public static Notify CreateNotify(NotifyTypes type, Packet packet) => default; // 0x00000001824B10C0-0x00000001824B1210
	}
}
