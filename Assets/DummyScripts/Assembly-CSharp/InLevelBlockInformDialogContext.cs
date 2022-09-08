/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelBlockInformDialogContext : BaseDialogContext // TypeDefIndex: 29545
{
	// Fields
	private MonoGeneralDialog _dialogMono; // 0x178
	private BlockDialogType _blockDialogType; // 0x180
	private uint _blockExpireTime; // 0x184
	private string _hostNickname; // 0x188

	// Nested types
	public enum BlockDialogType // TypeDefIndex: 29546
	{
		None = 0,
		BlockInSelfWorld = 1,
		BlockInMP = 2,
		KickFromMpByHostBlock = 3
	}

	// Constructors
	public InLevelBlockInformDialogContext() {} // Dummy constructor
	public InLevelBlockInformDialogContext(BlockDialogType blockDialogType, uint endTime = 0 /* Metadata: 0x00B0F889 */, string hostNickname = null) {} // 0x00000001827849E0-0x0000000182784AD0

	// Methods
	public override void SetupView() {} // 0x0000000182784890-0x00000001827849E0
	public override void ClearView() {} // 0x00000001827843B0-0x0000000182784420
	protected override void BindViewCallbacks() {} // 0x00000001827842F0-0x00000001827843B0
	private void OnOKBtnClick() {} // 0x0000000182784520-0x0000000182784590
	private void SetTitleAndBtnTextByType() {} // 0x0000000182784590-0x0000000182784890
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182784420-0x0000000182784520
}

