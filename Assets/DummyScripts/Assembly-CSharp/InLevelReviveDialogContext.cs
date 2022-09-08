/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelReviveDialogContext : BaseDialogContext // TypeDefIndex: 29594
{
	// Fields
	private uint _dungeonID; // 0x178
	private PlayerDieType _dieType; // 0x17C
	private uint _reviveCountUsed; // 0x180
	private uint _reviveCountMax; // 0x184
	private long _reviveIntervalTime; // 0x188
	private long _lastRemainSeconds; // 0x190
	private bool _canRevive; // 0x198
	private MonoReviveDialog _dialogMono; // 0x1A0
	private bool _autoQuitEnabled; // 0x1A8
	private long _autoQuitLimit; // 0x1B0
	private uint _monsterID; // 0x1B8
	private bool _restartAvailable; // 0x1BC
	private bool _enoughReviveChance; // 0x1BD

	// Constructors
	public InLevelReviveDialogContext() {} // Dummy constructor
	public InLevelReviveDialogContext(DungeonPlayerDieNotify ntf) {} // 0x0000000182583CC0-0x0000000182583DE0
	public InLevelReviveDialogContext(WorldPlayerDieNotify ntf) {} // 0x0000000182583DE0-0x0000000182583EF0

	// Methods
	// [XID] // 0x0000000189990520-0x0000000189990540
	private void InitDialog() {} // 0x0000000182581FA0-0x0000000182582170
	// [XID] // 0x0000000189998090-0x00000001899980B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001825826D0-0x0000000182582850
	// [XID] // 0x000000018999F7B0-0x000000018999F7D0
	public override void SetupView() {} // 0x00000001825830F0-0x0000000182583940
	// [XID] // 0x00000001899A7310-0x00000001899A7330
	protected override void BindViewCallbacks() {} // 0x00000001825821F0-0x00000001825823B0
	// [XID] // 0x00000001899AEC40-0x00000001899AEC60
	private void RequestQuit() {} // 0x0000000182582DF0-0x0000000182582F40
	// [XID] // 0x00000001899B5FA0-0x00000001899B5FC0
	private void RequestRestart() {} // 0x0000000182582A10-0x0000000182582C30
	// [XID] // 0x00000001899BDD00-0x00000001899BDD20
	private void RequestRevive() {} // 0x0000000182582C30-0x0000000182582D90
	// [XID] // 0x00000001899C5420-0x00000001899C5440
	public override void UpdateView() {} // 0x0000000182583940-0x0000000182583CC0
	// [XID] // 0x00000001899CCAF0-0x00000001899CCB10
	protected override void RegisterHandlePacket() {} // 0x0000000182583040-0x00000001825830F0
	// [XID] // 0x00000001899D4130-0x00000001899D4150
	public override bool OnPacket(Packet packet) => default; // 0x0000000182582F40-0x0000000182583040
	// [XID] // 0x00000001899DB700-0x00000001899DB720
	public void RequestDungeonRestart() {} // 0x00000001825824A0-0x00000001825825E0
	// [XID] // 0x00000001899E2E20-0x00000001899E2E40
	public void RequestDungeonRevive() {} // 0x00000001825823B0-0x00000001825824A0
	// [XID] // 0x00000001899EA530-0x00000001899EA550
	private void OnDungeonDieOptionRsp(DungeonDieOptionRsp rsp) {} // 0x00000001825828B0-0x0000000182582A10
}

