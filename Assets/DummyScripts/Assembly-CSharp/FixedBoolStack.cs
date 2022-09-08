/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FixedBoolStack : FixedStack<bool> // TypeDefIndex: 31398
{
	// Fields
	private bool _value; // 0x48
	private Action _updateValue; // 0x50

	// Properties
	public override bool value { /* [XID] */ /* 0x0000000189693E40-0x0000000189693E60 */ get => default; } // 0x0000000183542CD0-0x0000000183542D70 
	public StackMethod updateType { /* [XID] */ /* 0x000000018969B3F0-0x000000018969B430 */ get; private set; } // 0x0000000183542C70-0x0000000183542CD0 0x0000000183542D70-0x0000000183542DD0

	// Nested types
	public enum StackMethod // TypeDefIndex: 31399
	{
		OnceTrue = 0,
		OnceFalse = 1
	}

	// Constructors
	public FixedBoolStack() {} // Dummy constructor
	public FixedBoolStack(int capacity, StackMethod valueType, Action<bool, int, bool, int> onChanged = null) {} // 0x0000000183543080-0x0000000183543210

	// Methods
	// [XID] // 0x00000001896ACE50-0x00000001896ACE70
	private void UpdateOnceTrue() {} // 0x0000000183542DD0-0x0000000183542F00
	// [XID] // 0x00000001896B4470-0x00000001896B4490
	private void UpdateOnceFalse() {} // 0x00000001835427E0-0x0000000183542910
	// [XID] // 0x00000001896BB6F0-0x00000001896BB710
	public override void Reinit() {} // 0x0000000183542910-0x0000000183542A10
	// [IDTag] // 0x00000001896C2BA0-0x00000001896C2BE0
	// [XID] // 0x00000001896C2BA0-0x00000001896C2BE0
	public override int Push(bool value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00B12636 */, bool silent = false /* Metadata: 0x00B1263A */) => default; // 0x0000000183542B60-0x0000000183542C70
	// [IDTag] // 0x00000001896CD300-0x00000001896CD340
	// [XID] // 0x00000001896CD300-0x00000001896CD340
	public override void Push(int ix, bool value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00B1263B */, bool silent = false /* Metadata: 0x00B1263F */) {} // 0x0000000183542A10-0x0000000183542B60
	// [XID] // 0x00000001896D77C0-0x00000001896D77E0
	protected override void OnChanged(bool oldValue, int oldStackIx, bool newValue, int newStackIx) {} // 0x0000000183542F60-0x0000000183543080
}

