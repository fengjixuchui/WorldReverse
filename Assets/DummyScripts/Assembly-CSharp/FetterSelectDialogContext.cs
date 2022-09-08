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

public sealed class FetterSelectDialogContext : BaseDialogContext // TypeDefIndex: 29542
{
	// Fields
	private MonoFetterSelectDialog _dialogMono; // 0x178
	private AvatarDataItem _avatarItem; // 0x180
	private List<Fetter.Data> _currentList; // 0x188
	private List<Tuple<string, bool>> _unlockTipsList; // 0x190
	private HashSet<uint> redpointSet; // 0x198
	private uint _avatarID; // 0x1A0
	private Fetter.FetterType _currentType; // 0x1A4
	private int _currentIndex; // 0x1A8
	private VoiceState _voiceState; // 0x1B0
	private Action _closeDialogCallBack; // 0x1B8

	// Nested types
	private class VoiceState // TypeDefIndex: 29543
	{
		// Fields
		private int _currPlayingIndex; // 0x10
		private int _currVoiceID; // 0x14

		// Properties
		public int CurrentPlayingIndex { /* [XID] */ /* 0x00000001896CBB90-0x00000001896CBBB0 */ get => default; } // 0x0000000185033810-0x00000001850338B0 
		public int CurrentVoiceID { /* [XID] */ /* 0x00000001896D2E70-0x00000001896D2E90 */ get => default; } // 0x0000000185033770-0x0000000185033810 

		// Constructors
		public VoiceState() {} // 0x0000000185033960-0x00000001850339D0

		// Methods
		// [XID] // 0x00000001896B5E90-0x00000001896B5EB0
		public bool IsPlaying() => default; // 0x00000001850338B0-0x0000000185033960
		// [XID] // 0x00000001896BD070-0x00000001896BD090
		public void SetCurrent(int listIndex, int voiceID) {} // 0x00000001850336B0-0x0000000185033770
		// [XID] // 0x00000001896C44F0-0x00000001896C4510
		public void ClearCurrent() {} // 0x0000000185033600-0x00000001850336B0
	}

	// Constructors
	public FetterSelectDialogContext() {} // Dummy constructor
	public FetterSelectDialogContext(Fetter.FetterType type, AvatarDataItem avatarItem, Action closeDialogCallBack) {} // 0x0000000185017FA0-0x0000000185018260

	// Methods
	// [XID] // 0x0000000189611240-0x0000000189611260
	public override void SetupView() {} // 0x0000000185017B90-0x0000000185017FA0
	// [XID] // 0x0000000189618C10-0x0000000189618C30
	private void SetCV() {} // 0x0000000185017440-0x00000001850176B0
	// [XID] // 0x0000000189620140-0x0000000189620160
	public static string GetCVText(FetterInfoExcelConfig config) => default; // 0x0000000185015890-0x0000000185015A90
	// [XID] // 0x00000001896275B0-0x00000001896275D0
	private void RefreshDataItem(Transform trans, int index) {} // 0x0000000185015D40-0x0000000185015F80
	// [XID] // 0x000000018962F0D0-0x000000018962F0F0
	private void OnItemClicked(int index) {} // 0x0000000185015F80-0x0000000185016070
	// [XID] // 0x0000000189636A70-0x0000000189636A90
	private void OnItemSelected(int index) {} // 0x0000000185015A90-0x0000000185015B80
	// [XID] // 0x000000018963DFA0-0x000000018963DFC0
	private void OnItemConfirmed() {} // 0x0000000185015370-0x0000000185015530
	// [XID] // 0x0000000189645930-0x0000000189645950
	private void SetItemSelected(bool active) {} // 0x0000000185016640-0x0000000185016840
	// [XID] // 0x000000018964D140-0x000000018964D160
	private MonoFetterInfoListRow GetCurrentScrollItemMonoByIndex(int index) => default; // 0x0000000185017980-0x0000000185017B30
	// [XID] // 0x00000001896548E0-0x0000000189654900
	private void RefreshContent() {} // 0x0000000185016A40-0x0000000185016F70
	// [XID] // 0x000000018965BFD0-0x000000018965BFF0
	private void RefreshUnlockTips(Transform trans, int index) {} // 0x0000000185016100-0x00000001850163A0
	// [XID] // 0x0000000189663650-0x0000000189663670
	protected override void BindViewCallbacks() {} // 0x0000000185015530-0x0000000185015640
	// [XID] // 0x000000018966AFD0-0x000000018966AFF0
	private void OnCloseButtonClicked() {} // 0x00000001850151B0-0x0000000185015280
	// [XID] // 0x0000000189672BD0-0x0000000189672BF0
	private void SetAllRedPointDone() {} // 0x0000000185017290-0x0000000185017440
	// [XID] // 0x000000018967A2D0-0x000000018967A2F0
	private void CheckNewRedPointOnSelected(int index) {} // 0x0000000185015B80-0x0000000185015D40
	// [XID] // 0x0000000189681B00-0x0000000189681B20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000185016400-0x0000000185016640
	// [XID] // 0x00000001896895B0-0x00000001896895D0
	private void ScrollContent(float delta) {} // 0x0000000185016840-0x0000000185016A40
	// [XID] // 0x00000001896911D0-0x00000001896911F0
	private void RefreshPS4PlayButton() {} // 0x00000001850176B0-0x0000000185017980
	// [XID] // 0x00000001896989C0-0x00000001896989E0
	public void Play() {} // 0x0000000185016F70-0x0000000185017290
	// [XID] // 0x000000018969FDF0-0x000000018969FE10
	public void TryStop() {} // 0x0000000185014FA0-0x00000001850151B0
	// [XID] // 0x00000001896A7030-0x00000001896A7050
	private void VoiceStopCallBack(int voiceId) {} // 0x0000000185015280-0x0000000185015370
	// [XID] // 0x00000001896AE670-0x00000001896AE690
	private void RefreshAnimator(MonoFetterInfoListRow mono, int index) {} // 0x0000000185015640-0x0000000185015890
}

