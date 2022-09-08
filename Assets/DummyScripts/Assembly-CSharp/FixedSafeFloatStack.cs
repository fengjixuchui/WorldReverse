/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FixedSafeFloatStack : FixedStack<SafeFloat> // TypeDefIndex: 31401
{
	// Fields
	private const int DEFAULT_FLOAT_STACK_CAPACITY = 12; // Metadata: 0x00B12655
	private SafeFloat _value; // 0x48
	private SafeFloat _initialValue; // 0x58
	private Action _updateValue; // 0x68
	private float _floor; // 0x70
	private float _ceiling; // 0x74
	private float _limitedTagFloor; // 0x78
	private float _limitedTagCeiling; // 0x7C

	// Properties
	public override SafeFloat value { /* [XID] */ /* 0x0000000189712F10-0x0000000189712F30 */ get => default; } // 0x00000001819FC810-0x00000001819FC8E0 

	// Constructors
	public FixedSafeFloatStack() {} // Dummy constructor
	public FixedSafeFloatStack(float initial, StackMethod valueType, float floor, float ceiling, bool useTag = false /* Metadata: 0x00B1264C */, float limitedTagFloor = -3.4028235E+38f /* Metadata: 0x00B1264D */, float limitedTagCeiling = 3.4028235E+38f /* Metadata: 0x00B12651 */, Action<SafeFloat, int, SafeFloat, int> onChanged = null) {} // 0x00000001819FD460-0x00000001819FD670

	// Methods
	// [XID] // 0x000000018971A7B0-0x000000018971A7D0
	private void UpdateSummed() {} // 0x00000001819FCBF0-0x00000001819FCEF0
	// [XID] // 0x0000000189721B30-0x0000000189721B50
	private void UpdateMultiplied() {} // 0x00000001819FD160-0x00000001819FD460
	// [XID] // 0x0000000189729160-0x0000000189729180
	private void UpdateTop() {} // 0x00000001819FC680-0x00000001819FC730
	// [XID] // 0x00000001897309E0-0x0000000189730A00
	private void UpdateOneMinusMultiplied() {} // 0x00000001819FC8E0-0x00000001819FCBF0
	// [XID] // 0x00000001897382F0-0x0000000189738310
	protected override void OnChanged(SafeFloat oldValue, int oldStackIx, SafeFloat newValue, int newStackIx) {} // 0x00000001819FCF50-0x00000001819FD160
	// [XID] // 0x0000000189740050-0x0000000189740070
	public override void Reinit() {} // 0x00000001819FC730-0x00000001819FC810
}

