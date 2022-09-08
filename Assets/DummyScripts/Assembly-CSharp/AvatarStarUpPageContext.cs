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

internal sealed class AvatarStarUpPageContext : BasePageContext // TypeDefIndex: 28823
{
	// Fields
	private MonoAvatarStarUpPage _pageMono; // 0x190
	private AvatarStarUpUISceneComponent _uiSceneComp; // 0x198
	private bool _onlyTips; // 0x1A0
	private ElementType _elemType; // 0x1A4
	private ShopMaterial _needMaterial; // 0x1A8
	private AvatarDataItem _avatarData; // 0x1B0
	private uint _currBreakLevel; // 0x1B8
	private uint _currLevel; // 0x1BC
	private uint _currMaxLevel; // 0x1C0
	private uint _postMaxLevel; // 0x1C4
	private int _currVoiceID; // 0x1C8
	private AvatarPromoteExcelConfig _currBreakConfig; // 0x1D0
	private AvatarPromoteExcelConfig _postBreakConfig; // 0x1D8
	private List<PropertyChange> _propertyChangeList; // 0x1E0
	private List<uint> _unlockSkillGroupList; // 0x1E8
	private List<FightPropType> _briefInfo; // 0x1F0

	// Constructors
	public AvatarStarUpPageContext() {} // Dummy constructor
	public AvatarStarUpPageContext(AvatarDataItem avatarData, bool onlyTips = false /* Metadata: 0x00B0E776 */) {} // 0x000000018152C070-0x000000018152C200

	// Methods
	// [XID] // 0x0000000189892D70-0x0000000189892D90
	public override void SetupView() {} // 0x000000018152BF50-0x000000018152C070
	// [XID] // 0x000000018989A3F0-0x000000018989A410
	private void SetAvatarNameAndElement() {} // 0x000000018152B960-0x000000018152BCB0
	// [XID] // 0x00000001898A1610-0x00000001898A1630
	protected override void BindViewCallbacks() {} // 0x0000000181529EB0-0x000000018152A010
	// [XID] // 0x00000001898A8E80-0x00000001898A8EA0
	private void SetResult() {} // 0x000000018152AF40-0x000000018152B440
	// [XID] // 0x00000001898B0800-0x00000001898B0820
	private void Refresh() {} // 0x0000000181529120-0x0000000181529EB0
	// [XID] // 0x00000001898B7E30-0x00000001898B7E50
	public override void ClearView() {} // 0x000000018152A110-0x000000018152A1B0
	// [XID] // 0x00000001898BF4E0-0x00000001898BF500
	public override bool OnNotify(Notify ntf) => default; // 0x000000018152BDA0-0x000000018152BF50
	// [XID] // 0x00000001898C6DA0-0x00000001898C6DC0
	private void CheckIsOnlyShowTips() {} // 0x000000018152B840-0x000000018152B960
	// [XID] // 0x00000001898CE380-0x00000001898CE3A0
	private void OnClickStarUpBtn() {} // 0x000000018152AD80-0x000000018152AE20
	// [XID] // 0x00000001898D5DD0-0x00000001898D5DF0
	private void OnClickCloseBtn() {} // 0x000000018152AE20-0x000000018152AF40
	// [XID] // 0x00000001898DDAC0-0x00000001898DDAE0
	private void RefreshCoinNum() {} // 0x000000018152A010-0x000000018152A110
	// [XID] // 0x00000001898E53F0-0x00000001898E5410
	private void RequestBreakThrough() {} // 0x000000018152B440-0x000000018152B840
	// [XID] // 0x00000001898ECB40-0x00000001898ECB60
	private void DoShowStarUp() {} // 0x000000018152ACD0-0x000000018152AD80
	// [XID] // 0x00000001898F4530-0x00000001898F4550
	private void ShowBreakThroughResult(ulong avatarGuid, float lastValue, float value) {} // 0x000000018152A240-0x000000018152A720
	// [XID] // 0x00000001898FBCC0-0x00000001898FBCE0
	public void StopAudio() {} // 0x000000018152ABD0-0x000000018152ACD0
	// [XID] // 0x0000000189903730-0x0000000189903750
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018152A780-0x000000018152AB70
}

