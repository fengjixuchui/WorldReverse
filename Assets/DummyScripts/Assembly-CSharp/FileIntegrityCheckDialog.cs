/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FileIntegrityCheckDialog : BaseDialogContext // TypeDefIndex: 28677
{
	// Fields
	private MonoFileIntegrityCheckDialog _dialogMono; // 0x178
	private DownloadBadBundleChecker _fileChecker; // 0x180
	private bool _isIntegrited; // 0x188
	private bool _isFinished; // 0x189

	// Constructors
	public FileIntegrityCheckDialog() {} // 0x0000000184B5AAA0-0x0000000184B5AB60

	// Methods
	public override void SetupView() {} // 0x0000000184B5A7D0-0x0000000184B5A8B0
	public override void ClearView() {} // 0x0000000184B5A100-0x0000000184B5A1D0
	public override void UpdateView() {} // 0x0000000184B5A900-0x0000000184B5AAA0
	private void InitFileChecker() {} // 0x0000000184B5A260-0x0000000184B5A3B0
	private void OnFinishCheckingCallBack(bool isOK) {} // 0x0000000184B5A760-0x0000000184B5A7D0
	private void OnFinishCallBack(bool isOK) {} // 0x0000000184B5A440-0x0000000184B5A760
	protected override void BindViewCallbacks() {} // 0x0000000184B5A040-0x0000000184B5A100
	private void OnAbortBtnClick() {} // 0x0000000184B5A3B0-0x0000000184B5A440
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184B5A1D0-0x0000000184B5A260
}

