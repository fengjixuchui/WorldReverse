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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BlossomGroupsExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15271
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32 sectionIdRawNum; // 0x18
	protected SimpleSafeUInt32[] _refreshTypeVec; // 0x20
	protected SimpleSafeUInt32[] _newGroupVec; // 0x28
	protected SimpleSafeUInt32[] _decorateGroupVec; // 0x30
	protected SimpleSafeUInt32[] _nextCampIdVec; // 0x38
	protected bool _is_safe; // 0x40
	protected bool _is_initial_refresh; // 0x41
	protected SimpleSafeUInt32 finish_progressRawNum; // 0x44
	protected SimpleSafeUInt32 limit_levelRawNum; // 0x48
	protected SimpleSafeUInt32 fight_radiusRawNum; // 0x4C
	protected SimpleSafeUInt32 remind_radiusRawNum; // 0x50
	protected uint _blossom_tipsTextMapHash; // 0x54
	protected SimpleSafeUInt32 delay_unload_secRawNum; // 0x58

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897A4FF0-0x00000001897A5010 */ get => default; /* [XID] */ /* 0x00000001897AC5A0-0x00000001897AC5C0 */ protected set {} } // 0x0000000183A76F10-0x0000000183A76FE0 0x0000000183A758F0-0x0000000183A759D0
	public uint cityId { /* [XID] */ /* 0x00000001897B44F0-0x00000001897B4510 */ get => default; /* [XID] */ /* 0x00000001897BC290-0x00000001897BC2B0 */ protected set {} } // 0x0000000183A769E0-0x0000000183A76AB0 0x0000000183A74FD0-0x0000000183A750B0
	public uint sectionId { /* [XID] */ /* 0x00000001897C3950-0x00000001897C3970 */ get => default; /* [XID] */ /* 0x00000001897CB0F0-0x00000001897CB110 */ protected set {} } // 0x0000000183A759D0-0x0000000183A75AA0 0x0000000183A74E40-0x0000000183A74F20
	public SimpleSafeUInt32[] refreshTypeVec { /* [XID] */ /* 0x00000001897D27B0-0x00000001897D27D0 */ get => default; /* [XID] */ /* 0x00000001897DA4B0-0x00000001897DA4D0 */ protected set {} } // 0x0000000183A76720-0x0000000183A767C0 0x0000000183A75380-0x0000000183A75430
	public SimpleSafeUInt32[] newGroupVec { /* [XID] */ /* 0x00000001897E1980-0x00000001897E19A0 */ get => default; /* [XID] */ /* 0x00000001897E9130-0x00000001897E9150 */ protected set {} } // 0x0000000183A75160-0x0000000183A75200 0x0000000183A750B0-0x0000000183A75160
	public SimpleSafeUInt32[] decorateGroupVec { /* [XID] */ /* 0x00000001897F0D40-0x00000001897F0D60 */ get => default; /* [XID] */ /* 0x00000001897F85C0-0x00000001897F85E0 */ protected set {} } // 0x0000000183A752E0-0x0000000183A75380 0x0000000183A75430-0x0000000183A754E0
	public SimpleSafeUInt32[] nextCampIdVec { /* [XID] */ /* 0x00000001897FFC70-0x00000001897FFC90 */ get => default; /* [XID] */ /* 0x0000000189807330-0x0000000189807350 */ protected set {} } // 0x0000000183A74DA0-0x0000000183A74E40 0x0000000183A76670-0x0000000183A76720
	public bool is_safe { /* [XID] */ /* 0x000000018980E930-0x000000018980E950 */ get => default; /* [XID] */ /* 0x0000000189816010-0x0000000189816030 */ protected set {} } // 0x0000000183A76D30-0x0000000183A76DD0 0x0000000183A72B20-0x0000000183A72BD0
	public bool is_initial_refresh { /* [XID] */ /* 0x000000018981DAB0-0x000000018981DAD0 */ get => default; /* [XID] */ /* 0x0000000189824EA0-0x0000000189824EC0 */ protected set {} } // 0x0000000183A767C0-0x0000000183A76860 0x0000000183A72BD0-0x0000000183A72C80
	public uint finish_progress { /* [XID] */ /* 0x000000018982C8B0-0x000000018982C8D0 */ get => default; /* [XID] */ /* 0x0000000189833E40-0x0000000189833E60 */ protected set {} } // 0x0000000183A76C60-0x0000000183A76D30 0x0000000183A76860-0x0000000183A76940
	public uint limit_level { /* [XID] */ /* 0x000000018983B2C0-0x000000018983B2E0 */ get => default; /* [XID] */ /* 0x0000000189842BA0-0x0000000189842BC0 */ protected set {} } // 0x0000000183A72D50-0x0000000183A72E20 0x0000000183A76AB0-0x0000000183A76B90
	public uint fight_radius { /* [XID] */ /* 0x0000000189849F50-0x0000000189849F70 */ get => default; /* [XID] */ /* 0x0000000189851590-0x00000001898515B0 */ protected set {} } // 0x0000000183A754E0-0x0000000183A755B0 0x0000000183A75810-0x0000000183A758F0
	public uint remind_radius { /* [XID] */ /* 0x0000000189858B80-0x0000000189858BA0 */ get => default; /* [XID] */ /* 0x000000018985FCF0-0x000000018985FD10 */ protected set {} } // 0x0000000183A72C80-0x0000000183A72D50 0x0000000183A75200-0x0000000183A752E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint blossom_tipsTextMapHash { /* [XID] */ /* 0x0000000189867410-0x0000000189867430 */ get => default; /* [XID] */ /* 0x000000018986EBB0-0x000000018986EBD0 */ protected set {} } // 0x0000000183A76940-0x0000000183A769E0 0x0000000183A74F20-0x0000000183A74FD0
	public string blossom_tips { /* [XID] */ /* 0x0000000189876040-0x0000000189876060 */ get => default; } // 0x0000000183A75690-0x0000000183A75810 
	public uint delay_unload_sec { /* [XID] */ /* 0x000000018987DC60-0x000000018987DC80 */ get => default; /* [XID] */ /* 0x0000000189884BF0-0x0000000189884C10 */ protected set {} } // 0x0000000183A76B90-0x0000000183A76C60 0x0000000183A755B0-0x0000000183A75690

	// Constructors
	public BlossomGroupsExcelConfig() {} // 0x0000000183A77080-0x0000000183A770E0

	// Methods
	// [IDTag] // 0x000000018988C200-0x000000018988C240
	// [XID] // 0x000000018988C200-0x000000018988C240
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183A73E00-0x0000000183A74DA0
	// [IDTag] // 0x0000000189896600-0x0000000189896640
	// [XID] // 0x0000000189896600-0x0000000189896640
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183A72E20-0x0000000183A73E00
	// [XID] // 0x00000001898A0950-0x00000001898A0970
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05DC */, bool useObjectPool = false /* Metadata: 0x00AF05E0 */) => default; // 0x0000000183A75AA0-0x0000000183A76670
	[BlackList] // 0x00000001898A8030-0x00000001898A8070
	// [XID] // 0x00000001898A8030-0x00000001898A8070
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A72910-0x0000000183A729B0
	[BlackList] // 0x00000001898B2850-0x00000001898B2890
	// [XID] // 0x00000001898B2850-0x00000001898B2890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A729B0-0x0000000183A72B20
	[BlackList] // 0x00000001898BD400-0x00000001898BD440
	// [XID] // 0x00000001898BD400-0x00000001898BD440
	public virtual void ReturnToObjectPool() {} // 0x0000000183A76FE0-0x0000000183A77080
	[BlackList] // 0x00000001898C7B20-0x00000001898C7B60
	// [XID] // 0x00000001898C7B20-0x00000001898C7B60
	public virtual void OnPoolAllocated() {} // 0x0000000183A76E70-0x0000000183A76F10
	[BlackList] // 0x00000001898D2210-0x00000001898D2250
	// [XID] // 0x00000001898D2210-0x00000001898D2250
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A76DD0-0x0000000183A76E70
}

