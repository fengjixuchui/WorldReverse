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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TheWorldLockManager : GlobalManager // TypeDefIndex: 21334
{
	// Fields
	private Dictionary<uint, TheWorldLockResource> _lockResourceDic; // 0x10

	// Constructors
	public TheWorldLockManager() {} // 0x0000000182130860-0x00000001821308D0

	// Methods
	// [XID] // 0x0000000189B48D40-0x0000000189B48D60
	public override void Init() {} // 0x0000000182130560-0x0000000182130630
	// [XID] // 0x0000000189B50460-0x0000000189B50480
	public override void Destroy() {} // 0x0000000182130240-0x00000001821302E0
	// [XID] // 0x0000000189B57C50-0x0000000189B57C70
	public override void ClearOnDisconnect() {} // 0x0000000182130100-0x00000001821301A0
	// [XID] // 0x0000000189B5F680-0x0000000189B5F6A0
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF4B7 */) {} // 0x0000000182130050-0x0000000182130100
	// [XID] // 0x0000000189B66DA0-0x0000000189B66DC0
	public override void ReloadRes() {} // 0x00000001821307C0-0x0000000182130860
	// [XID] // 0x0000000189B6E100-0x0000000189B6E120
	public override void ClearOnLevelDestroy() {} // 0x00000001821301A0-0x0000000182130240
	// [XID] // 0x0000000189B758D0-0x0000000189B758F0
	private void ClearData() {} // 0x00000001821306B0-0x0000000182130760
	// [XID] // 0x0000000189B7CD70-0x0000000189B7CD90
	public void TryDoActionWithLockTheWorldResource(TheWorldResourceType resourceType, TheWorldLockType lockType, Action action) {} // 0x00000001821303E0-0x0000000182130560
	// [XID] // 0x0000000189B84C10-0x0000000189B84C30
	public void TryUnlockTheWorldResource(TheWorldResourceType resourceType, TheWorldLockType lockType) {} // 0x00000001821302E0-0x00000001821303E0
	// [XID] // 0x0000000189B8B9C0-0x0000000189B8B9E0
	public TheWorldLockType GetWorldResourceCurrLockType(TheWorldResourceType resourceType) => default; // 0x000000018212FF60-0x0000000182130050
}

