/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BushEntity : ScenePropEntity, IAutoAllocRecycle // TypeDefIndex: 19882
{
	// Fields
	public ICombatSceneProp bushObj; // 0x588

	// Constructors
	public BushEntity() {} // 0x0000000182322FA0-0x0000000182323020

	// Methods
	// [XID] // 0x000000018960B950-0x000000018960B970
	public override void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AFCFDB */) {} // 0x0000000182322B40-0x0000000182322C20
	// [XID] // 0x0000000189612EE0-0x0000000189612F00
	public override void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AFCFDF */, bool runtimeIDChange = false /* Metadata: 0x00AFCFE3 */) {} // 0x0000000182322C20-0x0000000182322D00
	// [XID] // 0x000000018961A660-0x000000018961A680
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x0000000182322440-0x0000000182322510
	// [XID] // 0x0000000189621B80-0x0000000189621BA0
	public void Reset(int bushId) {} // 0x00000001823225F0-0x00000001823229D0
	// [XID] // 0x0000000189629510-0x0000000189629530
	public override Transform GetAttachPoint(string name) => default; // 0x00000001823229D0-0x0000000182322B40
	public override bool SetToBeRemoved<T>(ref T entityFieldToClear, bool checkSyncFromAuthority = true /* Metadata: 0x00AFCFE4 */, bool isRecoverFromServer = false /* Metadata: 0x00AFCFE5 */) => default;
	// [XID] // 0x0000000189630E00-0x0000000189630E20
	public override long GetScenePropID() => default; // 0x0000000182322DE0-0x0000000182322EA0
	[BlackList] // 0x0000000189638900-0x0000000189638940
	// [XID] // 0x0000000189638900-0x0000000189638940
	public override void AutoAllocTypeFields() {} // 0x00000001823221F0-0x0000000182322290
	[BlackList] // 0x0000000189642E00-0x0000000189642E40
	// [XID] // 0x0000000189642E00-0x0000000189642E40
	public override void AutoRecycleTypeFields() {} // 0x0000000182322290-0x0000000182322340
	[BlackList] // 0x000000018964D5A0-0x000000018964D5E0
	// [XID] // 0x000000018964D5A0-0x000000018964D5E0
	public override void ReturnToObjectPool() {} // 0x0000000182322F00-0x0000000182322FA0
}

