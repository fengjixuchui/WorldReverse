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

public sealed class WorldLevelChangeDialogContext : BaseDialogContext // TypeDefIndex: 30156
{
	// Fields
	public string title; // 0x178
	public string desc; // 0x180
	public uint curLv; // 0x188
	public uint nextLv; // 0x18C
	public string next; // 0x190
	public string cur; // 0x198
	public string tips; // 0x1A0
	public PlayerLevelSurmountWidgetContext.AdjustType adjustType; // 0x1A8
	private bool isCD; // 0x1AC
	private MonoWorldLevelChangeDialog _pageMono; // 0x1B0
	private int actionButtonChildrenNum; // 0x1B8

	// Constructors
	public WorldLevelChangeDialogContext() {} // 0x00000001812F41C0-0x00000001812F4280

	// Methods
	// [XID] // 0x00000001899361F0-0x0000000189936210
	public override void SetupView() {} // 0x00000001812F3990-0x00000001812F3F90
	// [XID] // 0x000000018993DC10-0x000000018993DC30
	public override void ClearView() {} // 0x00000001812F3250-0x00000001812F3300
	// [XID] // 0x00000001899453A0-0x00000001899453C0
	protected override void BindViewCallbacks() {} // 0x00000001812F2C80-0x00000001812F2E70
	// [XID] // 0x000000018994C860-0x000000018994C880
	public override void UpdateView() {} // 0x00000001812F3F90-0x00000001812F41C0
	// [XID] // 0x0000000189953F60-0x0000000189953F80
	private void RefreshActionButton() {} // 0x00000001812F2940-0x00000001812F2AD0
	// [XID] // 0x000000018995B7C0-0x000000018995B7E0
	private bool isAvailable() => default; // 0x00000001812F2E70-0x00000001812F3250
	// [XID] // 0x00000001899633E0-0x0000000189963400
	private void OnBtnOKClick() {} // 0x00000001812F2AD0-0x00000001812F2C80
	// [XID] // 0x000000018996A720-0x000000018996A740
	private void OnBtnCloseClick() {} // 0x00000001812F3300-0x00000001812F33B0
	// [XID] // 0x0000000189972480-0x00000001899724A0
	private void OnBGClick() {} // 0x00000001812F3880-0x00000001812F3930
	// [XID] // 0x0000000189979C60-0x0000000189979C80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001812F34A0-0x00000001812F37C0
}

