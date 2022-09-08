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

public sealed class ActivitySubPage_BlessingCamera : BaseSubPageContext // TypeDefIndex: 29381
{
	// Fields
	private MonoActivityBlessingCameraSubPage _pageMono; // 0x178
	private uint _activityId; // 0x180
	private List<uint> _albumList; // 0x188
	private MapField<uint, uint> _photoMap; // 0x190
	private ActivityInfo _activityInfo; // 0x198

	// Properties
	public static bool blessingCameraSubPageOpened { /* [XID] */ /* 0x0000000189618C50-0x0000000189618C90 */ get; /* [XID] */ /* 0x0000000189622F20-0x0000000189622F60 */ private set; } // 0x00000001820F9770-0x00000001820F97D0 0x00000001820F99D0-0x00000001820F9A30

	// Constructors
	public ActivitySubPage_BlessingCamera() {} // Dummy constructor
	public ActivitySubPage_BlessingCamera(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x00000001820FA9B0-0x00000001820FAAE0

	// Methods
	// [XID] // 0x000000018962D880-0x000000018962D8A0
	public override void SetupView() {} // 0x00000001820FA630-0x00000001820FA9B0
	// [XID] // 0x0000000189635400-0x0000000189635420
	protected override void BindViewCallbacks() {} // 0x00000001820F8B50-0x00000001820F8D60
	// [XID] // 0x000000018963CAA0-0x000000018963CAC0
	protected override void BindRedPoints() {} // 0x00000001820F8A10-0x00000001820F8B50
	// [XID] // 0x0000000189644120-0x0000000189644140
	protected override void OnEnable() {} // 0x00000001820FA2E0-0x00000001820FA3B0
	// [XID] // 0x000000018964B8D0-0x000000018964B8F0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001820FA3B0-0x00000001820FA4B0
	// [XID] // 0x0000000189653060-0x0000000189653080
	private void Refresh() {} // 0x00000001820F8310-0x00000001820F88A0
	// [XID] // 0x000000018965A720-0x000000018965A740
	private void SetScanStopTime() {} // 0x00000001820FA4B0-0x00000001820FA630
	// [XID] // 0x0000000189661D50-0x0000000189661D70
	private void SetActivityStopTime() {} // 0x00000001820FA090-0x00000001820FA1F0
	// [XID] // 0x0000000189669930-0x0000000189669950
	private void RefreshAlbum() {} // 0x00000001820F9A30-0x00000001820F9D50
	// [XID] // 0x0000000189671460-0x0000000189671480
	private void RefreshPhoto(Transform trans, int index) {} // 0x00000001820F9170-0x00000001820F9330
	// [XID] // 0x0000000189678D20-0x0000000189678D40
	private void OnClickDescBtn() {} // 0x00000001820F8900-0x00000001820F8A10
	// [XID] // 0x0000000189680430-0x0000000189680450
	private void OnClickRewardBtn() {} // 0x00000001820F9F00-0x00000001820FA090
	// [XID] // 0x0000000189687F30-0x0000000189687F50
	private void OnClickSwitchBtn() {} // 0x00000001820F9D50-0x00000001820F9F00
	// [XID] // 0x000000018968F990-0x000000018968F9B0
	private void OnClickGotoBtn() {} // 0x00000001820F9420-0x00000001820F9770
	// [XID] // 0x0000000189697390-0x00000001896973B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001820F9830-0x00000001820F99D0
	// [XID] // 0x000000018969E8E0-0x000000018969E900
	private void FocusOnSubPage(bool focusOnSubPage) {} // 0x00000001820F8D60-0x00000001820F9170
}

