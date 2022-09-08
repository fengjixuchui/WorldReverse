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

public sealed class VoiceBundleDownloadDialogContext : BaseDialogContext // TypeDefIndex: 28988
{
	// Fields
	private MonoSettingDownloadDialog _dialogMono; // 0x178
	private VoiceLanguageType _voiceType; // 0x180
	private long _totalSize; // 0x188
	private long _downloadSize; // 0x190
	private DialogState _state; // 0x198
	private Action<bool, bool> _onFinishCallback; // 0x1A0
	private Queue<ProgressNotify> _queProgressMessage; // 0x1A8
	private ProgressNotify _lastProgressMessage; // 0x1B0
	private ProgressNotify _curShowingProgressMessage; // 0x1B8
	private ulong _updateProgressInfoInterval; // 0x1C0
	private ulong _lastUpdateProgressTime; // 0x1C8
	private bool _closingChangeLangueage; // 0x1D0

	// Properties
	private string voiceTypeStr { /* [XID] */ /* 0x0000000189841D60-0x0000000189841D80 */ get => default; } // 0x000000018303A030-0x000000018303A100 

	// Nested types
	public enum DialogState // TypeDefIndex: 28989
	{
		GetSize = 0,
		Confirm = 1,
		WaitStartDownload = 2,
		Downloading = 3,
		Verifying = 4,
		AfterDownload = 5
	}

	private class ProgressNotify // TypeDefIndex: 28990
	{
		// Fields
		public string info; // 0x10
		public float progress; // 0x18
		public long downloadSize; // 0x20
		public long totalSize; // 0x28

		// Constructors
		public ProgressNotify() {} // 0x0000000183C26B00-0x0000000183C26B60
	}

	// Constructors
	public VoiceBundleDownloadDialogContext() {} // Dummy constructor
	public VoiceBundleDownloadDialogContext(VoiceLanguageType voiceType, Action<bool, bool> onFinishCallback) {} // 0x000000018303AEB0-0x000000018303AFF0

	// Methods
	// [XID] // 0x0000000189849270-0x0000000189849290
	public override void SetupView() {} // 0x000000018303A840-0x000000018303AC80
	// [XID] // 0x0000000189850A30-0x0000000189850A50
	public override void ClearView() {} // 0x0000000183038CB0-0x0000000183038DD0
	// [XID] // 0x0000000189857DE0-0x0000000189857E00
	public override void CloseDialog() {} // 0x0000000183038FD0-0x0000000183039120
	// [XID] // 0x000000018985EEF0-0x000000018985EF10
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001830398F0-0x0000000183039A00
	// [XID] // 0x00000001898666B0-0x00000001898666D0
	private void SetupConfirmView() {} // 0x00000001830391B0-0x0000000183039400
	// [XID] // 0x000000018986DFB0-0x000000018986DFD0
	private void SwitchToContentView() {} // 0x0000000183039BB0-0x0000000183039CE0
	// [XID] // 0x0000000189875380-0x00000001898753A0
	private void SwitchToProgressView() {} // 0x0000000183039CE0-0x0000000183039E10
	// [XID] // 0x000000018987CF30-0x000000018987CF50
	private string GetProgressString(long downloadSize, long totalSize) => default; // 0x0000000183039740-0x0000000183039890
	// [XID] // 0x0000000189883EF0-0x0000000189883F10
	private void OnVoiceDownloadDialogBGClick() {} // 0x0000000183039560-0x0000000183039620
	// [XID] // 0x000000018988B5B0-0x000000018988B5D0
	private void OnVoiceDownloadDialogOKClick() {} // 0x0000000183039E10-0x000000018303A030
	// [XID] // 0x0000000189892D30-0x0000000189892D50
	private void StartDownload() {} // 0x0000000183039400-0x0000000183039560
	// [XID] // 0x000000018989A3D0-0x000000018989A3F0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018303A1F0-0x000000018303A590
	// [XID] // 0x00000001898A15D0-0x00000001898A15F0
	protected override void BindViewCallbacks() {} // 0x0000000183038AA0-0x0000000183038CB0
	// [XID] // 0x00000001898A8E40-0x00000001898A8E60
	private void UpdateDownloadProgress(float progress, long downloadSize, long totalSize) {} // 0x0000000183038DD0-0x0000000183038FD0
	// [XID] // 0x00000001898B07C0-0x00000001898B07E0
	private void UpdateVerifyProgress(string info, float progress) {} // 0x000000018303A600-0x000000018303A840
	// [XID] // 0x00000001898B7DF0-0x00000001898B7E10
	public override void UpdateView() {} // 0x000000018303AC80-0x000000018303AEB0
}

