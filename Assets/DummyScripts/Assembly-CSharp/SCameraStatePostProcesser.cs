/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraStatePostProcesser : CameraStatePostProcesser // TypeDefIndex: 32124
{
	// Fields
	private CameraAvatarInfoData _avatarInfoData; // 0x100
	[ReadOnly] // 0x0000000189727BD0-0x0000000189727BE0
	private CameraAvatarPrepareData _avatarPrepareData; // 0x240
	private SCameraPostData _postData; // 0x248
	private bool _postDataInited; // 0x498
	private ISCameraRunner _sRunner; // 0x4A0
	private List<SCameraStatePostModule> _sModules; // 0x4A8

	// Constructors
	public SCameraStatePostProcesser() {} // 0x0000000182758E30-0x0000000182758F80

	// Methods
	// [XID] // 0x000000018972F170-0x000000018972F190
	public void SetCameraAvatarInfoData(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182758480-0x00000001827585B0
	// [XID] // 0x0000000189736B80-0x0000000189736BA0
	public void SetCameraAvatarPrepareData(CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001827583D0-0x0000000182758480
	// [XID] // 0x000000018973E720-0x000000018973E740
	public override void RefreshState(ICameraState activeState) {} // 0x00000001827589A0-0x0000000182758A90
	// [XID] // 0x0000000189745A00-0x0000000189745A20
	private void RefreshAvatarInfoData() {} // 0x0000000182757CE0-0x0000000182757E30
	// [XID] // 0x000000018974D4C0-0x000000018974D4E0
	private void InitPostData(ref CameraShareData data, ref CameraStateData retData) {} // 0x00000001827581F0-0x0000000182758350
	// [XID] // 0x0000000189754B70-0x0000000189754B90
	private void CopyPostLastFrame() {} // 0x0000000182757BB0-0x0000000182757CE0
	// [XID] // 0x000000018975BD20-0x000000018975BD40
	private void RefreshPostData(ref CameraShareData data, ref CameraStateData retData) {} // 0x00000001827585B0-0x0000000182758850
	// [XID] // 0x00000001897636F0-0x0000000189763710
	private void FlushPostData(ref SCameraPostData postData) {} // 0x0000000182758850-0x0000000182758920
	public override PostModuleType AddModule<PostModuleType>() => default;
	// [XID] // 0x000000018976AEF0-0x000000018976AF10
	public override void Collect(float deltaTime) {} // 0x0000000182757E30-0x0000000182757F80
	// [XID] // 0x0000000189772560-0x0000000189772580
	public override void Tick(float deltaTime) {} // 0x0000000182758A90-0x0000000182758E30
	// [XID] // 0x0000000189779B90-0x0000000189779BB0
	public override void Flush(float deltaTime) {} // 0x0000000182758080-0x00000001827581F0
}

