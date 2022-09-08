/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
	public struct ActorSensibleInfo // TypeDefIndex: 21059
	{
		// Fields
		public string alias; // 0x00
		public uint runtimeID; // 0x08
		public bool inSight; // 0x0C
	
		// Methods
		// [XID] // 0x0000000189BCA5D0-0x0000000189BCA5F0
		public static ActorSensibleInfo Create(AISensingKnowledge.SensibleInfo rawInfo) => default; // 0x0000000181A4A370-0x0000000181A4A550
	}
}
