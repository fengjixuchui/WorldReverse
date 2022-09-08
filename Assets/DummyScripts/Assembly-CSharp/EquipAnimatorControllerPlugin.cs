/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EquipAnimatorControllerPlugin : BaseEquipControllerPlugin // TypeDefIndex: 12044
{
	// Fields
	private string _animStateToDefaultEquipTrigger; // 0x90
	private string _animStateToDefaultFloatID; // 0x98
	private float _animStateToDefaultFloat; // 0xA0
	private Dictionary<int, TriggerToStates> _animStateToEquipAnimData; // 0xA8
	private static Action<EvtEntityReadyPost> _setEquipAnimatorOpenTriggerEntityReadyCallBack; // 0x00
	private bool _currentBowDrawing; // 0xB0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189651020-0x0000000189651040 */ get => default; } // 0x00000001848E3FE0-0x00000001848E4080 

	// Constructors
	public EquipAnimatorControllerPlugin() {} // Dummy constructor
	public EquipAnimatorControllerPlugin(VCAvatarEquipController vcEquipController, ConfigCharacter config) {} // 0x00000001848E3F40-0x00000001848E3FE0
	static EquipAnimatorControllerPlugin() {} // 0x00000001848E3E70-0x00000001848E3F40

	// Methods
	// [XID] // 0x0000000189658770-0x0000000189658790
	private static void SetEquipAnimatorOpenTriggerEntityReadyCallBack(EvtEntityReadyPost e) {} // 0x00000001848E3290-0x00000001848E3360
	// [XID] // 0x000000018965FDA0-0x000000018965FDC0
	public override void Init() {} // 0x00000001848E35B0-0x00000001848E39F0
	// [XID] // 0x0000000189667880-0x00000001896678A0
	public override void Destroy() {} // 0x00000001848E2D60-0x00000001848E2E20
	// [XID] // 0x000000018966F060-0x000000018966F080
	protected override void OnAnimatorChanged() {} // 0x00000001848E3360-0x00000001848E35B0
	// [XID] // 0x000000018993D940-0x000000018993D960
	private BaseEntity SetEquipAnimatorTrigger(string triggerName, float playTime) => default; // 0x00000001848E2AA0-0x00000001848E2D00
	// [XID] // 0x000000018967E280-0x000000018967E2A0
	private void SetEquipAnimatorFloat(string floatName, float value) {} // 0x00000001848E3CA0-0x00000001848E3E70
	// [XID] // 0x0000000189685A10-0x0000000189685A30
	protected override void UpdateEquipController() {} // 0x00000001848E2FF0-0x00000001848E3290
	// [XID] // 0x000000018968D3B0-0x000000018968D3D0
	private void SetEquipAnimatorBowDraw(bool drawing) {} // 0x00000001848E2E20-0x00000001848E2FF0
	// [XID] // 0x0000000189B7DCC0-0x0000000189B7DCE0
	public void SetEquipAnimatorOpenTrigger() {} // 0x00000001848E3A50-0x00000001848E3BD0
}

