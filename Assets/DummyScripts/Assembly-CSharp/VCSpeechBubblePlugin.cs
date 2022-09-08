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

public sealed class VCSpeechBubblePlugin : VCBaseBillboardPlugin // TypeDefIndex: 12174
{
	// Fields
	private ConfigDialogScheme _dialog; // 0x88
	private MonoSpeechBubble _monoSpeechBubble; // 0x90
	private float _endTime; // 0x98
	private bool _isAsyncLoading; // 0x9C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018968A5C0-0x000000018968A5E0 */ get => default; } // 0x0000000182BF32C0-0x0000000182BF3360 
	public override bool isValid { /* [XID] */ /* 0x00000001896C56D0-0x00000001896C56F0 */ get => default; } // 0x0000000182BF2810-0x0000000182BF2900 
	public override bool isActive { /* [XID] */ /* 0x00000001896CCD00-0x00000001896CCD20 */ get => default; } // 0x0000000182BF30B0-0x0000000182BF31D0 
	public bool isRunning { /* [XID] */ /* 0x00000001896D3F60-0x00000001896D3F80 */ get => default; } // 0x0000000182BF2C80-0x0000000182BF2DA0 

	// Constructors
	public VCSpeechBubblePlugin() {} // 0x0000000182BF3240-0x0000000182BF32C0

	// Methods
	// [XID] // 0x0000000189692310-0x0000000189692330
	public void ShowSpeechBubble(ConfigDialogScheme dialog, float time) {} // 0x0000000182BF1FC0-0x0000000182BF2110
	// [XID] // 0x0000000189699750-0x0000000189699770
	private void OnBillboardRequired() {} // 0x0000000182BF2F60-0x0000000182BF30B0
	// [XID] // 0x0000000189831240-0x0000000189831260
	private void OnSpeechBubbleCallback() {} // 0x0000000182BF2960-0x0000000182BF2AB0
	// [XID] // 0x0000000189B33050-0x0000000189B33070
	public void UpdateSpeechBubblePos(bool isAnime) {} // 0x0000000182BF1A00-0x0000000182BF1EA0
	// [XID] // 0x000000018973E460-0x000000018973E480
	public void ClearSpeechBubble() {} // 0x0000000182BF2DA0-0x0000000182BF2F60
	// [XID] // 0x00000001896B6BA0-0x00000001896B6BC0
	public override void Destroy() {} // 0x0000000182BF2240-0x0000000182BF22F0
	// [XID] // 0x00000001896BDDC0-0x00000001896BDDE0
	private void RealDestroySpeechBubble() {} // 0x0000000182BF2110-0x0000000182BF2240
	// [XID] // 0x00000001896DB8C0-0x00000001896DB8E0
	public override void LateUpdateView(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x0000000182BF22F0-0x0000000182BF2810
	// [XID] // 0x00000001896E3060-0x00000001896E3080
	public override void RefreshViewOnEnable() {} // 0x0000000182BF2B10-0x0000000182BF2C10
}

