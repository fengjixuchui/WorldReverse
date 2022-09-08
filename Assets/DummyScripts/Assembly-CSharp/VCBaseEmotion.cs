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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCBaseEmotion : VCBase // TypeDefIndex: 11810
{
	// Fields
	private EmoSync _emoSync; // 0x108
	private EyeCtrl _eyeCtrl; // 0x110
	private EyeKey _eyeKey; // 0x118
	private Transform _viewTarget; // 0x120
	private Vector3 _originPos; // 0x128
	private bool _isEyeCtrlStarted; // 0x134
	private Vector3 _startPos; // 0x138
	private Vector3 _targetPos; // 0x144
	private float _timeCnt; // 0x150
	private float _duration; // 0x154
	private bool _isEyeExit; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189782AE0-0x0000000189782B00 */ get => default; } // 0x000000018319E340-0x000000018319E3E0 
	public EmoSync emoSync { /* [XID] */ /* 0x0000000189BCCC00-0x0000000189BCCC20 */ get => default; } // 0x000000018319DE50-0x000000018319DF00 
	public EyeCtrl eyeCtrl { /* [XID] */ /* 0x00000001897BE2A0-0x00000001897BE2C0 */ get => default; } // 0x000000018319D7C0-0x000000018319D870 
	public EyeKey eyeKey { /* [XID] */ /* 0x000000018989B470-0x000000018989B490 */ get => default; } // 0x000000018319DC10-0x000000018319DCC0 

	// Constructors
	public VCBaseEmotion() {} // 0x000000018319E2A0-0x000000018319E340

	// Methods
	// [XID] // 0x00000001897A0A90-0x00000001897A0AB0
	public override void Init() {} // 0x000000018319D9F0-0x000000018319DC10
	// [XID] // 0x00000001898B9300-0x00000001898B9320
	public void SetEmotion(string emotionName, float transTime) {} // 0x000000018319DCC0-0x000000018319DDE0
	// [XID] // 0x00000001897AFBB0-0x00000001897AFBD0
	public void SetNormalEmotion(float transTime) {} // 0x000000018319D400-0x000000018319D510
	// [XID] // 0x00000001898765B0-0x00000001898765D0
	public void StartEyeCtrl(Vector3 offset, float transTime, bool isExit) {} // 0x000000018319DF00-0x000000018319E1F0
	// [XID] // 0x00000001898A9EE0-0x00000001898A9F00
	public void EnableBlink(bool enable) {} // 0x000000018319D8F0-0x000000018319D9F0
	// [XID] // 0x000000018987E2F0-0x000000018987E310
	protected override void Tick(float inDeltaTime) {} // 0x000000018319E1F0-0x000000018319E2A0
	// [XID] // 0x00000001897CE600-0x00000001897CE620
	private void UpdateEyeCtrl(float deltaTime) {} // 0x000000018319D510-0x000000018319D7C0
}

