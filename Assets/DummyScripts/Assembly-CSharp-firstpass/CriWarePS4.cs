/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriWarePS4 // TypeDefIndex: 7216
{
	// Fields
	public const int systemUserID = 255; // Metadata: 0x00ADE707
	public const int bgmRackID = 1; // Metadata: 0x00ADE70B

	// Nested types
	public enum AudioPortType // TypeDefIndex: 7217
	{
		Main = 0,
		Bgm = 1,
		Voice = 2,
		Personal = 3,
		PadSpeaker = 4,
		Aux = 127
	}

	public enum AudioPortAttribute // TypeDefIndex: 7218
	{
		Normal = 0,
		Restricted = 65536,
		MixToMain = 131072
	}

	// Constructors
	public CriWarePS4() {} // 0x0000000186446C40-0x0000000186446CA0

	// Methods
	public static bool IsBgmOverridden() => default; // 0x0000000186446BF0-0x0000000186446C40
}

