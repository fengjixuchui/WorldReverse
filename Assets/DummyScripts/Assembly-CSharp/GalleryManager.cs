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

public sealed class GalleryManager : GlobalManager // TypeDefIndex: 20728
{
	// Fields
	private List<uint> _monsterNeed2Check; // 0x10
	private float curInterval; // 0x18
	private const float TickInterval = 0.5f; // Metadata: 0x00AFE1DE
	private Dictionary<uint, bool> _monsterIdDic; // 0x20

	// Constructors
	public GalleryManager() {} // 0x0000000184010B90-0x0000000184010C50

	// Methods
	// [XID] // 0x0000000189B9A7E0-0x0000000189B9A800
	public override void Init() {} // 0x0000000184010780-0x0000000184010820
	// [XID] // 0x0000000189BA1F90-0x0000000189BA1FB0
	public override void ReloadRes() {} // 0x0000000184010990-0x0000000184010A30
	// [XID] // 0x0000000189BA9360-0x0000000189BA9380
	public override void ClearOnLevelDestroy() {} // 0x000000018400FE50-0x000000018400FF00
	// [XID] // 0x0000000189BB0B30-0x0000000189BB0B50
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFE1DD */) {} // 0x000000018400FD70-0x000000018400FE50
	// [XID] // 0x0000000189BB7DE0-0x0000000189BB7E00
	public override void Destroy() {} // 0x000000018400FF00-0x000000018400FFD0
	// [XID] // 0x0000000189BBF4B0-0x0000000189BBF4D0
	public override void Tick() {} // 0x0000000184010A30-0x0000000184010B90
	// [XID] // 0x0000000189BC7070-0x0000000189BC7090
	private void FindNewItem(uint configId) {} // 0x0000000184010630-0x0000000184010780
	// [XID] // 0x00000001899A0D30-0x00000001899A0D50
	public void AddCheckMonster(uint entityId) {} // 0x0000000184010820-0x0000000184010910
	// [XID] // 0x0000000189BD60E0-0x0000000189BD6100
	private bool CheckMonster(uint entityId) => default; // 0x000000018400FFD0-0x0000000184010450
	// [XID] // 0x0000000189BDDCC0-0x0000000189BDDCE0
	public void AddSeenMonster(AllSeenMonsterNotify notify) {} // 0x00000001840104B0-0x0000000184010630
}

