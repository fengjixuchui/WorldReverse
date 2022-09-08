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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelGachaUpDetailDialog : BaseDialogContext // TypeDefIndex: 29553
{
	// Fields
	private MonoGachaUpDetailDialog _dialogMono; // 0x178
	private InLevelGachaGroupContext _gachaContext; // 0x180
	private string _titleTextMapId; // 0x188
	private int _star5Count; // 0x190
	private int _star5LineCount; // 0x194
	private int _star4Count; // 0x198
	private int _star4LineCount; // 0x19C
	private int _curItemIndex; // 0x1A0
	private int _curLineIndex; // 0x1A4
	private bool _curIn5Star; // 0x1A8
	private int _starCountPerLine; // 0x1AC

	// Constructors
	public InLevelGachaUpDetailDialog() {} // Dummy constructor
	public InLevelGachaUpDetailDialog(InLevelGachaGroupContext gachaContext, string textMapId) {} // 0x00000001833724A0-0x00000001833725A0

	// Methods
	// [XID] // 0x000000018977E5C0-0x000000018977E5E0
	public override void SetupView() {} // 0x00000001833723C0-0x00000001833724A0
	// [XID] // 0x0000000189785D50-0x0000000189785D70
	protected override void BindViewCallbacks() {} // 0x00000001833710E0-0x0000000183371200
	// [XID] // 0x000000018978D470-0x000000018978D490
	private void Refresh() {} // 0x0000000183370980-0x0000000183370F30
	// [XID] // 0x00000001897947F0-0x0000000189794810
	private int GetUpListCount(GachaItemParentType parentType) => default; // 0x0000000183372010-0x00000001833721B0
	// [XID] // 0x000000018979CC80-0x000000018979CCA0
	private uint GetItemId(int index, GachaItemParentType parentType) => default; // 0x0000000183370F30-0x00000001833710E0
	// [XID] // 0x00000001897A40E0-0x00000001897A4100
	private void RefreshStar5UPItem(Transform trans, int index) {} // 0x0000000183370880-0x0000000183370980
	// [XID] // 0x00000001897AB640-0x00000001897AB660
	private void RefreshStar4UPItem(Transform trans, int index) {} // 0x0000000183371F10-0x0000000183372010
	// [XID] // 0x00000001897B3490-0x00000001897B34B0
	private void RefreshItem(MonoBagProxySlot itemSlot, uint itemId) {} // 0x00000001833713B0-0x00000001833715B0
	// [XID] // 0x00000001897BB370-0x00000001897BB390
	private void OnStar5SelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x00000001833721B0-0x0000000183372360
	// [XID] // 0x00000001897C2B70-0x00000001897C2B90
	private void OnStar4SelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x0000000183371200-0x00000001833713B0
	// [XID] // 0x00000001897CA3D0-0x00000001897CA3F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001833716A0-0x0000000183371F10
}

