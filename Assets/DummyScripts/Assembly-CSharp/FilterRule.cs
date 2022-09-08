/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FilterRule // TypeDefIndex: 31582
{
	// Fields
	private bool _bExclusive; // 0x10
	private List<string> _startWith; // 0x18
	private List<string> _contains; // 0x20
	private List<string> _endWith; // 0x28

	// Properties
	public bool bExclusive { /* [XID] */ /* 0x0000000189AE1850-0x0000000189AE1870 */ set {} } // 0x0000000183433BA0-0x0000000183433C50

	// Constructors
	public FilterRule() {} // Dummy constructor
	public FilterRule(params /* 0x000000018989F6F0-0x000000018989F700 */ string[] symbols) {} // 0x0000000183433DA0-0x0000000183434000

	// Methods
	// [IDTag] // 0x0000000189AE9020-0x0000000189AE9060
	// [XID] // 0x0000000189AE9020-0x0000000189AE9060
	public override string ToString() => default; // 0x0000000183433C50-0x0000000183433DA0
	// [IDTag] // 0x0000000189AF3BF0-0x0000000189AF3C30
	// [XID] // 0x0000000189AF3BF0-0x0000000189AF3C30
	public static string ToString(string prefix, List<string> inWildcards) => default; // 0x0000000183433440-0x0000000183433630
	// [XID] // 0x0000000189AFDFE0-0x0000000189AFE000
	public static bool EndAny(string targetString, List<string> inWildcards) => default; // 0x0000000183433190-0x0000000183433380
	// [XID] // 0x0000000189B057B0-0x0000000189B057D0
	public static bool ContainAny(string targetString, List<string> inWildcards) => default; // 0x0000000183433820-0x0000000183433A10
	// [XID] // 0x0000000189B0CF60-0x0000000189B0CF80
	public static bool StartAny(string targetString, List<string> inWildcards) => default; // 0x0000000183433630-0x0000000183433820
	// [XID] // 0x0000000189B145B0-0x0000000189B145D0
	public bool ParseItem(string inStrContent) => default; // 0x0000000183433380-0x0000000183433440
	// [XID] // 0x0000000189B1BDF0-0x0000000189B1BE10
	private bool InternalParseItem(string inStringContent) => default; // 0x0000000183433A10-0x0000000183433BA0
}

