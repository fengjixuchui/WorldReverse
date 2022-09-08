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

public sealed class AbilityTileAttackMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14581
{
	// Fields
	private TileAttackMixin _config; // 0x70
	private LevelTileAttackPlugin _tilePlugin; // 0x78

	// Constructors
	public AbilityTileAttackMixin() {} // 0x0000000181DFFAB0-0x0000000181DFFB10

	// Methods
	// [XID] // 0x000000018999F0B0-0x000000018999F0D0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181DFF3B0-0x0000000181DFF540
	// [XID] // 0x00000001899A69D0-0x00000001899A69F0
	public override void Clear() {} // 0x0000000181DFF5B0-0x0000000181DFF660
	// [XID] // 0x00000001899AE2A0-0x00000001899AE2C0
	protected override void AddEventListener() {} // 0x0000000181DFF150-0x0000000181DFF2A0
	// [XID] // 0x00000001899B5960-0x00000001899B5980
	protected override void RemoveEventListener() {} // 0x0000000181DFF6C0-0x0000000181DFF810
	// [XID] // 0x00000001899BD200-0x00000001899BD220
	public override void OnAdded(bool syncToServer) {} // 0x0000000181DFEEB0-0x0000000181DFEF70
	// [XID] // 0x00000001899C4B90-0x00000001899C4BB0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181DFF300-0x0000000181DFF3B0
	[BlackList] // 0x00000001899CC230-0x00000001899CC270
	// [XID] // 0x00000001899CC230-0x00000001899CC270
	public override void AutoAllocTypeFields() {} // 0x0000000181DFF000-0x0000000181DFF0A0
	[BlackList] // 0x00000001899D66D0-0x00000001899D6710
	// [XID] // 0x00000001899D66D0-0x00000001899D6710
	public override void AutoRecycleTypeFields() {} // 0x0000000181DFF0A0-0x0000000181DFF150
	[BlackList] // 0x00000001899E0D30-0x00000001899E0D70
	// [XID] // 0x00000001899E0D30-0x00000001899E0D70
	public override void ReturnToObjectPool() {} // 0x0000000181DFFA10-0x0000000181DFFAB0
}

