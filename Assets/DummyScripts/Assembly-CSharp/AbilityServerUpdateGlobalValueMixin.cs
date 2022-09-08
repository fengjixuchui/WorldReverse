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

public sealed class AbilityServerUpdateGlobalValueMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14565
{
	// Fields
	private ServerUpdateGlobalValueMixin _config; // 0x70

	// Constructors
	public AbilityServerUpdateGlobalValueMixin() {} // 0x0000000182D156F0-0x0000000182D15750

	// Methods
	// [XID] // 0x00000001898D0EA0-0x00000001898D0EC0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182D150F0-0x0000000182D15230
	// [XID] // 0x00000001898D8440-0x00000001898D8460
	public override void Clear() {} // 0x0000000182D15230-0x0000000182D152E0
	// [XID] // 0x00000001898E02E0-0x00000001898E0300
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182D152E0-0x0000000182D153C0
	// [XID] // 0x00000001898E7E20-0x00000001898E7E40
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182D15560-0x0000000182D15650
	// [XID] // 0x00000001898EF4E0-0x00000001898EF500
	private bool OnEvtEvtGlobalValueChange(EvtGlobalValueChange evt) => default; // 0x0000000182D14DD0-0x0000000182D150F0
	[BlackList] // 0x00000001898F6DB0-0x00000001898F6DF0
	// [XID] // 0x00000001898F6DB0-0x00000001898F6DF0
	public override void AutoAllocTypeFields() {} // 0x0000000182D14C20-0x0000000182D14CC0
	[BlackList] // 0x0000000189901660-0x00000001899016A0
	// [XID] // 0x0000000189901660-0x00000001899016A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182D14CC0-0x0000000182D14D70
	[BlackList] // 0x000000018990BD20-0x000000018990BD60
	// [XID] // 0x000000018990BD20-0x000000018990BD60
	public override void ReturnToObjectPool() {} // 0x0000000182D15650-0x0000000182D156F0
}

