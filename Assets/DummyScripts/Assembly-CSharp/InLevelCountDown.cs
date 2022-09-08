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

public sealed class InLevelCountDown : BaseContextComponent // TypeDefIndex: 29656
{
	// Fields
	private const string PATH_COUNT_DOWN = "ART/UI/Menus/Widget/InLevel/CountDownText"; // Metadata: 0x00B0FB06
	private uint _resHandler; // 0x30
	private MonoCountDown _countDown; // 0x38
	private Transform _parentView; // 0x40
	private float _duration; // 0x48
	private float _readyDuration; // 0x4C
	private float _readyFinishDuration; // 0x50
	private float _warningLimit; // 0x54
	private float _finishDuration; // 0x58
	private bool _isToReady; // 0x5C
	private bool _isReadyFinishing; // 0x5D
	private bool _isStarted; // 0x5E
	private bool _isFinishing; // 0x5F
	private bool _onlyShowReady; // 0x60
	private Action _endCallBack; // 0x68
	private Action _readyEndCallBack; // 0x70

	// Properties
	public bool isStarted { /* [XID] */ /* 0x0000000189625E80-0x0000000189625EA0 */ get => default; } // 0x0000000183089AE0-0x0000000183089B80 

	// Constructors
	public InLevelCountDown() {} // 0x0000000183089EA0-0x0000000183089F30

	// Methods
	// [XID] // 0x000000018962D820-0x000000018962D840
	public override void Init(GameObject view) {} // 0x0000000183089920-0x0000000183089A20
	// [XID] // 0x00000001896353A0-0x00000001896353C0
	private void InitUI() {} // 0x0000000183088F70-0x0000000183089140
	// [XID] // 0x000000018963CA40-0x000000018963CA60
	public void StartCount(float duration, float warningLimit, float readyDuration, Action callback = null, Action readyCallback = null) {} // 0x0000000183089580-0x0000000183089800
	// [XID] // 0x00000001896440C0-0x00000001896440E0
	public void TerminateCount() {} // 0x0000000183089800-0x0000000183089920
	// [XID] // 0x000000018964B870-0x000000018964B890
	public override void UpdateView() {} // 0x0000000183089E00-0x0000000183089EA0
	// [XID] // 0x0000000189653000-0x0000000189653020
	public void UpdateCount() {} // 0x0000000183089210-0x0000000183089580
	// [XID] // 0x000000018965A6C0-0x000000018965A6E0
	public override void Destroy() {} // 0x0000000183089140-0x0000000183089210
	// [XID] // 0x0000000189661CF0-0x0000000189661D10
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183089C10-0x0000000183089E00
}

