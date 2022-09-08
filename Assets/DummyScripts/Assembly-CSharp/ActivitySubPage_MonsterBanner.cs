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

public class ActivitySubPage_MonsterBanner : BaseSubPageContext // TypeDefIndex: 29408
{
	// Fields
	protected uint _activityId; // 0x178
	protected MonoActivityMonsterBanner _pageMono; // 0x180
	protected ConditionButtonComponent _gotoBtn; // 0x188
	protected RewardPreviewComponent _rewardPreview; // 0x190

	// Constructors
	public ActivitySubPage_MonsterBanner() {} // Dummy constructor
	public ActivitySubPage_MonsterBanner(uint activityId, BasePageContext parent, Transform mountTrans) {} // 0x00000001827492E0-0x00000001827493D0

	// Methods
	// [XID] // 0x0000000189750470-0x0000000189750490
	protected virtual ConditionButtonComponent.ITemplate GetBtnTemplate() => default; // 0x0000000182748E30-0x0000000182748ED0
	// [XID] // 0x0000000189757A10-0x0000000189757A30
	protected virtual uint GetRewardPreviewId() => default; // 0x0000000182748910-0x00000001827489B0
	// [XID] // 0x000000018975F430-0x000000018975F450
	public override void SetupView() {} // 0x00000001827491A0-0x00000001827492E0
	// [XID] // 0x0000000189766920-0x0000000189766940
	protected virtual void SetupGotoBtn() {} // 0x0000000182749060-0x00000001827491A0
	// [XID] // 0x000000018976DED0-0x000000018976DEF0
	protected virtual void SetupRewardPreview() {} // 0x0000000182748ED0-0x0000000182749000
	// [XID] // 0x0000000189775630-0x0000000189775650
	protected override void BindViewCallbacks() {} // 0x0000000182748790-0x0000000182748910
	// [XID] // 0x000000018977CE90-0x000000018977CEB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182748AA0-0x0000000182748BF0
	// [XID] // 0x00000001897848D0-0x00000001897848F0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000182748BF0-0x0000000182748E30
}

