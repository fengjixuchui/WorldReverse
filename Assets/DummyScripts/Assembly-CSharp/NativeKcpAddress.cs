/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct NativeKcpAddress // TypeDefIndex: 21734
{
	// Fields
	public AllHostAddress host; // 0x00
	public ushort port; // 0x18

	// Methods
	public static explicit operator NativeKcpAddress(IPEndPoint endPoint) => default; // 0x000000018433D680-0x000000018433D8C0
	public static implicit operator IPEndPoint(NativeKcpAddress address) => default; // 0x000000018433D530-0x000000018433D680
}

