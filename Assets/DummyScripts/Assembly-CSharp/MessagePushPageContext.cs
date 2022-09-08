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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MessagePushPageContext : BasePageContext // TypeDefIndex: 29200
{
	// Fields
	private MonoMessagePushPage _pageMono; // 0x190
	private List<PushTipsStruct> _pushTipsList; // 0x198
	private int _selectedIndex; // 0x1A0
	private SimpleSafeUInt32[] _tutorialDetailList; // 0x1A8
	private int _selectedTutorialIndex; // 0x1B0
	private uint _showTipsID; // 0x1B4
	private bool _useBgImg; // 0x1B8

	// Nested types
	public struct PushTipsStruct // TypeDefIndex: 29201
	{
		// Fields
		public uint id; // 0x00
		public uint state; // 0x04
	}

	// Constructors
	public MessagePushPageContext() {} // Dummy constructor
	public MessagePushPageContext(uint showTipsID = 0 /* Metadata: 0x00B0EDD8 */, bool useBgImg = true /* Metadata: 0x00B0EDDC */) {} // 0x0000000183A13700-0x0000000183A137F0

	// Methods
	// [XID] // 0x0000000189B14880-0x0000000189B148A0
	public override void SetupView() {} // 0x0000000183A13610-0x0000000183A13700
	// [XID] // 0x0000000189B1C1A0-0x0000000189B1C1C0
	protected override void BindViewCallbacks() {} // 0x0000000183A11B80-0x0000000183A11D80
	// [XID] // 0x0000000189B23830-0x0000000189B23850
	private void RefreshPushTipsList() {} // 0x0000000183A11F30-0x0000000183A12060
	// [XID] // 0x0000000189B2AAD0-0x0000000189B2AAF0
	private void RefreshPushTipView() {} // 0x0000000183A11D80-0x0000000183A11F30
	// [XID] // 0x0000000189B32000-0x0000000189B32020
	private void RefreshPushTipsTab(Transform trans, int index) {} // 0x0000000183A12580-0x0000000183A12800
	// [XID] // 0x0000000189B397C0-0x0000000189B397E0
	private void OnPushTipsTabClick(int index) {} // 0x0000000183A13150-0x0000000183A13610
	// [XID] // 0x0000000189B41170-0x0000000189B41190
	private void RefreshTutorialDetail(uint pushTipsId) {} // 0x0000000183A120F0-0x0000000183A12380
	// [XID] // 0x0000000189B48A60-0x0000000189B48A80
	private void ShowTutorialDetial(int index) {} // 0x0000000183A12B20-0x0000000183A130F0
	// [XID] // 0x0000000189B501F0-0x0000000189B50210
	private void OnNextBtnClick() {} // 0x0000000183A11860-0x0000000183A11AB0
	// [XID] // 0x0000000189B57A20-0x0000000189B57A40
	private void OnPrevBtnClick() {} // 0x0000000183A11AB0-0x0000000183A11B80
	// [XID] // 0x0000000189B5F390-0x0000000189B5F3B0
	private void CheckRewardTipsShow() {} // 0x0000000183A12800-0x0000000183A12B20
	// [XID] // 0x0000000189B66980-0x0000000189B669A0
	private void ScrollDescText(float delta) {} // 0x0000000183A116D0-0x0000000183A11860
	// [XID] // 0x0000000189B6DEE0-0x0000000189B6DF00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183A123E0-0x0000000183A12580
}

