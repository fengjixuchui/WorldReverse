/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FixedTimePulse // TypeDefIndex: 11072
{
	// Fields
	private readonly TimeSpan _target; // 0x10
	private TimeSpan _accumulated; // 0x18

	// Properties
	public TimeSpan hijacked { /* [XID] */ /* 0x0000000189652740-0x0000000189652780 */ get; /* [XID] */ /* 0x000000018965D180-0x000000018965D1C0 */ private set; } // 0x000000018140B4F0-0x000000018140B550 0x000000018140B6E0-0x000000018140B740

	// Constructors
	public FixedTimePulse() {} // Dummy constructor
	public FixedTimePulse(TimeSpan target) {} // 0x000000018140B740-0x000000018140B7B0

	// Methods
	// [XID] // 0x00000001895EE710-0x00000001895EE730
	public bool Trigger(TimeSpan delta) => default; // 0x000000018140B550-0x000000018140B6E0
}

