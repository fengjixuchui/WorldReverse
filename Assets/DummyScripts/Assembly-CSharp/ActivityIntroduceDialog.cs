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

public sealed class ActivityIntroduceDialog : BaseDialogContext // TypeDefIndex: 29512
{
	// Fields
	private MonoActivityIntroduceDialog _dialogMono; // 0x178
	private string dialogTitle; // 0x180
	private string dialogDesc; // 0x188
	private SimpleSafeUInt32[] _avatarUpId; // 0x190
	private List<AsterAvatarUpExcelConfig> avatarList; // 0x198
	private List<UpAvatar> _upAvatarList; // 0x1A0
	private SimpleSafeUInt32[] avatarIdList; // 0x1A8

	// Nested types
	private struct UpAvatar // TypeDefIndex: 29513
	{
		// Fields
		public string description; // 0x00
		public SimpleSafeUInt32[] upAvatarIds; // 0x08
	}

	// Constructors
	public ActivityIntroduceDialog() {} // Dummy constructor
	public ActivityIntroduceDialog(string title, string desc, SimpleSafeUInt32[] avatarUpId) {} // 0x00000001819266F0-0x0000000181926830
	public ActivityIntroduceDialog(NewActivityType activityType) {} // 0x0000000181926540-0x00000001819266F0

	// Methods
	// [XID] // 0x0000000189873B20-0x0000000189873B40
	public override void SetupView() {} // 0x0000000181926460-0x0000000181926540
	// [XID] // 0x000000018987B5D0-0x000000018987B5F0
	protected override void BindViewCallbacks() {} // 0x0000000181925740-0x0000000181925850
	// [XID] // 0x0000000189882770-0x0000000189882790
	private void ResetData() {} // 0x0000000181926340-0x0000000181926400
	// [XID] // 0x0000000189889F40-0x0000000189889F60
	private void RefreshData() {} // 0x00000001819258E0-0x0000000181925BB0
	// [XID] // 0x0000000189891380-0x00000001898913A0
	private void RefreshView() {} // 0x0000000181925EB0-0x0000000181926130
	// [XID] // 0x00000001898989F0-0x0000000189898A10
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x0000000181926130-0x0000000181926340
	// [XID] // 0x000000018989FC10-0x000000018989FC30
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x00000001819255D0-0x0000000181925740
	// [XID] // 0x00000001898A75E0-0x00000001898A7600
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181925C10-0x0000000181925EB0
}

