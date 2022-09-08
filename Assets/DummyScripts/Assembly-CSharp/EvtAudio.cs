/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAudio : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20053
{
	// Fields
	private OP _op; // 0x30
	private AUDIO_SRC _src; // 0x34
	public uint stateGroup; // 0x38
	public uint state; // 0x3C
	public ItemConfig itemConfig; // 0x40
	public QuestProxy quest; // 0x48
	public int blackScreenState; // 0x50
	public AudioFeatureBitmask audioFeatureMask; // 0x54
	public bool audioFeatureDisable; // 0x58
	public WorldAreaConfig areaConfig; // 0x60
	private EvtAudioParam _paramPackage; // 0x68

	// Properties
	public OP op { /* [XID] */ /* 0x00000001899C91C0-0x00000001899C91E0 */ get => default; } // 0x00000001832A5290-0x00000001832A5330 
	public AUDIO_SRC src { /* [XID] */ /* 0x0000000189B2F250-0x0000000189B2F270 */ get => default; } // 0x00000001832A4F20-0x00000001832A4FC0 
	public EvtAudioParam paramPackage { /* [XID] */ /* 0x0000000189B36BD0-0x0000000189B36BF0 */ get => default; } // 0x00000001832A4D10-0x00000001832A4DB0 

	// Nested types
	public struct EvtAudioParam // TypeDefIndex: 20054
	{
		// Fields
		public uint stateGroup; // 0x00
		public uint state; // 0x04
	}

	public enum OP // TypeDefIndex: 20055
	{
		INVALID = -1,
		SET_STATE = 0,
		PICK_UP = 1,
		QUEST = 2,
		WEAPON_APPEAR = 3,
		BLACK_SCREEN = 4,
		TOGGLE_FEATURE = 5,
		AREA_CHANGE = 6
	}

	public enum AUDIO_SRC // TypeDefIndex: 20056
	{
		NONE = -1,
		INTERACTION = 0,
		CUTSCENE = 1,
		LUA_ACTOR = 2
	}

	// Constructors
	public EvtAudio() {} // 0x00000001832A56D0-0x00000001832A5760

	// Methods
	[BlackList] // 0x0000000189B08E30-0x0000000189B08E70
	// [XID] // 0x0000000189B08E30-0x0000000189B08E70
	public override void AutoAllocTypeFields() {} // 0x00000001832A4DB0-0x00000001832A4E50
	[BlackList] // 0x0000000189B13440-0x0000000189B13480
	// [XID] // 0x0000000189B13440-0x0000000189B13480
	public override void AutoRecycleTypeFields() {} // 0x00000001832A4E50-0x00000001832A4F20
	[BlackList] // 0x0000000189B1D810-0x0000000189B1D850
	// [XID] // 0x0000000189B1D810-0x0000000189B1D850
	public override void ReturnToObjectPool() {} // 0x00000001832A5630-0x00000001832A56D0
	// [XID] // 0x0000000189B3E350-0x0000000189B3E370
	public void UpdateQuest(QuestProxy questProxy) {} // 0x00000001832A54C0-0x00000001832A5570
	// [XID] // 0x00000001898797C0-0x00000001898797E0
	public void Init(uint targetID, OP op, AUDIO_SRC src = AUDIO_SRC.NONE /* Metadata: 0x00AFD1C4 */) {} // 0x00000001832A5020-0x00000001832A5110
	// [XID] // 0x0000000189B4D530-0x0000000189B4D550
	public override void PreHandle() {} // 0x00000001832A5330-0x00000001832A54C0
	// [XID] // 0x0000000189B54D90-0x0000000189B54DB0
	public override void Clear() {} // 0x00000001832A5170-0x00000001832A5230
}

