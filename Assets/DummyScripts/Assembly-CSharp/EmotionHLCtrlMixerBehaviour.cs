/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoEmotion;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EmotionHLCtrlMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26165
{
	// Fields
	private EmoSync _emoSync; // 0x10
	private EyeCtrl _eyeCtrl; // 0x18
	private Transform _viewTarget; // 0x20
	private string _currEmotion; // 0x28
	private float _currEmotionTransitionTime; // 0x30
	private Vector3 _currEyeOffset; // 0x34
	private float _currEyeTransitionTime; // 0x40
	private float _currEyeExitTime; // 0x44
	private Vector3 _originPos; // 0x48
	private bool _isEyeCtrlStarted; // 0x54
	private Vector3 _startPos; // 0x58
	private Vector3 _targetPos; // 0x64
	private float _timeCnt; // 0x70
	private float _duration; // 0x74
	private float _deltaTime; // 0x78
	private bool _isEyeExit; // 0x7C

	// Constructors
	public EmotionHLCtrlMixerBehaviour() {} // 0x000000018173C9D0-0x000000018173CAC0

	// Methods
	// [XID] // 0x0000000189961EB0-0x0000000189961ED0
	private bool GetBinding(object playerData) => default; // 0x000000018173BD30-0x000000018173BFB0
	// [XID] // 0x0000000189969410-0x0000000189969430
	public override void OnGraphStart(Playable playable) {} // 0x000000018173C080-0x000000018173C150
	// [XID] // 0x0000000189970FD0-0x0000000189970FF0
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018173C4D0-0x000000018173C9D0
	// [XID] // 0x0000000189978980-0x00000001899789A0
	private void StartEyeCtrl(Vector3 offset, float duration) {} // 0x000000018173C2B0-0x000000018173C4D0
	// [XID] // 0x000000018997FA30-0x000000018997FA50
	private void UpdateEyeCtrl(float deltaTime) {} // 0x000000018173BAC0-0x000000018173BD30
	// [XID] // 0x0000000189987360-0x0000000189987380
	public override void OnPlayableDestroy(Playable playable) {} // 0x000000018173C150-0x000000018173C2B0
}

