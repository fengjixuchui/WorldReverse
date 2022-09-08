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
public class DragonSpinePreviewExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15065
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected SimpleSafeUInt32 preQuestIdRawNum; // 0x1C
	protected SimpleSafeUInt32 unlockLevelRawNum; // 0x20
	protected SimpleSafeUInt32 rewardPreviewIdRawNum; // 0x24
	protected SimpleSafeUInt32 contentDurationRawNum; // 0x28
	protected SimpleSafeUInt32 questIdRawNum; // 0x2C
	protected SimpleSafeUInt32[] _questIdList; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x000000018967DE80-0x000000018967DEA0 */ get => default; /* [XID] */ /* 0x0000000189685680-0x00000001896856A0 */ protected set {} } // 0x0000000184A9A150-0x0000000184A9A220 0x0000000184A99200-0x0000000184A992E0
	public uint activityId { /* [XID] */ /* 0x000000018968D060-0x000000018968D080 */ get => default; /* [XID] */ /* 0x0000000189694BE0-0x0000000189694C00 */ protected set {} } // 0x0000000184A99DB0-0x0000000184A99E80 0x0000000184A99120-0x0000000184A99200
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018969C360-0x000000018969C380 */ get => default; /* [XID] */ /* 0x00000001896A3840-0x00000001896A3860 */ protected set {} } // 0x0000000184A99C40-0x0000000184A99CE0 0x0000000184A97B50-0x0000000184A97C00
	public string desc { /* [XID] */ /* 0x00000001896AACB0-0x00000001896AACD0 */ get => default; } // 0x0000000184A98FA0-0x0000000184A99120 
	public uint preQuestId { /* [XID] */ /* 0x00000001896B1D10-0x00000001896B1D30 */ get => default; /* [XID] */ /* 0x00000001896B97B0-0x00000001896B97D0 */ protected set {} } // 0x0000000184A98D10-0x0000000184A98DE0 0x0000000184A99F30-0x0000000184A9A010
	public uint unlockLevel { /* [XID] */ /* 0x00000001896C0AC0-0x00000001896C0AE0 */ get => default; /* [XID] */ /* 0x00000001896C81B0-0x00000001896C81D0 */ protected set {} } // 0x0000000184A99CE0-0x0000000184A99DB0 0x0000000184A97A70-0x0000000184A97B50
	public uint rewardPreviewId { /* [XID] */ /* 0x00000001896CFB10-0x00000001896CFB30 */ get => default; /* [XID] */ /* 0x00000001896D6DC0-0x00000001896D6DE0 */ protected set {} } // 0x0000000184A98B70-0x0000000184A98C40 0x0000000184A98EC0-0x0000000184A98FA0
	public uint contentDuration { /* [XID] */ /* 0x00000001896DE520-0x00000001896DE540 */ get => default; /* [XID] */ /* 0x00000001896E5910-0x00000001896E5930 */ protected set {} } // 0x0000000184A98C40-0x0000000184A98D10 0x0000000184A99AC0-0x0000000184A99BA0
	public uint questId { /* [XID] */ /* 0x00000001896ECFA0-0x00000001896ECFC0 */ get => default; /* [XID] */ /* 0x00000001896F4860-0x00000001896F4880 */ protected set {} } // 0x0000000184A98AA0-0x0000000184A98B70 0x0000000184A98DE0-0x0000000184A98EC0
	public SimpleSafeUInt32[] questIdList { /* [XID] */ /* 0x00000001896FC010-0x00000001896FC030 */ get => default; /* [XID] */ /* 0x0000000189703630-0x0000000189703650 */ protected set {} } // 0x0000000184A99BA0-0x0000000184A99C40 0x0000000184A99E80-0x0000000184A99F30

	// Constructors
	public DragonSpinePreviewExcelConfig() {} // 0x0000000184A9A2C0-0x0000000184A9A320

	// Methods
	// [IDTag] // 0x000000018970ACC0-0x000000018970AD00
	// [XID] // 0x000000018970ACC0-0x000000018970AD00
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184A97C00-0x0000000184A98350
	// [IDTag] // 0x0000000189715230-0x0000000189715270
	// [XID] // 0x0000000189715230-0x0000000189715270
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184A98350-0x0000000184A98AA0
	// [XID] // 0x000000018971FCD0-0x000000018971FCF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFD9 */, bool useObjectPool = false /* Metadata: 0x00AEFFDD */) => default; // 0x0000000184A992E0-0x0000000184A99AC0
	[BlackList] // 0x0000000189727380-0x00000001897273C0
	// [XID] // 0x0000000189727380-0x00000001897273C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A97880-0x0000000184A97920
	[BlackList] // 0x0000000189731740-0x0000000189731780
	// [XID] // 0x0000000189731740-0x0000000189731780
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A97920-0x0000000184A97A70
	[BlackList] // 0x000000018973C1E0-0x000000018973C220
	// [XID] // 0x000000018973C1E0-0x000000018973C220
	public virtual void ReturnToObjectPool() {} // 0x0000000184A9A220-0x0000000184A9A2C0
	[BlackList] // 0x00000001897469E0-0x0000000189746A20
	// [XID] // 0x00000001897469E0-0x0000000189746A20
	public virtual void OnPoolAllocated() {} // 0x0000000184A9A0B0-0x0000000184A9A150
	[BlackList] // 0x0000000189750FE0-0x0000000189751020
	// [XID] // 0x0000000189750FE0-0x0000000189751020
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A9A010-0x0000000184A9A0B0
}

