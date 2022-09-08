/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TheatreMechanicusTipsDialogContext : BaseDialogContext // TypeDefIndex: 29968
{
	// Fields
	private MonoTheatreMechanicusTipsDialog _dialogMono; // 0x178
	private uint _buildingId; // 0x180
	private uint _level; // 0x184
	private bool _effect1Unlocked; // 0x188
	private bool _effect2Unlocked; // 0x189

	// Constructors
	public TheatreMechanicusTipsDialogContext() {} // Dummy constructor
	public TheatreMechanicusTipsDialogContext(uint buildingId, uint level) {} // 0x0000000183DAD100-0x0000000183DAD1E0

	// Methods
	// [XID] // 0x000000018977E540-0x000000018977E560
	public override void SetupView() {} // 0x0000000183DACFE0-0x0000000183DAD100
	// [XID] // 0x0000000189785CB0-0x0000000189785CD0
	public override void ClearView() {} // 0x0000000183DABF00-0x0000000183DABFA0
	// [XID] // 0x000000018978D3D0-0x000000018978D3F0
	protected override void BindViewCallbacks() {} // 0x0000000183DABDA0-0x0000000183DABF00
	// [XID] // 0x0000000189794750-0x0000000189794770
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183DAC660-0x0000000183DAC740
	// [XID] // 0x000000018979CBE0-0x000000018979CC00
	protected override void OnEnable() {} // 0x0000000183DACE10-0x0000000183DACFE0
	// [XID] // 0x00000001897A4040-0x00000001897A4060
	private void RefreshView() {} // 0x0000000183DAC740-0x0000000183DACD50
	// [XID] // 0x00000001897AB5A0-0x00000001897AB5C0
	public void SetGearLevelEffect(uint index, string effectDesc, bool unLocked, uint effectLevel) {} // 0x0000000183DAC090-0x0000000183DAC600
}

