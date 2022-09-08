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

public sealed class EvtWindSeedMixinInfo : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20184
{
	// Fields
	public WindSeedMixinAction mixinAction; // 0x30
	public int windBulletNum; // 0x34

	// Nested types
	public enum WindSeedMixinAction // TypeDefIndex: 20185
	{
		FirstWindBullet = 0,
		SecondWindBullet = 1,
		SpawnWindField = 2
	}

	// Constructors
	public EvtWindSeedMixinInfo() {} // 0x0000000182D868F0-0x0000000182D86950

	// Methods
	[BlackList] // 0x00000001895F4F50-0x00000001895F4F90
	// [XID] // 0x00000001895F4F50-0x00000001895F4F90
	public override void AutoAllocTypeFields() {} // 0x0000000182D863B0-0x0000000182D86450
	[BlackList] // 0x00000001895FF550-0x00000001895FF590
	// [XID] // 0x00000001895FF550-0x00000001895FF590
	public override void AutoRecycleTypeFields() {} // 0x0000000182D86450-0x0000000182D86500
	[BlackList] // 0x0000000189609FB0-0x0000000189609FF0
	// [XID] // 0x0000000189609FB0-0x0000000189609FF0
	public override void ReturnToObjectPool() {} // 0x0000000182D86770-0x0000000182D86810
	// [XID] // 0x00000001896143B0-0x00000001896143D0
	public void Init(WindSeedMixinAction action, int windBulletNum) {} // 0x0000000182D865D0-0x0000000182D866B0
	// [XID] // 0x000000018961BE10-0x000000018961BE30
	public override string ToString() => default; // 0x0000000182D86810-0x0000000182D868F0
}

