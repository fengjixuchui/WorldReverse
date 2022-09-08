/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FixedVector3Stack : FixedStack<Vector3> // TypeDefIndex: 31404
{
	// Fields
	private Vector3 _value; // 0x48
	private Vector3 _initialValue; // 0x54
	private Action _updateValue; // 0x60

	// Properties
	public override Vector3 value { /* [XID] */ /* 0x000000018974EBB0-0x000000018974EBD0 */ get => default; } // 0x0000000181FF0B40-0x0000000181FF0C20 

	// Nested types
	public enum StackMethod // TypeDefIndex: 31405
	{
		Top = 0,
		Sum = 1
	}

	// Constructors
	public FixedVector3Stack() {} // Dummy constructor
	public FixedVector3Stack(Vector3 initial, StackMethod valueType, int capacity, Action<Vector3, int, Vector3, int> onChanged = null) {} // 0x0000000181FF1000-0x0000000181FF1120

	// Methods
	// [XID] // 0x00000001897562C0-0x00000001897562E0
	private void UpdateTop() {} // 0x0000000181FF09A0-0x0000000181FF0A60
	// [XID] // 0x000000018975D660-0x000000018975D680
	private void UpdateSummed() {} // 0x0000000181FF0C20-0x0000000181FF0E30
	// [XID] // 0x0000000189764CB0-0x0000000189764CD0
	protected override void OnChanged(Vector3 oldValue, int oldStackIx, Vector3 newValue, int newStackIx) {} // 0x0000000181FF0E90-0x0000000181FF1000
	// [XID] // 0x000000018976C6F0-0x000000018976C710
	public override void Reinit() {} // 0x0000000181FF0A60-0x0000000181FF0B40
}

