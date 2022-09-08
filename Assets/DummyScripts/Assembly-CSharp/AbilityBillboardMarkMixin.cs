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

public sealed class AbilityBillboardMarkMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14491
{
	// Fields
	private BillboardMarkMixin _config; // 0x70
	private VCBillboard _vcBillboard; // 0x78
	private LCBaseCombat _combat; // 0x80

	// Constructors
	public AbilityBillboardMarkMixin() {} // 0x000000018468CF60-0x000000018468CFC0

	// Methods
	// [XID] // 0x00000001898794C0-0x00000001898794E0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018468C7D0-0x000000018468C960
	// [XID] // 0x0000000189880B50-0x0000000189880B70
	public override void Clear() {} // 0x000000018468CA50-0x000000018468CB00
	// [XID] // 0x0000000189887F40-0x0000000189887F60
	public override void OnAdded(bool syncToServer) {} // 0x000000018468C300-0x000000018468C450
	// [XID] // 0x000000018988F480-0x000000018988F4A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018468C690-0x000000018468C7D0
	// [XID] // 0x00000001898969C0-0x00000001898969E0
	public override void Tick(float inDeltaTime) {} // 0x000000018468CE70-0x000000018468CF60
	// [XID] // 0x000000018989DE50-0x000000018989DE70
	private void ShowGeneralMark(bool show) {} // 0x000000018468CB60-0x000000018468CC90
	[BlackList] // 0x00000001898A57F0-0x00000001898A5830
	// [XID] // 0x00000001898A57F0-0x00000001898A5830
	public override void AutoAllocTypeFields() {} // 0x000000018468C4E0-0x000000018468C580
	[BlackList] // 0x00000001898AFF50-0x00000001898AFF90
	// [XID] // 0x00000001898AFF50-0x00000001898AFF90
	public override void AutoRecycleTypeFields() {} // 0x000000018468C580-0x000000018468C630
	[BlackList] // 0x00000001898BAA60-0x00000001898BAAA0
	// [XID] // 0x00000001898BAA60-0x00000001898BAAA0
	public override void ReturnToObjectPool() {} // 0x000000018468CDD0-0x000000018468CE70
}

