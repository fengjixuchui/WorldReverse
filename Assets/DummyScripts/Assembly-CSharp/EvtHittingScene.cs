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

public sealed class EvtHittingScene : BaseEvent, IAutoAllocRecycle, IEvtWithHitCollision, IEvtWithAttackTag // TypeDefIndex: 20124
{
	// Fields
	private AttackResult.HitCollsion _hitCollision; // 0x30
	private string _animEventID; // 0x60
	private string _attackTag; // 0x68

	// Constructors
	public EvtHittingScene() {} // 0x00000001811F4540-0x00000001811F45A0

	// Methods
	[BlackList] // 0x00000001896DF680-0x00000001896DF6C0
	// [XID] // 0x00000001896DF680-0x00000001896DF6C0
	public override void AutoAllocTypeFields() {} // 0x00000001811F3B50-0x00000001811F3BF0
	[BlackList] // 0x00000001896E9B60-0x00000001896E9BA0
	// [XID] // 0x00000001896E9B60-0x00000001896E9BA0
	public override void AutoRecycleTypeFields() {} // 0x00000001811F3BF0-0x00000001811F3CE0
	[BlackList] // 0x00000001896F4060-0x00000001896F40A0
	// [XID] // 0x00000001896F4060-0x00000001896F40A0
	public override void ReturnToObjectPool() {} // 0x00000001811F41C0-0x00000001811F4260
	// [XID] // 0x00000001896FEA00-0x00000001896FEA20
	public void Init(uint fromID, AttackResult.HitCollsion hitCollision, string animEventID, string attackTag) {} // 0x00000001811F3DB0-0x00000001811F3EF0
	// [XID] // 0x0000000189705D00-0x0000000189705D20
	public AttackResult.HitCollsion? GetHitCollision() => default; // 0x00000001811F3EF0-0x00000001811F4060
	// [XID] // 0x000000018970D670-0x000000018970D690
	public string GetAnimEventID() => default; // 0x00000001811F3AB0-0x00000001811F3B50
	// [XID] // 0x0000000189714A70-0x0000000189714A90
	public string GetAttackTag() => default; // 0x00000001811F4120-0x00000001811F41C0
	// [XID] // 0x000000018971C4C0-0x000000018971C4E0
	public override string ToString() => default; // 0x00000001811F4260-0x00000001811F4540
}

