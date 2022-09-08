/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityDvalinS01PathEffsMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14522
{
	// Fields
	private DvalinS01PathEffsMixin _config; // 0x70
	private MonoTestDvalinS01 _stage; // 0x78
	private bool initialized; // 0x80
	private int _effStart; // 0x84
	private int _effEnd; // 0x88
	private int _efftHandleLength; // 0x8C
	private Queue<List<GameObject>> _pathEffectHandles; // 0x90
	private int[] _effIntervals; // 0x98

	// Constructors
	public AbilityDvalinS01PathEffsMixin() {} // 0x0000000182E25A20-0x0000000182E25AA0

	// Methods
	// [XID] // 0x0000000189655770-0x0000000189655790
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182E246A0-0x0000000182E24A10
	// [XID] // 0x000000018965CF40-0x000000018965CF60
	private bool CheckInit() => default; // 0x0000000182E25360-0x0000000182E25610
	// [XID] // 0x0000000189664510-0x0000000189664530
	private void UpdatePathEffect() {} // 0x0000000182E24320-0x0000000182E245F0
	// [XID] // 0x000000018966BB30-0x000000018966BB50
	private void AttachPathEffect(int index, Transform targetPoint, List<GameObject> hanles) {} // 0x0000000182E24BF0-0x0000000182E25300
	// [XID] // 0x0000000189673940-0x0000000189673960
	protected override void AddEventListener() {} // 0x0000000182E240D0-0x0000000182E242C0
	// [XID] // 0x000000018967B0A0-0x000000018967B0C0
	protected override void RemoveEventListener() {} // 0x0000000182E25610-0x0000000182E25780
	// [XID] // 0x0000000189682940-0x0000000189682960
	public override void OnAdded(bool syncToServer) {} // 0x0000000182E23E10-0x0000000182E23ED0
	// [XID] // 0x000000018968A520-0x000000018968A540
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182E245F0-0x0000000182E246A0
	// [XID] // 0x0000000189692270-0x0000000189692290
	public override void Clear() {} // 0x0000000182E24A80-0x0000000182E24BF0
	[BlackList] // 0x0000000189699690-0x00000001896996D0
	// [XID] // 0x0000000189699690-0x00000001896996D0
	public override void AutoAllocTypeFields() {} // 0x0000000182E23F60-0x0000000182E24000
	[BlackList] // 0x00000001896A3BD0-0x00000001896A3C10
	// [XID] // 0x00000001896A3BD0-0x00000001896A3C10
	public override void AutoRecycleTypeFields() {} // 0x0000000182E24000-0x0000000182E240D0
	[BlackList] // 0x00000001896ADE90-0x00000001896ADED0
	// [XID] // 0x00000001896ADE90-0x00000001896ADED0
	public override void ReturnToObjectPool() {} // 0x0000000182E25980-0x0000000182E25A20
}

