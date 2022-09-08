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
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityExpeditionAvatarBorrowDialog : BaseDialogContext // TypeDefIndex: 29374
{
	// Fields
	public Action<uint, uint, uint, ElementType> OnConfirmBtnClick; // 0x178
	private MonoActivityExpeditionAvatarBorrowDialog _dialogMono; // 0x180
	private const uint maleId = 10000005; // Metadata: 0x00B0F696
	private const uint femaleId = 10000007; // Metadata: 0x00B0F69A
	private List<ElementType> upElements; // 0x188
	private uint _friendUid; // 0x190
	private uint _friendAvatarId; // 0x194
	private MonoAvatarIcon _selectedAvatarMonoIcon; // 0x198
	private ShowAvatarData _selectedAvatarData; // 0x1A0
	private MonoExplorationMark monoMark; // 0x1D8
	private float upCoeff; // 0x1E0
	private float basicProb; // 0x1E4
	private List<ShowAvatarData> showAvatarDataList; // 0x1E8
	private Dictionary<uint, ElementType> _avatarConfigIdToElemTypeDic; // 0x1F0
	private List<Tuple<uint, float>> _bonusProbList; // 0x1F8

	// Properties
	private Dictionary<uint, ElementType> avatarConfigIdToElemTypeDic { /* [XID] */ /* 0x0000000189978650-0x0000000189978670 */ get => default; } // 0x000000018325F260-0x000000018325F550 

	// Nested types
	private struct ShowAvatarData // TypeDefIndex: 29375
	{
		// Fields
		public uint uid; // 0x00
		public uint avatarID; // 0x04
		public uint level; // 0x08
		public ElementType elementType; // 0x0C
		public string avatarIconName; // 0x10
		public string nickName; // 0x18
		public string remarkName; // 0x20
		public uint headPortraitId; // 0x28
		public uint playerLevel; // 0x2C
		public string onlineId; // 0x30
	}

	// Constructors
	public ActivityExpeditionAvatarBorrowDialog() {} // 0x0000000183261A40-0x0000000183261B30
	public ActivityExpeditionAvatarBorrowDialog(MonoExplorationMark monoMark, uint friendUid, uint friendAvatarId, Action<uint, uint, uint, ElementType> OnConfirmBtnClick, float basicProb) {} // 0x0000000183261B30-0x0000000183261CF0

	// Methods
	// [XID] // 0x000000018995A1B0-0x000000018995A1D0
	public override void SetupView() {} // 0x0000000183261850-0x0000000183261A40
	// [XID] // 0x0000000189961BE0-0x0000000189961C00
	private void AutoSelectAvatar() {} // 0x00000001832614B0-0x0000000183261760
	// [XID] // 0x0000000189969270-0x0000000189969290
	public override void ClearView() {} // 0x000000018325EF50-0x000000018325F000
	// [XID] // 0x0000000189970D10-0x0000000189970D30
	protected override void BindViewCallbacks() {} // 0x000000018325ECE0-0x000000018325EF50
	// [XID] // 0x000000018997F770-0x000000018997F790
	private void RefreshAvatarGridScroller() {} // 0x000000018325F6E0-0x00000001832603B0
	// [XID] // 0x00000001899870C0-0x00000001899870E0
	private void InitAvatarGridScroll(Transform trans, int index) {} // 0x00000001832604E0-0x0000000183260930
	// [XID] // 0x000000018998EB90-0x000000018998EBB0
	private void OnAvatarIconClick(ShowAvatarData avatarData) {} // 0x0000000183260E50-0x00000001832614B0
	// [XID] // 0x0000000189996770-0x0000000189996790
	private void OnConfirm() {} // 0x000000018325F140-0x000000018325F260
	// [XID] // 0x000000018999E290-0x000000018999E2B0
	private void OnCancel() {} // 0x000000018325F000-0x000000018325F0B0
	// [XID] // 0x00000001899A5C50-0x00000001899A5C70
	public float CalculateBonusProb(uint level, bool isUp) => default; // 0x0000000183260990-0x0000000183260E50
	// [XID] // 0x00000001899AD310-0x00000001899AD330
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001832603B0-0x00000001832604E0
}

