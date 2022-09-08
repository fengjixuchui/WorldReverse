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

public class TimeType // TypeDefIndex: 14803
{
	// Fields
	public ushort hour; // 0x10
	public ushort minute; // 0x12
	public ushort second; // 0x14
	private static Regex _validReg; // 0x00
	private static string _parseReg; // 0x08

	// Constructors
	public TimeType() {} // 0x0000000181EC8D90-0x0000000181EC8DF0
	static TimeType() {} // 0x0000000181EC8CF0-0x0000000181EC8D90

	// Methods
	// [XID] // 0x0000000189AEEDC0-0x0000000189AEEDE0
	public static bool IsValid(string val) => default; // 0x0000000181EC8980-0x0000000181EC8A70
	// [XID] // 0x0000000189AF62B0-0x0000000189AF62D0
	public bool ParseFrom(string val) => default; // 0x0000000181EC8A70-0x0000000181EC8CF0
}

