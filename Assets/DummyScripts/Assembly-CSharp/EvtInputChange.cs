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

public sealed class EvtInputChange : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20126
{
	// Fields
	private InputDeviceType _deviceType; // 0x30

	// Properties
	public InputDeviceType deviceType { /* [XID] */ /* 0x00000001897713C0-0x00000001897713E0 */ get => default; } // 0x0000000182509B10-0x0000000182509BB0 

	// Constructors
	public EvtInputChange() {} // 0x0000000182509D10-0x0000000182509D70

	// Methods
	[BlackList] // 0x0000000189751EB0-0x0000000189751EF0
	// [XID] // 0x0000000189751EB0-0x0000000189751EF0
	public override void AutoAllocTypeFields() {} // 0x00000001825098A0-0x0000000182509940
	[BlackList] // 0x000000018975C3D0-0x000000018975C410
	// [XID] // 0x000000018975C3D0-0x000000018975C410
	public override void AutoRecycleTypeFields() {} // 0x0000000182509940-0x00000001825099F0
	[BlackList] // 0x0000000189766C60-0x0000000189766CA0
	// [XID] // 0x0000000189766C60-0x0000000189766CA0
	public override void ReturnToObjectPool() {} // 0x0000000182509C70-0x0000000182509D10
	// [XID] // 0x0000000189778C20-0x0000000189778C40
	public void Init(InputDeviceType type) {} // 0x0000000182509A50-0x0000000182509B10
}

