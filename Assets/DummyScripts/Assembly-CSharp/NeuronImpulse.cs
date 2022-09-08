/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NeuronImpulse : NeuronBase, IAutoAllocRecycle // TypeDefIndex: 20218
{
	// Fields
	public float stimuliTime; // 0x20

	// Constructors
	public NeuronImpulse() {} // 0x0000000184A90F50-0x0000000184A90FD0

	// Methods
	[BlackList] // 0x00000001897A6140-0x00000001897A6180
	// [XID] // 0x00000001897A6140-0x00000001897A6180
	public override void AutoAllocTypeFields() {} // 0x0000000184A90880-0x0000000184A90920
	[BlackList] // 0x00000001897B0600-0x00000001897B0640
	// [XID] // 0x00000001897B0600-0x00000001897B0640
	public override void AutoRecycleTypeFields() {} // 0x0000000184A90920-0x0000000184A909D0
	[BlackList] // 0x00000001897BB8F0-0x00000001897BB930
	// [XID] // 0x00000001897BB8F0-0x00000001897BB930
	public override void ReturnToObjectPool() {} // 0x0000000184A90EB0-0x0000000184A90F50
	// [XID] // 0x00000001897C62B0-0x00000001897C62D0
	public override bool IsStimulated(float currentTime) => default; // 0x0000000184A909D0-0x0000000184A90A90
	// [XID] // 0x00000001897CDAE0-0x00000001897CDB00
	public override void SetStimulate(bool stimulate, float currentTime) {} // 0x0000000184A90DD0-0x0000000184A90EB0
	// [XID] // 0x00000001897D5030-0x00000001897D5050
	public override void Reset() {} // 0x0000000184A90BE0-0x0000000184A90C90
}

