/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class PlayerVars // TypeDefIndex: 21447
{
	// Fields
	private static bool _canFly; // 0x00
	private static bool _timeLock; // 0x01
	private static bool _weatherLock; // 0x02
	private static bool _canTransport; // 0x03
	private static bool _forbidTransmit; // 0x04

	// Properties
	public static bool canFly { /* [XID] */ /* 0x0000000189915900-0x0000000189915920 */ get; } // 0x0000000182444E40-0x0000000182444F50 
	public static bool weatherLocked { /* [XID] */ /* 0x0000000189924BE0-0x0000000189924C00 */ get; } // 0x0000000182444720-0x0000000182444840 
	public static bool timeLocked { /* [XID] */ /* 0x0000000189933580-0x00000001899335A0 */ get; } // 0x0000000182444C50-0x0000000182444D70 
	public static bool canTransport { /* [XID] */ /* 0x0000000189942340-0x0000000189942360 */ get; } // 0x0000000182444F50-0x0000000182445060 
	public static bool forbidTransport { /* [XID] */ /* 0x0000000189951820-0x0000000189951840 */ get; } // 0x0000000182444B40-0x0000000182444C50 
	public static bool MPModeAvailable { /* [XID] */ /* 0x0000000189960460-0x00000001899604A0 */ get; /* [XID] */ /* 0x000000018996ABA0-0x000000018996ABE0 */ set; } // 0x0000000182444840-0x00000001824448D0 0x00000001824445C0-0x0000000182444650
	public static MpSettingType mpSetting { /* [XID] */ /* 0x0000000189975510-0x0000000189975550 */ get; /* [XID] */ /* 0x000000018997FB10-0x000000018997FB50 */ set; } // 0x0000000182445060-0x00000001824450F0 0x00000001824450F0-0x0000000182445180

	// Constructors
	static PlayerVars() {} // 0x0000000182445180-0x0000000182445230

	// Methods
	// [XID] // 0x000000018990E190-0x000000018990E1B0
	public static void Reset() {} // 0x00000001824444C0-0x00000001824445C0
	// [XID] // 0x000000018991D2F0-0x000000018991D310
	public static void UpdateCanFly(bool value) {} // 0x0000000182444D70-0x0000000182444E40
	// [XID] // 0x000000018992C0E0-0x000000018992C100
	public static void LockWeather(bool value) {} // 0x00000001824449A0-0x0000000182444A70
	// [XID] // 0x000000018993B230-0x000000018993B250
	public static void LockTime(bool value) {} // 0x0000000182444A70-0x0000000182444B40
	// [XID] // 0x0000000189949C60-0x0000000189949C80
	public static void UpdateCanTransport(bool value) {} // 0x00000001824448D0-0x00000001824449A0
	// [XID] // 0x0000000189958DB0-0x0000000189958DD0
	public static void UpdateBorbidTransport(bool value) {} // 0x0000000182444650-0x0000000182444720
}

