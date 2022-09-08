/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InterBlackScreenTask : BaseInterTask // TypeDefIndex: 20923
{
	// Fields
	private InLevelCutScenePageContext _blackScreen; // 0x38
	private float _durationTo; // 0x40
	private float _durationKeep; // 0x44
	private float _durationFrom; // 0x48
	private Color _tempSpd; // 0x4C
	private Color _tempColor; // 0x5C
	private int _state; // 0x6C
	private BlackScreenType _blackScreenType; // 0x70
	private BaseEntity _inteeEntity; // 0x78
	private bool _isChangeToPos; // 0x80
	private DummyPoint _changeToDummyPos; // 0x88

	// Properties
	public override InteractionType dataType { /* [XID] */ /* 0x000000018972C800-0x000000018972C820 */ get => default; } // 0x0000000181F5AEE0-0x0000000181F5AF80 

	// Constructors
	public InterBlackScreenTask() {} // 0x0000000181F5BEE0-0x0000000181F5BFC0

	// Methods
	// [XID] // 0x0000000189725140-0x0000000189725160
	public override void ResetObject() {} // 0x0000000181F5BDB0-0x0000000181F5BEE0
	// [XID] // 0x0000000189733F30-0x0000000189733F50
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000181F5B430-0x0000000181F5B4E0
	// [XID] // 0x000000018973B6F0-0x000000018973B710
	public override void FinishCurr() {} // 0x0000000181F5AD90-0x0000000181F5AE70
	// [XID] // 0x0000000189743180-0x00000001897431A0
	protected override void DoActionInternal(BaseInterAction interAction) {} // 0x0000000181F5AF80-0x0000000181F5B430
	// [XID] // 0x000000018974AD00-0x000000018974AD20
	public override void Tick() {} // 0x0000000181F5AC00-0x0000000181F5AD30
	// [XID] // 0x0000000189751DB0-0x0000000189751DD0
	private void UpdateColorToKeepFromBlack() {} // 0x0000000181F5B8A0-0x0000000181F5BDB0
	// [XID] // 0x0000000189759460-0x0000000189759480
	private void UpdateColorToBlack() {} // 0x0000000181F5B740-0x0000000181F5B8A0
	// [XID] // 0x0000000189761050-0x0000000189761070
	private void UpdateColorFromBlack() {} // 0x0000000181F5B4E0-0x0000000181F5B640
	// [XID] // 0x00000001897683A0-0x00000001897683C0
	private void UpdateColorKeepBlack() {} // 0x0000000181F5AA50-0x0000000181F5AB40
}

