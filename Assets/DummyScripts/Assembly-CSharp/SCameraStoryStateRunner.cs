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

public sealed class SCameraStoryStateRunner : SCameraStateBaseRunner<SCameraStoryState> // TypeDefIndex: 32128
{
	// Fields
	private List<SCameraStoryData> _stack; // 0x658
	private bool _hasToData; // 0x660
	private bool _tryExit; // 0x661
	private SCameraStoryData _toData; // 0x668
	private bool _hasFromData; // 0x770
	private SCameraStoryData _fromData; // 0x778
	private CameraStateBlenderConfig.BlendType _blendType; // 0x880
	private EasingFunction.Ease _easeType; // 0x884
	private CameraStateBlenderConfig.PoleType _poleType; // 0x888
	private EasingFunction.FunctionValue _lerpFunc; // 0x890
	private double _duration; // 0x898
	private double _blendTime; // 0x8A0
	private bool _isFinished; // 0x8A8
	private bool _isKeepSp; // 0x8A9
	private Action _enterFinish; // 0x8B0
	private Action _exitFinish; // 0x8B8
	private List<SCameraStoryData> _dataBuffer; // 0x8C0
	private CameraStateBlenderConfig _blenderCfg; // 0x8C8

	// Properties
	public CameraStateBlenderConfig BlenderCfg { /* [XID] */ /* 0x0000000189801D10-0x0000000189801D30 */ get => default; } // 0x0000000185543E00-0x0000000185543F20 

	// Constructors
	public SCameraStoryStateRunner() {} // 0x0000000185545E50-0x0000000185545F70

	// Methods
	// [XID] // 0x00000001897F2EE0-0x00000001897F2F00
	public void CallEnterFinish() {} // 0x00000001855459B0-0x0000000185545A70
	// [XID] // 0x00000001897FA750-0x00000001897FA770
	public void CallExitFinish() {} // 0x0000000185542DD0-0x0000000185542E90
	// [XID] // 0x0000000189809160-0x0000000189809180
	private bool Peek(ref SCameraStoryData data) => default; // 0x0000000185542E90-0x0000000185543070
	// [XID] // 0x0000000189810AC0-0x0000000189810AE0
	private bool Pop(ref SCameraStoryData data) => default; // 0x0000000185544B60-0x0000000185544D80
	// [XID] // 0x000000018996A230-0x000000018996A250
	public void EnterStory(SCameraStoryData data) {} // 0x0000000185544EC0-0x0000000185545120
	// [XID] // 0x000000018981FC50-0x000000018981FC70
	private void EnterStoryInternal(SCameraStoryData data) {} // 0x00000001855442F0-0x00000001855446F0
	// [XID] // 0x00000001896B3E30-0x00000001896B3E50
	public bool ExitStory(SCameraStoryData data) => default; // 0x00000001855453B0-0x00000001855455E0
	// [XID] // 0x00000001896D1400-0x00000001896D1420
	private bool IsInEnter() => default; // 0x00000001855451E0-0x00000001855453B0
	// [XID] // 0x0000000189835ED0-0x0000000189835EF0
	private bool IsClearing() => default; // 0x0000000185543F20-0x0000000185544100
	// [XID] // 0x000000018983D3D0-0x000000018983D3F0
	private void ExitStoryInternal(SCameraStoryData data) {} // 0x0000000185542AA0-0x0000000185542DD0
	// [XID] // 0x0000000189844C30-0x0000000189844C50
	private void CollectDataBuffer() {} // 0x00000001855433B0-0x0000000185543670
	// [XID] // 0x000000018984BFE0-0x000000018984C000
	private void CollectCameraStoryData(double deltaTime) {} // 0x0000000185543A80-0x0000000185543C40
	// [XID] // 0x00000001898530D0-0x00000001898530F0
	private void CollectPrepareExitData(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000185543070-0x00000001855433B0
	// [XID] // 0x000000018985ABE0-0x000000018985AC00
	private void CollectExitSpState(CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000185544180-0x00000001855442F0
	// [XID] // 0x00000001898620F0-0x0000000189862110
	public override void ClearOnDisconnect() {} // 0x0000000185545720-0x0000000185545850
	// [XID] // 0x00000001898695D0-0x00000001898695F0
	protected override void StartInternal() {} // 0x0000000185545CD0-0x0000000185545D70
	// [XID] // 0x00000001898707D0-0x00000001898707F0
	protected override void CollectPreInternal() {} // 0x0000000185543940-0x0000000185543A00
	// [XID] // 0x00000001898782A0-0x00000001898782C0
	private void RefreshAvatarLookAt(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000185544A70-0x0000000185544B60
	// [XID] // 0x000000018987F730-0x000000018987F750
	protected override void CollectInternal(float deltaTime) {} // 0x0000000185543860-0x0000000185543940
	// [XID] // 0x0000000189886E40-0x0000000189886E60
	protected override void TickInternal(float deltaTime) {} // 0x0000000185545D70-0x0000000185545E50
	// [XID] // 0x000000018988DF30-0x000000018988DF50
	private void TickCameraStoryData(double deltaTime) {} // 0x0000000185542790-0x00000001855429E0
	// [XID] // 0x00000001898955D0-0x00000001898955F0
	private void UpdateShareData(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001855455E0-0x00000001855456C0
	// [XID] // 0x000000018989CD40-0x000000018989CD60
	private void InnerLerp(double t) {} // 0x00000001855446F0-0x0000000185544A70
	// [XID] // 0x00000001898A44D0-0x00000001898A44F0
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000185544E00-0x0000000185544EC0
	// [XID] // 0x00000001898AB970-0x00000001898AB990
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x00000001855429E0-0x0000000185542AA0
	// [XID] // 0x00000001898B3130-0x00000001898B3150
	protected override void HandleResetBackward(ref SCameraCmd cmd) {} // 0x0000000185545120-0x00000001855451E0
	// [XID] // 0x00000001898BAE30-0x00000001898BAE50
	private void ExitSp() {} // 0x0000000185543670-0x0000000185543860
	// [XID] // 0x00000001898C2180-0x00000001898C21A0
	protected override void FlushInternal(float deltaTime) {} // 0x0000000185543CA0-0x0000000185543D80
	// [XID] // 0x00000001898C9BD0-0x00000001898C9BF0
	protected override void PostFlushTopInternal() {} // 0x0000000185545AD0-0x0000000185545CD0
}

