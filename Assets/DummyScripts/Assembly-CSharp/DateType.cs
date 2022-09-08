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

public class DateType // TypeDefIndex: 14804
{
	// Fields
	public ushort year; // 0x10
	public ushort month; // 0x12
	public ushort day; // 0x14
	private static Regex _validReg; // 0x00
	private static string _parseReg; // 0x08

	// Constructors
	public DateType() {} // 0x00000001817947D0-0x0000000181794830
	static DateType() {} // 0x0000000181794730-0x00000001817947D0

	// Methods
	// [XID] // 0x0000000189AFD970-0x0000000189AFD990
	public static bool IsValid(string val) => default; // 0x00000001817943C0-0x00000001817944B0
	// [XID] // 0x0000000189B05100-0x0000000189B05120
	public bool ParseFrom(string val) => default; // 0x00000001817944B0-0x0000000181794730
}

