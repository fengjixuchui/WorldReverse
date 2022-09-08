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

public sealed class BanManager : GlobalManager // TypeDefIndex: 20742
{
	// Fields
	private Dictionary<uint, Dictionary<int, int>> _questBanCntDic; // 0x10

	// Constructors
	public BanManager() {} // 0x000000018182EBF0-0x000000018182EC80

	// Methods
	// [XID] // 0x0000000189976CF0-0x0000000189976D10
	public override void Init() {} // 0x000000018182E890-0x000000018182E950
	// [XID] // 0x000000018997E100-0x000000018997E120
	public override void Destroy() {} // 0x000000018182E600-0x000000018182E6E0
	// [XID] // 0x0000000189985C30-0x0000000189985C50
	public override void ReloadRes() {} // 0x000000018182EB50-0x000000018182EBF0
	// [XID] // 0x000000018998D860-0x000000018998D880
	public override void ClearOnLevelDestroy() {} // 0x000000018182E380-0x000000018182E420
	// [XID] // 0x0000000189995310-0x0000000189995330
	public override void ClearOnDisconnect() {} // 0x000000018182E2C0-0x000000018182E380
	// [XID] // 0x000000018999CDD0-0x000000018999CDF0
	public void BanByType(uint questId, BanType type) {} // 0x000000018182E420-0x000000018182E600
	// [XID] // 0x00000001899A4670-0x00000001899A4690
	public void FreeByType(uint questId, BanType type) {} // 0x000000018182E6E0-0x000000018182E890
	// [XID] // 0x00000001899AC050-0x00000001899AC070
	public bool IsBan(BanType type) => default; // 0x000000018182E950-0x000000018182EAF0
}

