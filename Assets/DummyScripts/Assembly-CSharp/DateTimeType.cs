/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DateTimeType // TypeDefIndex: 14805
{
	// Fields
	public ushort year; // 0x10
	public ushort month; // 0x12
	public ushort day; // 0x14
	public ushort hour; // 0x16
	public ushort minute; // 0x18
	public ushort second; // 0x1A
	private static Regex _validReg; // 0x00
	private static string _parseReg; // 0x08

	// Constructors
	public DateTimeType() {} // 0x0000000181661B40-0x0000000181661BA0
	static DateTimeType() {} // 0x0000000181661AA0-0x0000000181661B40

	// Methods
	// [XID] // 0x0000000189B0C7D0-0x0000000189B0C7F0
	public static bool IsValid(string val) => default; // 0x0000000181661650-0x0000000181661740
	// [XID] // 0x0000000189B13C50-0x0000000189B13C70
	public bool ParseFrom(string val) => default; // 0x0000000181661740-0x0000000181661AA0
}

