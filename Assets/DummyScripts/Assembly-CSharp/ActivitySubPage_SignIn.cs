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

public sealed class ActivitySubPage_SignIn : BaseSubPageContext // TypeDefIndex: 29426
{
	// Fields
	private MonoSignInContext _pageMono; // 0x178
	private string SIGNIN_PREFAB_PATH; // 0x180
	private uint _activityId; // 0x188
	private SignInInfo _signInfo; // 0x190
	private int _signInItemSlot; // 0x198

	// Constructors
	public ActivitySubPage_SignIn() {} // Dummy constructor
	public ActivitySubPage_SignIn(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000184300B40-0x0000000184300E00

	// Methods
	// [XID] // 0x0000000189666480-0x00000001896664A0
	protected override void BindViewCallbacks() {} // 0x00000001842FF570-0x00000001842FF610
	// [XID] // 0x000000018966DC60-0x000000018966DC80
	public override void SetupView() {} // 0x00000001843009F0-0x0000000184300B40
	// [XID] // 0x0000000189675A80-0x0000000189675AA0
	private void Refresh() {} // 0x00000001842FEA50-0x00000001842FF1E0
	// [XID] // 0x000000018967D330-0x000000018967D350
	private void OnClickRewadIcon(int index, uint id) {} // 0x0000000184300240-0x00000001843003F0
	// [XID] // 0x0000000189684A00-0x0000000189684A20
	public void RefreshSignInView() {} // 0x00000001843008F0-0x00000001843009F0
	// [XID] // 0x000000018968C5D0-0x000000018968C5F0
	private void SetSignInInfo(SignInInfo signInfo) {} // 0x00000001842FF780-0x00000001842FFB30
	// [XID] // 0x0000000189694020-0x0000000189694040
	public override bool OnNotify(Notify ntf) => default; // 0x00000001843007D0-0x00000001843008F0
	// [XID] // 0x000000018969B590-0x000000018969B5B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001842FFDA0-0x00000001843000D0
	// [XID] // 0x00000001896A2D10-0x00000001896A2D30
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x00000001843000D0-0x0000000184300240
	// [XID] // 0x00000001896AA1C0-0x00000001896AA1E0
	private void RefreshCurrentItem(bool clear) {} // 0x00000001842FF610-0x00000001842FF780
	// [XID] // 0x00000001896B0FA0-0x00000001896B0FC0
	private void SetSigninConfirmTextBySlot() {} // 0x00000001842FF260-0x00000001842FF570
	// [XID] // 0x00000001896B8BD0-0x00000001896B8BF0
	private void SetSlot(int index) {} // 0x00000001843005B0-0x0000000184300740
	// [XID] // 0x00000001896BFDF0-0x00000001896BFE10
	private void NextSlot() {} // 0x00000001842FFBC0-0x00000001842FFD40
	// [XID] // 0x00000001896C76F0-0x00000001896C7710
	private void PreSlot() {} // 0x00000001843003F0-0x0000000184300550
}

