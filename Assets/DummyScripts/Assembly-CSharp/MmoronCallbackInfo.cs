/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct MmoronCallbackInfo // TypeDefIndex: 11165
{
	// Properties
	public int cookieCode { /* [XID] */ /* 0x0000000189BDBAB0-0x0000000189BDBAF0 */ get; /* [XID] */ /* 0x00000001895EB550-0x00000001895EB590 */ set; } // 0x0000000183822A90-0x0000000183822C30 0x0000000183822970-0x00000001838229D0
	public ulong gameObjectId { get; /* [XID] */ /* 0x00000001895FD210-0x00000001895FD250 */ set; } // 0x00000001838229D0-0x0000000183822A90 0x00000001838232C0-0x00000001838233A0
	public CallbackAdditionalInfoUnion additionalInfo { /* [XID] */ /* 0x0000000189607880-0x00000001896078C0 */ get; /* [XID] */ /* 0x00000001896122D0-0x0000000189612310 */ set; } // 0x00000001838233A0-0x0000000183823450 0x00000001838231C0-0x00000001838232C0

	// Methods
	// [XID] // 0x000000018961CBC0-0x000000018961CBE0
	public static CallbackAdditionalInfoUnion ReadInEventAdditionalInfo(IntPtr infoPtr) => default; // 0x0000000183822E00-0x0000000183822F90
	// [XID] // 0x0000000189624040-0x0000000189624060
	public static CallbackAdditionalInfoUnion ReadInMusicPlaylistAdditionalInfo(IntPtr infoPtr) => default; // 0x0000000183822F90-0x00000001838231C0
	// [XID] // 0x000000018962B810-0x000000018962B830
	public static CallbackAdditionalInfoUnion ReadInMusicSyncAdditionalInfo(IntPtr infoPtr) => default; // 0x0000000183822C40-0x0000000183822E00
	// [XID] // 0x0000000189633010-0x0000000189633030
	public void Clear() {} // 0x0000000183822C30-0x0000000183822C40
}

