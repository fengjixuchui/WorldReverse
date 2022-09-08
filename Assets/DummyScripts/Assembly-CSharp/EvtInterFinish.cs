/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtInterFinish : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20128
{
	// Fields
	public float delayTime; // 0x30
	public InteractionType targetType; // 0x34

	// Constructors
	public EvtInterFinish() {} // 0x00000001822EAB30-0x00000001822EABB0

	// Methods
	[BlackList] // 0x00000001897AF070-0x00000001897AF0B0
	// [XID] // 0x00000001897AF070-0x00000001897AF0B0
	public override void AutoAllocTypeFields() {} // 0x00000001822EA620-0x00000001822EA6C0
	[BlackList] // 0x00000001897B9850-0x00000001897B9890
	// [XID] // 0x00000001897B9850-0x00000001897B9890
	public override void AutoRecycleTypeFields() {} // 0x00000001822EA6C0-0x00000001822EA770
	[BlackList] // 0x00000001897C4640-0x00000001897C4680
	// [XID] // 0x00000001897C4640-0x00000001897C4680
	public override void ReturnToObjectPool() {} // 0x00000001822EAA90-0x00000001822EAB30
	// [XID] // 0x00000001899DC7E0-0x00000001899DC800
	public void Init(uint targetID, float pDelayTime = 0f /* Metadata: 0x00AFD272 */, InteractionType pTargetType = InteractionType.Other /* Metadata: 0x00AFD276 */) {} // 0x00000001822EA7D0-0x00000001822EA8C0
	// [XID] // 0x00000001897D6740-0x00000001897D6760
	public override void Clear() {} // 0x00000001822EA8C0-0x00000001822EA970
}

