/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MobileInfoUtil // TypeDefIndex: 31623
{
	// Fields
	private static readonly string[] ADDRESS_LIST; // 0x00

	// Constructors
	public MobileInfoUtil() {} // 0x0000000181946980-0x00000001819469E0
	static MobileInfoUtil() {} // 0x00000001819467A0-0x0000000181946980

	// Methods
	private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes); // 0x0000000181946370-0x00000001819464E0
	// [XID] // 0x0000000189640C60-0x0000000189640C80
	public static bool CanReachNetwork() => default; // 0x0000000181946230-0x00000001819462D0
	// [XID] // 0x00000001896485B0-0x00000001896485D0
	public static bool IsWifi() => default; // 0x0000000181945DC0-0x0000000181945E60
	// [XID] // 0x000000018964FC40-0x000000018964FC60
	public static bool IsCarrierNetwork() => default; // 0x0000000181945E60-0x0000000181945F00
	// [XID] // 0x0000000189657500-0x0000000189657520
	private static bool CanPing(string url) => default; // 0x0000000181945F00-0x00000001819460F0
	// [XID] // 0x000000018965EBC0-0x000000018965EBE0
	public static bool CanRealReachNetwork() => default; // 0x0000000181945C70-0x0000000181945DC0
	// [XID] // 0x0000000189666220-0x0000000189666240
	public static int GetWifiStrength() => default; // 0x00000001819462D0-0x0000000181946370
	// [XID] // 0x000000018966D9E0-0x000000018966DA00
	public static long GetRemainingSpace() => default; // 0x0000000181946680-0x00000001819467A0
	// [XID] // 0x0000000189675800-0x0000000189675820
	public static long GetDiskFreeSpace() => default; // 0x00000001819464E0-0x0000000181946680
	// [XID] // 0x000000018967D0D0-0x000000018967D0F0
	public static long GetHardDiskFreeSpace(string str_HardDiskName) => default; // 0x00000001819460F0-0x0000000181946230
}

