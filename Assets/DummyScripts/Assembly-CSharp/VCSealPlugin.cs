/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCSealPlugin : BaseComponentPlugin // TypeDefIndex: 12170
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private int _effectIndex; // 0x58
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _ratio; // 0x5C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private ConfigSeal _config; // 0x60
	private bool _started; // 0x70
	private bool _showTips; // 0x71
	private uint _currScore; // 0x74
	private uint _maxScore; // 0x78
	private uint _endTime; // 0x7C
	private Animator _animator; // 0x80

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B8F760-0x0000000189B8F780 */ get => default; } // 0x000000018252CEF0-0x000000018252CF90 
	private Transform effectNode { /* [XID] */ /* 0x0000000189B96CA0-0x0000000189B96CE0 */ get; /* [XID] */ /* 0x0000000189BA11E0-0x0000000189BA1220 */ set; } // 0x000000018252B980-0x000000018252B9E0 0x000000018252C4B0-0x000000018252C510

	// Nested types
	private enum AnimatorState // TypeDefIndex: 12171
	{
		State_Up = 0,
		State_Down = 1,
		State_Warnning = 2,
		State_Success = 3,
		State_Fail = 4
	}

	// Constructors
	public VCSealPlugin() {} // Dummy constructor
	public VCSealPlugin(ConfigSeal config) {} // 0x000000018252CE60-0x000000018252CEF0

	// Methods
	// [XID] // 0x0000000189BAB7B0-0x0000000189BAB7D0
	private void InitAnimator(MonoEffect effect) {} // 0x000000018252BA80-0x000000018252BC20
	// [XID] // 0x0000000189BB2D30-0x0000000189BB2D50
	private void StartSealProgressView() {} // 0x000000018252C2B0-0x000000018252C360
	// [XID] // 0x0000000189BBA0E0-0x0000000189BBA100
	private void UpdateSealProgressView() {} // 0x000000018252C580-0x000000018252C720
	// [XID] // 0x0000000189BC2220-0x0000000189BC2240
	private void StopSealProgressView() {} // 0x000000018252B630-0x000000018252B7C0
	// [XID] // 0x0000000189BC9770-0x0000000189BC9790
	public void StartBoardEffect(uint radius, uint maxScore, bool showTips) {} // 0x000000018252BC20-0x000000018252C2B0
	// [XID] // 0x0000000189BD0F50-0x0000000189BD0F70
	public void UpdateProgress(SealBattleProgressNotify ntf) {} // 0x000000018252C790-0x000000018252CBA0
	// [XID] // 0x0000000189BD8540-0x0000000189BD8560
	public void EndBoardEffect(bool isWin) {} // 0x000000018252CBA0-0x000000018252CE60
	// [XID] // 0x0000000189BDFE80-0x0000000189BDFEA0
	private void ClearView() {} // 0x000000018252C3C0-0x000000018252C4B0
	// [XID] // 0x00000001895ECB40-0x00000001895ECB60
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018252B8D0-0x000000018252B980
	// [XID] // 0x00000001895F41B0-0x00000001895F41D0
	public override void Destroy() {} // 0x000000018252B9E0-0x000000018252BA80
}

