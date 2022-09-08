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

public sealed class CoopCGDialogContext : BaseDialogContext // TypeDefIndex: 30128
{
	// Fields
	private MonoCoopCGDialog _dialogMono; // 0x178
	private uint _cgConfigId; // 0x180
	private bool _hidePersonalInfo; // 0x184
	private bool _saved; // 0x185
	private RenderTexture _savedImageTexture; // 0x188
	private MonoInLevelPhotographWatermark _watermark; // 0x190
	private bool _jumpFromEnd; // 0x198
	private bool _canClickBtn; // 0x199
	private Coroutine _updateBtnClickStatus; // 0x1A0
	private Sprite _sprite; // 0x1A8
	private MonoCoopWatermarkPS4 _watermarkPS4; // 0x1B0
	private RenderTexture _savedImageTexturePS4; // 0x1B8

	// Constructors
	public CoopCGDialogContext() {} // Dummy constructor
	public CoopCGDialogContext(uint cgConfigId, bool jumpFromEnd = false /* Metadata: 0x00B10815 */) {} // 0x0000000180F89880-0x0000000180F89990

	// Methods
	// [XID] // 0x0000000189B84700-0x0000000189B84720
	public override void SetupView() {} // 0x0000000180F896F0-0x0000000180F89880
	// [XID] // 0x0000000189B8B590-0x0000000189B8B5B0
	private void CheckJumpFromType() {} // 0x0000000180F89170-0x0000000180F892D0
	// [XID] // 0x0000000189B92CC0-0x0000000189B92CE0
	private void Refresh() {} // 0x0000000180F87DE0-0x0000000180F88060
	// [XID] // 0x0000000189B9A2A0-0x0000000189B9A2C0
	public override void ClearView() {} // 0x0000000180F88500-0x0000000180F885E0
	// [XID] // 0x0000000189BA1970-0x0000000189BA1990
	private void ClearWatermark() {} // 0x0000000180F885E0-0x0000000180F887A0
	// [XID] // 0x0000000189BA8D90-0x0000000189BA8DB0
	private void ClearRenderTexture() {} // 0x0000000180F88060-0x0000000180F881B0
	// [XID] // 0x0000000189BB0520-0x0000000189BB0540
	protected override void BindViewCallbacks() {} // 0x0000000180F881B0-0x0000000180F88500
	// [XID] // 0x0000000189BB7920-0x0000000189BB7940
	private void OnBtnCloseClickWithDelay() {} // 0x0000000180F89640-0x0000000180F896F0
	// [XID] // 0x0000000189BBEF80-0x0000000189BBEFA0
	private void OnBtnPreservationClickWithDelay() {} // 0x0000000180F88CC0-0x0000000180F88DD0
	// [XID] // 0x0000000189BC6C10-0x0000000189BC6C30
	private void OnBtnPreservationClick() {} // 0x0000000180F88BC0-0x0000000180F88CC0
	// [XID] // 0x0000000189BCE900-0x0000000189BCE920
	private void AddWaterMark() {} // 0x0000000180F892D0-0x0000000180F895E0
	// [XID] // 0x0000000189BD5BC0-0x0000000189BD5BE0
	private RenderTexture Texture2DToRenderTextrue(Texture2D texture) => default; // 0x0000000180F88930-0x0000000180F88AA0
	// [XID] // 0x0000000189BDD870-0x0000000189BDD890
	private void OnSave() {} // 0x0000000180F887A0-0x0000000180F88930
	// [XID] // 0x00000001895EA3D0-0x00000001895EA3F0
	private RenderTexture SavePhotoForPS4() => default; // 0x0000000180F88DD0-0x0000000180F89170
}

