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

public sealed class VCAvatarTriggerEvent : VCBase // TypeDefIndex: 11802
{
	// Fields
	private float _returnDist; // 0x108
	private Coroutine _requestDungeonPlayerDieCoroutine; // 0x110
	private float _oldSBlackScreenSpeed; // 0x118

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897E96B0-0x00000001897E96D0 */ get => default; } // 0x0000000182FB4000-0x0000000182FB40A0 

	// Constructors
	public VCAvatarTriggerEvent() {} // 0x0000000182FB3FA0-0x0000000182FB4000

	// Methods
	// [XID] // 0x00000001897F13A0-0x00000001897F13C0
	public override void Destroy() {} // 0x0000000182FB29C0-0x0000000182FB2A70
	// [XID] // 0x0000000189816490-0x00000001898164B0
	private void ClearRequestDungeonPlayerDieCoroutine() {} // 0x0000000182FB2A70-0x0000000182FB2C50
	// [XID] // 0x0000000189825460-0x0000000189825480
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000182FB2900-0x0000000182FB29C0
	// [XID] // 0x0000000189825220-0x0000000189825240
	private void BlackScreen(float value) {} // 0x0000000182FB27B0-0x0000000182FB2900
	// [XID] // 0x000000018983B830-0x000000018983B850
	private void ResetScreen() {} // 0x0000000182FB2D50-0x0000000182FB2E00
	// [XID] // 0x0000000189834340-0x0000000189834360
	private void UpdateScreen(float dist) {} // 0x0000000182FB3020-0x0000000182FB3120
	// [XID] // 0x000000018983B710-0x000000018983B730
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182FB2C50-0x0000000182FB2D50
	// [XID] // 0x00000001898430D0-0x00000001898430F0
	public void PlayerDie(float delay = 0.5f /* Metadata: 0x00AEABEB */) {} // 0x0000000182FB24B0-0x0000000182FB27B0
	// [XID] // 0x000000018984A330-0x000000018984A350
	private void RequestDungeonPlayerDie() {} // 0x0000000182FB2E00-0x0000000182FB2FC0
	// [XID] // 0x00000001898679F0-0x0000000189867A10
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000182FB3280-0x0000000182FB3FA0
}

