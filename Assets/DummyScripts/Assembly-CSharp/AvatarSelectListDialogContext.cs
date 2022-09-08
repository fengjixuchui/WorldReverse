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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSelectListDialogContext : BaseDialogContext // TypeDefIndex: 28817
{
	// Fields
	private MonoCookAvatarSelect _pageMono; // 0x178
	private List<uint> _avatarList; // 0x180
	private List<uint> _bonusList; // 0x188
	private List<uint> _normalList; // 0x190
	private Dictionary<uint, object> _skillBonusMap; // 0x198
	private Dictionary<uint, ulong> _avatarGuidMap; // 0x1A0
	private uint _avatarId; // 0x1A8
	private uint _toSelectAvatarId; // 0x1AC
	private uint _bonusParam; // 0x1B0
	private int _toSelectAvatarIndex; // 0x1B4
	public AvatarSelectListMode currMode; // 0x1B8
	private UnityAction<ulong> selectCallback; // 0x1C0
	private UnityAction closeDialogCallback; // 0x1C8
	private static readonly uint _bagItemSelectAudio; // 0x00

	// Nested types
	public enum AvatarSelectListMode // TypeDefIndex: 28818
	{
		None = 0,
		Cook = 1,
		Forge = 2,
		Alchemist = 3,
		Exploration = 4
	}

	// Constructors
	public AvatarSelectListDialogContext() {} // Dummy constructor
	public AvatarSelectListDialogContext(uint avatarId) {} // 0x0000000181C43E60-0x0000000181C44000
	static AvatarSelectListDialogContext() {} // 0x0000000181C43DD0-0x0000000181C43E60

	// Methods
	// [XID] // 0x000000018967E8F0-0x000000018967E910
	public void SetMode(AvatarSelectListMode mode, uint bonusParam = 0 /* Metadata: 0x00B0E75E */, UnityAction<ulong> selectCallback = null, UnityAction closeCallback = null) {} // 0x0000000181C418E0-0x0000000181C419E0
	// [XID] // 0x00000001896861A0-0x00000001896861C0
	public override void SetupView() {} // 0x0000000181C43CB0-0x0000000181C43DD0
	// [XID] // 0x000000018968DF90-0x000000018968DFB0
	protected override void BindViewCallbacks() {} // 0x0000000181C419E0-0x0000000181C41B80
	// [XID] // 0x00000001896958E0-0x0000000189695900
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181C42420-0x0000000181C426F0
	// [XID] // 0x000000018969CF70-0x000000018969CF90
	private void SetupAvatarSelectView() {} // 0x0000000181C43A30-0x0000000181C43CB0
	// [XID] // 0x00000001896A4240-0x00000001896A4260
	private void RefreshAvatarList(uint bounusParam) {} // 0x0000000181C426F0-0x0000000181C42AD0
	// [XID] // 0x00000001896AB800-0x00000001896AB820
	private int CheckIsBonusAvatar(uint bonusParam, AvatarDataItem avatarData) => default; // 0x0000000181C43380-0x0000000181C43460
	// [XID] // 0x00000001896B2A30-0x00000001896B2A50
	public int GetAvatarBonusSkillId(uint bonusParam, AvatarDataItem avatarData) => default; // 0x0000000181C438E0-0x0000000181C439D0
	// [XID] // 0x00000001896BA1E0-0x00000001896BA200
	public int GetAvatarBonusExpeditionSkillId(uint cityID, AvatarDataItem avatarData) => default; // 0x0000000181C42FF0-0x0000000181C43220
	// [XID] // 0x00000001896C1430-0x00000001896C1450
	private string GetExploringHint(AvatarDataItem avatarData) => default; // 0x0000000181C436F0-0x0000000181C438E0
	// [XID] // 0x00000001896C8AF0-0x00000001896C8B10
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x0000000181C42AD0-0x0000000181C42FF0
	// [XID] // 0x00000001896D0520-0x00000001896D0540
	private void OnAvatarRowClick(int index) {} // 0x0000000181C41EC0-0x0000000181C423C0
	// [XID] // 0x00000001896D79E0-0x00000001896D7A00
	private void OnSelectAvatar() {} // 0x0000000181C41C20-0x0000000181C41CD0
	// [XID] // 0x00000001896DF280-0x00000001896DF2A0
	private void SetSelectAvatar() {} // 0x0000000181C43220-0x0000000181C43380
	// [XID] // 0x00000001896E6670-0x00000001896E6690
	private void SetAvatarBonusView() {} // 0x0000000181C41B80-0x0000000181C41C20
	// [XID] // 0x00000001896EDBC0-0x00000001896EDBE0
	public override void CloseDialog() {} // 0x0000000181C41CD0-0x0000000181C41D90
	// [XID] // 0x00000001896F5430-0x00000001896F5450
	private void CloseDialogWithFade() {} // 0x0000000181C43530-0x0000000181C436F0
	// [XID] // 0x00000001896FCC30-0x00000001896FCC50
	private void CloseAvatarSelectPanel() {} // 0x0000000181C41D90-0x0000000181C41E30
}

