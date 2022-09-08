/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarPromotionDialogContext : BaseDialogContext // TypeDefIndex: 28812
{
	// Fields
	private int _prevBreakLevel; // 0x178
	private int _currBreakLevel; // 0x17C
	private int _currLevel; // 0x180
	private int _currMaxLevel; // 0x184
	private List<PropertyChange> _propertyChanges; // 0x188
	private List<uint> _unlockSkillGroupList; // 0x190
	private ScrollRect _scroller; // 0x198

	// Properties
	public List<PropertyChange> propertyChanges { /* [XID] */ /* 0x0000000189B0BB30-0x0000000189B0BB50 */ set {} } // 0x000000018247FA80-0x000000018247FB70
	public List<uint> unlockSkillGroupList { /* [XID] */ /* 0x0000000189B13040-0x0000000189B13060 */ set {} } // 0x000000018247FCA0-0x000000018247FD90

	// Constructors
	public AvatarPromotionDialogContext() {} // 0x0000000182480280-0x00000001824804A0

	// Methods
	// [XID] // 0x0000000189AFCB10-0x0000000189AFCB30
	public void SetBreakLevel(int prevBreakLevel, int currBreakLevel) {} // 0x000000018247FB70-0x000000018247FC40
	// [XID] // 0x0000000189B04290-0x0000000189B042B0
	public void SetLevel(int currLevel, int currMaxLevel) {} // 0x000000018247FD90-0x000000018247FE60
	// [XID] // 0x0000000189B1A710-0x0000000189B1A730
	public override void SetupView() {} // 0x000000018247FE60-0x0000000182480280
	// [XID] // 0x0000000189B21D00-0x0000000189B21D20
	protected override void BindViewCallbacks() {} // 0x000000018247F1D0-0x000000018247F3A0
	// [XID] // 0x0000000189B293C0-0x0000000189B293E0
	private void RefreshPropertyItem(Transform trans, int index) {} // 0x000000018247F3A0-0x000000018247F770
	// [XID] // 0x0000000189B307D0-0x0000000189B307F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018247F860-0x000000018247FA80
}

