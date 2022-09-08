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
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraFocusStateRunner : SCameraStateBaseRunner<SCameraFocusState> // TypeDefIndex: 32080
{
	// Fields
	private List<SCameraFocusData> _stack; // 0x658
	private List<SCameraFocusData> _dataBuffer; // 0x660
	private bool _hasFocus; // 0x668
	private EasingFunction.Ease _easeType; // 0x66C
	private double _duration; // 0x670
	private PipelineCameraModuleConfig _focusConfig; // 0x678
	private CameraStateBlenderConfig _blenderCfg; // 0x680
	private SCameraModuleInitialize _initialModule; // 0x688

	// Properties
	public List<SCameraFocusData> dataStack { /* [XID] */ /* 0x00000001896D1710-0x00000001896D1730 */ get => default; } // 0x0000000183378C30-0x0000000183378CE0 
	public CameraStateBlenderConfig BlenderCfg { /* [XID] */ /* 0x00000001896D8EB0-0x00000001896D8ED0 */ get => default; } // 0x0000000183378CE0-0x0000000183378DE0 

	// Constructors
	public SCameraFocusStateRunner() {} // 0x0000000183379B30-0x0000000183379C50

	// Methods
	// [XID] // 0x00000001896E0770-0x00000001896E0790
	protected override void InitModules() {} // 0x0000000183379270-0x00000001833793A0
	// [XID] // 0x00000001896E7980-0x00000001896E79A0
	public void UpdateByBlendSrc(ICameraState state) {} // 0x00000001833788D0-0x0000000183378BD0
	// [XID] // 0x00000001896EF010-0x00000001896EF030
	public override void OnSpawn() {} // 0x0000000183378270-0x0000000183378320
	// [XID] // 0x00000001896F6AE0-0x00000001896F6B00
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x00000001833793A0-0x00000001833794A0
	// [XID] // 0x00000001896FE2B0-0x00000001896FE2D0
	protected override void HandleClearFilter(ref SCameraCmd cmd) {} // 0x0000000183378E40-0x0000000183378F00
	// [XID] // 0x0000000189705500-0x0000000189705520
	public void EnterFocus(SCameraFocusData data) {} // 0x0000000183378FF0-0x00000001833791F0
	// [XID] // 0x000000018970CF70-0x000000018970CF90
	private void EnterFocusInternal(SCameraFocusData data) {} // 0x00000001833784F0-0x00000001833786C0
	// [XID] // 0x00000001897BC870-0x00000001897BC890
	public void ExitFocus(SCameraFocusData data) {} // 0x0000000183379580-0x0000000183379750
	// [XID] // 0x000000018971BE70-0x000000018971BE90
	private void ExitFocusInternal(SCameraFocusData data) {} // 0x0000000183378110-0x0000000183378270
	// [XID] // 0x0000000189723350-0x0000000189723370
	public override void ClearOnDisconnect() {} // 0x00000001833797B0-0x00000001833798A0
	// [XID] // 0x000000018972AAC0-0x000000018972AAE0
	private void CollectDataBuffer() {} // 0x0000000183378320-0x00000001833784F0
	// [XID] // 0x0000000189732180-0x00000001897321A0
	protected override void StartInternal() {} // 0x0000000183379980-0x0000000183379A70
	// [XID] // 0x00000001897398A0-0x00000001897398C0
	protected override void CollectPreInternal() {} // 0x0000000183378790-0x0000000183378850
	// [XID] // 0x0000000189741420-0x0000000189741440
	private void RefreshAvatarLookAt(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000183378F00-0x0000000183378FF0
	// [XID] // 0x0000000189748D60-0x0000000189748D80
	protected override void CollectInternal(float deltaTime) {} // 0x00000001833786C0-0x0000000183378790
	// [XID] // 0x00000001897501C0-0x00000001897501E0
	protected override void TickInternal(float deltaTime) {} // 0x0000000183379A70-0x0000000183379B30
}

