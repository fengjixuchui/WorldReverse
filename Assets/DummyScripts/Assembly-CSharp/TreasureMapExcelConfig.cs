/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TreasureMapExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15194
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activity_idRawNum; // 0x14
	protected SimpleSafeUInt32 preview_reward_idRawNum; // 0x18
	protected SimpleSafeUInt32 npc_idRawNum; // 0x1C
	protected SimpleSafeFloat[] _npc_pos; // 0x20
	protected SimpleSafeUInt32 treasure_daysRawNum; // 0x28
	protected SimpleSafeUInt32 quest_idRawNum; // 0x2C
	protected SimpleSafeFloat monster_probabilityRawNum; // 0x30
	protected SimpleSafeUInt32 reward_worktop_gadget_idRawNum; // 0x34
	protected SimpleSafeUInt32 token_material_idRawNum; // 0x38
	protected SimpleSafeUInt32 unit_token_drop_idRawNum; // 0x3C
	protected SimpleSafeUInt32 mp_reward_idRawNum; // 0x40
	protected SimpleSafeUInt32 host_reward_limitRawNum; // 0x44
	protected SimpleSafeUInt32 guest_reward_limitRawNum; // 0x48
	protected SimpleSafeUInt32 mp_challenge_indexRawNum; // 0x4C
	protected SimpleSafeUInt32 bonus_challenge_indexRawNum; // 0x50
	protected SimpleSafeUInt32 challenge_gadget_suiteRawNum; // 0x54
	protected SimpleSafeUInt32 spot_revise_level_idRawNum; // 0x58
	protected SimpleSafeUInt32 detector_material_idRawNum; // 0x5C
	protected SimpleSafeUInt32 guide_child_quest_idRawNum; // 0x60

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AAEC00-0x0000000189AAEC20 */ get => default; /* [XID] */ /* 0x0000000189AB65E0-0x0000000189AB6600 */ protected set {} } // 0x00000001839FB1B0-0x00000001839FB280 0x00000001839F93F0-0x00000001839F94D0
	public uint activity_id { /* [XID] */ /* 0x0000000189ABE0B0-0x0000000189ABE0D0 */ get => default; /* [XID] */ /* 0x0000000189AC5BF0-0x0000000189AC5C10 */ protected set {} } // 0x00000001839FAAA0-0x00000001839FAB70 0x00000001839F6CD0-0x00000001839F6DB0
	public uint preview_reward_id { /* [XID] */ /* 0x0000000189ACD180-0x0000000189ACD1A0 */ get => default; /* [XID] */ /* 0x0000000189AD4F20-0x0000000189AD4F40 */ protected set {} } // 0x00000001839FA8F0-0x00000001839FA9C0 0x00000001839F94D0-0x00000001839F95B0
	public uint npc_id { /* [XID] */ /* 0x0000000189ADC7C0-0x0000000189ADC7E0 */ get => default; /* [XID] */ /* 0x0000000189AE4110-0x0000000189AE4130 */ protected set {} } // 0x00000001839FADF0-0x00000001839FAEC0 0x00000001839F7000-0x00000001839F70E0
	public SimpleSafeFloat[] npc_pos { /* [XID] */ /* 0x0000000189AEB970-0x0000000189AEB990 */ get => default; /* [XID] */ /* 0x0000000189AF3350-0x0000000189AF3370 */ protected set {} } // 0x00000001839F6DB0-0x00000001839F6E50 0x00000001839F9340-0x00000001839F93F0
	public uint treasure_days { /* [XID] */ /* 0x0000000189AFABC0-0x0000000189AFABE0 */ get => default; /* [XID] */ /* 0x0000000189B02130-0x0000000189B02150 */ protected set {} } // 0x00000001839FAD20-0x00000001839FADF0 0x00000001839FA9C0-0x00000001839FAAA0
	public uint quest_id { /* [XID] */ /* 0x0000000189B095B0-0x0000000189B095D0 */ get => default; /* [XID] */ /* 0x0000000189B11150-0x0000000189B11170 */ protected set {} } // 0x00000001839F8F10-0x00000001839F8FE0 0x00000001839F90B0-0x00000001839F9190
	public float monster_probability { /* [XID] */ /* 0x0000000189B18380-0x0000000189B183A0 */ get => default; /* [XID] */ /* 0x0000000189B1FA60-0x0000000189B1FA80 */ protected set {} } // 0x00000001839FA730-0x00000001839FA810 0x00000001839F6740-0x00000001839F6820
	public uint reward_worktop_gadget_id { /* [XID] */ /* 0x0000000189B27260-0x0000000189B27280 */ get => default; /* [XID] */ /* 0x0000000189B2E3F0-0x0000000189B2E410 */ protected set {} } // 0x00000001839F9190-0x00000001839F9260 0x00000001839F6820-0x00000001839F6900
	public uint token_material_id { /* [XID] */ /* 0x0000000189B358E0-0x0000000189B35900 */ get => default; /* [XID] */ /* 0x0000000189B3D080-0x0000000189B3D0A0 */ protected set {} } // 0x00000001839FB280-0x00000001839FB350 0x00000001839F95B0-0x00000001839F9690
	public uint unit_token_drop_id { /* [XID] */ /* 0x0000000189B44EF0-0x0000000189B44F10 */ get => default; /* [XID] */ /* 0x0000000189B4C6C0-0x0000000189B4C6E0 */ protected set {} } // 0x00000001839F6670-0x00000001839F6740 0x00000001839FAB70-0x00000001839FAC50
	public uint mp_reward_id { /* [XID] */ /* 0x0000000189B53D40-0x0000000189B53D60 */ get => default; /* [XID] */ /* 0x0000000189B5B690-0x0000000189B5B6B0 */ protected set {} } // 0x00000001839F8FE0-0x00000001839F90B0 0x00000001839F9260-0x00000001839F9340
	public uint host_reward_limit { /* [XID] */ /* 0x0000000189B62AC0-0x0000000189B62AE0 */ get => default; /* [XID] */ /* 0x0000000189B6A5B0-0x0000000189B6A5D0 */ protected set {} } // 0x00000001839F8E40-0x00000001839F8F10 0x00000001839F6F20-0x00000001839F7000
	public uint guest_reward_limit { /* [XID] */ /* 0x0000000189B71D30-0x0000000189B71D50 */ get => default; /* [XID] */ /* 0x0000000189B79060-0x0000000189B79080 */ protected set {} } // 0x00000001839F70E0-0x00000001839F71B0 0x00000001839F6BF0-0x00000001839F6CD0
	public uint mp_challenge_index { /* [XID] */ /* 0x0000000189B805B0-0x0000000189B805D0 */ get => default; /* [XID] */ /* 0x0000000189B88140-0x0000000189B88160 */ protected set {} } // 0x00000001839F6E50-0x00000001839F6F20 0x00000001839F8AD0-0x00000001839F8BB0
	public uint bonus_challenge_index { /* [XID] */ /* 0x0000000189B8F3F0-0x0000000189B8F410 */ get => default; /* [XID] */ /* 0x0000000189B96830-0x0000000189B96850 */ protected set {} } // 0x00000001839FA660-0x00000001839FA730 0x00000001839FAF90-0x00000001839FB070
	public uint challenge_gadget_suite { /* [XID] */ /* 0x0000000189B9DD60-0x0000000189B9DD80 */ get => default; /* [XID] */ /* 0x0000000189BA56F0-0x0000000189BA5710 */ protected set {} } // 0x00000001839FA590-0x00000001839FA660 0x00000001839F8BB0-0x00000001839F8C90
	public uint spot_revise_level_id { /* [XID] */ /* 0x0000000189BAC930-0x0000000189BAC950 */ get => default; /* [XID] */ /* 0x0000000189BB41D0-0x0000000189BB41F0 */ protected set {} } // 0x00000001839FAC50-0x00000001839FAD20 0x00000001839F8C90-0x00000001839F8D70
	public uint detector_material_id { /* [XID] */ /* 0x0000000189BBB810-0x0000000189BBB830 */ get => default; /* [XID] */ /* 0x0000000189BC3650-0x0000000189BC3670 */ protected set {} } // 0x00000001839F8D70-0x00000001839F8E40 0x00000001839F6590-0x00000001839F6670
	public uint guide_child_quest_id { /* [XID] */ /* 0x0000000189BCAEB0-0x0000000189BCAED0 */ get => default; /* [XID] */ /* 0x0000000189BD2500-0x0000000189BD2520 */ protected set {} } // 0x00000001839FAEC0-0x00000001839FAF90 0x00000001839FA810-0x00000001839FA8F0

	// Constructors
	public TreasureMapExcelConfig() {} // 0x00000001839FB3F0-0x00000001839FB450

	// Methods
	// [IDTag] // 0x0000000189BD9AA0-0x0000000189BD9AE0
	// [XID] // 0x0000000189BD9AA0-0x0000000189BD9AE0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839F7E60-0x00000001839F8AD0
	// [IDTag] // 0x00000001895E9750-0x00000001895E9790
	// [XID] // 0x00000001895E9750-0x00000001895E9790
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839F71B0-0x00000001839F7E60
	// [XID] // 0x00000001895F3DF0-0x00000001895F3E10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0377 */, bool useObjectPool = false /* Metadata: 0x00AF037B */) => default; // 0x00000001839F9690-0x00000001839FA590
	[BlackList] // 0x00000001895FB6B0-0x00000001895FB6F0
	// [XID] // 0x00000001895FB6B0-0x00000001895FB6F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001839F6900-0x00000001839F69A0
	[BlackList] // 0x0000000189605EF0-0x0000000189605F30
	// [XID] // 0x0000000189605EF0-0x0000000189605F30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839F69A0-0x00000001839F6BF0
	[BlackList] // 0x00000001896107B0-0x00000001896107F0
	// [XID] // 0x00000001896107B0-0x00000001896107F0
	public virtual void ReturnToObjectPool() {} // 0x00000001839FB350-0x00000001839FB3F0
	[BlackList] // 0x000000018961AD80-0x000000018961ADC0
	// [XID] // 0x000000018961AD80-0x000000018961ADC0
	public virtual void OnPoolAllocated() {} // 0x00000001839FB110-0x00000001839FB1B0
	[BlackList] // 0x00000001896251F0-0x0000000189625230
	// [XID] // 0x00000001896251F0-0x0000000189625230
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839FB070-0x00000001839FB110
}

