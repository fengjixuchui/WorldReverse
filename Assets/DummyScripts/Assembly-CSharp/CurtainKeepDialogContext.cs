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

public sealed class CurtainKeepDialogContext : BaseDialogContext // TypeDefIndex: 28561
{
	// Fields
	private MonoCurtainCanvas _dialogMono; // 0x178
	private float _curTime; // 0x180
	private float _durationToBlack; // 0x184
	private float _durationKeepBlack; // 0x188
	private float _durationFromBlack; // 0x18C
	private bool _startPlay; // 0x190
	private Action _callback; // 0x198
	private Action _finishCallback; // 0x1A0
	private CurtainTask _task; // 0x1A8
	private uint _curtainState; // 0x1B0
	private static string DEFAULT_TEXT; // 0x00
	private string _curQuestHint; // 0x1B8

	// Constructors
	public CurtainKeepDialogContext() {} // 0x0000000185944F40-0x00000001859450F0
	static CurtainKeepDialogContext() {} // 0x0000000185944EE0-0x0000000185944F40

	// Methods
	// [XID] // 0x000000018999F890-0x000000018999F8B0
	private bool IsTaskFinish() => default; // 0x0000000185944930-0x00000001859449F0
	// [XID] // 0x00000001899A74B0-0x00000001899A74D0
	public override void SetupView() {} // 0x0000000185944D40-0x0000000185944E40
	// [XID] // 0x00000001899AED40-0x00000001899AED60
	public override void UpdateView() {} // 0x0000000185944E40-0x0000000185944EE0
	// [XID] // 0x00000001899B6100-0x00000001899B6120
	public override void ClearView() {} // 0x0000000185943D80-0x0000000185943E20
	// [XID] // 0x00000001899BDE20-0x00000001899BDE40
	public override void OnDisconnect() {} // 0x00000001859449F0-0x0000000185944AB0
	// [XID] // 0x00000001899C55A0-0x00000001899C55C0
	public void SetColor(Color fillColor) {} // 0x0000000185944790-0x0000000185944930
	// [XID] // 0x00000001899CCC30-0x00000001899CCC50
	private void SetBgAlpha(float a) {} // 0x0000000185944AB0-0x0000000185944D40
	// [XID] // 0x00000001899D4230-0x00000001899D4250
	public void StartPlay(float durationToBlack, float durationKeepBlack, float durationFromBlack, Action callback = null, Action finishCallback = null, CurtainTask task = null, string textMapId = null) {} // 0x00000001859445C0-0x0000000185944790
	// [XID] // 0x00000001899DB860-0x00000001899DB880
	private void UpdateCurtain() {} // 0x0000000185944170-0x0000000185944560
	// [XID] // 0x00000001899E2F60-0x00000001899E2F80
	private void SetTextMap(string textMapId) {} // 0x0000000185943EE0-0x0000000185944110
}

