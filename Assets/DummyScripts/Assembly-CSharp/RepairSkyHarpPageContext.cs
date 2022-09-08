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

public sealed class RepairSkyHarpPageContext : BasePageContext // TypeDefIndex: 29247
{
	// Fields
	private MonoRepairSkyHarpPage _pageMono; // 0x190
	private uint _questId; // 0x198
	private uint _harpLevel; // 0x19C

	// Constructors
	public RepairSkyHarpPageContext() {} // Dummy constructor
	public RepairSkyHarpPageContext(uint subQuestId) {} // 0x00000001843A2A40-0x00000001843A2B00

	// Methods
	// [XID] // 0x00000001898F7590-0x00000001898F75B0
	public override void SetupView() {} // 0x00000001843A2940-0x00000001843A2A40
	// [XID] // 0x00000001898FECE0-0x00000001898FED00
	protected override void BindViewCallbacks() {} // 0x00000001843A1A50-0x00000001843A1BE0
	// [XID] // 0x0000000189906460-0x0000000189906480
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001843A1E50-0x00000001843A2000
	// [XID] // 0x000000018990DEE0-0x000000018990DF00
	protected override void RegisterHandlePacket() {} // 0x00000001843A2890-0x00000001843A2940
	// [XID] // 0x0000000189915650-0x0000000189915670
	public override bool OnPacket(Packet packet) => default; // 0x00000001843A27A0-0x00000001843A2890
	// [XID] // 0x000000018991D080-0x000000018991D0A0
	private void RefreshView(ref QuestExcelConfigProxy questConfig) {} // 0x00000001843A2000-0x00000001843A2290
	// [XID] // 0x0000000189924930-0x0000000189924950
	private void SetSkyHarpView(uint harpLevel) {} // 0x00000001843A2380-0x00000001843A2510
	// [XID] // 0x000000018992BE80-0x000000018992BEA0
	private void OnRepairBtnClick() {} // 0x00000001843A2290-0x00000001843A2380
	// [XID] // 0x00000001899333B0-0x00000001899333D0
	private void OnQuestListUpdateNotify(Packet packet) {} // 0x00000001843A1BE0-0x00000001843A1D60
	// [XID] // 0x000000018993AF60-0x000000018993AF80
	private void OnQuestFinishNotify() {} // 0x00000001843A2510-0x00000001843A2740
}

