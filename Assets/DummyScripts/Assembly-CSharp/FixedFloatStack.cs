/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FixedFloatStack : FixedStack<float> // TypeDefIndex: 31400
{
	// Fields
	private const int DEFAULT_FLOAT_STACK_CAPACITY = 12; // Metadata: 0x00B12648
	private float _value; // 0x48
	private float _initialValue; // 0x4C
	private Action _updateValue; // 0x50
	private float _floor; // 0x58
	private float _ceiling; // 0x5C

	// Properties
	public override float value { /* [XID] */ /* 0x00000001896DEFA0-0x00000001896DEFC0 */ get => default; } // 0x00000001826C0550-0x00000001826C0600 

	// Constructors
	public FixedFloatStack() {} // Dummy constructor
	public FixedFloatStack(float initial, StackMethod valueType, float floor, float ceiling, Action<float, int, float, int> onChanged = null) {} // 0x00000001826C0B90-0x00000001826C0CF0

	// Methods
	// [XID] // 0x00000001896E6410-0x00000001896E6430
	private void UpdateSummed() {} // 0x00000001826C0740-0x00000001826C0860
	// [XID] // 0x00000001896ED920-0x00000001896ED940
	private void UpdateMultiplied() {} // 0x00000001826C0A60-0x00000001826C0B90
	// [XID] // 0x00000001896F50D0-0x00000001896F50F0
	private void UpdateTop() {} // 0x00000001826C03D0-0x00000001826C0480
	// [XID] // 0x00000001896FC910-0x00000001896FC930
	private void UpdateOneMinusMultiplied() {} // 0x00000001826C0600-0x00000001826C0740
	// [XID] // 0x0000000189703D90-0x0000000189703DB0
	protected override void OnChanged(float oldValue, int oldStackIx, float newValue, int newStackIx) {} // 0x00000001826C08C0-0x00000001826C0A60
	// [XID] // 0x000000018970B690-0x000000018970B6B0
	public override void Reinit() {} // 0x00000001826C0480-0x00000001826C0550
}

