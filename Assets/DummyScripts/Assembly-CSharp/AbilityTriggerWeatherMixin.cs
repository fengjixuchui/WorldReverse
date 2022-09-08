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

public sealed class AbilityTriggerWeatherMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14594
{
	// Fields
	private TriggerWeatherMixin config; // 0x70
	private NormalTimer _timer; // 0x78
	private bool isInWeather; // 0x80

	// Constructors
	public AbilityTriggerWeatherMixin() {} // 0x0000000183CFFA20-0x0000000183CFFA90

	// Methods
	// [XID] // 0x0000000189916720-0x0000000189916740
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183CFEF40-0x0000000183CFF0D0
	// [XID] // 0x000000018991DED0-0x000000018991DEF0
	public override void Clear() {} // 0x0000000183CFF1C0-0x0000000183CFF2C0
	// [XID] // 0x00000001899257C0-0x00000001899257E0
	public override void Tick(float inDeltaTime) {} // 0x0000000183CFF8E0-0x0000000183CFFA20
	// [XID] // 0x000000018992CC30-0x000000018992CC50
	public override void OnAdded(bool syncToServer) {} // 0x0000000183CFEA70-0x0000000183CFEB30
	// [XID] // 0x0000000189934160-0x0000000189934180
	private void TriggerWeather() {} // 0x0000000183CFF2C0-0x0000000183CFF500
	// [XID] // 0x000000018993BE70-0x000000018993BE90
	private void RemoveWeather() {} // 0x0000000183CFF560-0x0000000183CFF700
	// [XID] // 0x00000001899431D0-0x00000001899431F0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183CFEE80-0x0000000183CFEF40
	// [XID] // 0x000000018994A960-0x000000018994A980
	public override void OnDisable() {} // 0x0000000183CFED10-0x0000000183CFEDC0
	[BlackList] // 0x00000001899523B0-0x00000001899523F0
	// [XID] // 0x00000001899523B0-0x00000001899523F0
	public override void AutoAllocTypeFields() {} // 0x0000000183CFEBC0-0x0000000183CFEC60
	[BlackList] // 0x000000018995C880-0x000000018995C8C0
	// [XID] // 0x000000018995C880-0x000000018995C8C0
	public override void AutoRecycleTypeFields() {} // 0x0000000183CFEC60-0x0000000183CFED10
	[BlackList] // 0x00000001899672F0-0x0000000189967330
	// [XID] // 0x00000001899672F0-0x0000000189967330
	public override void ReturnToObjectPool() {} // 0x0000000183CFF840-0x0000000183CFF8E0
}

