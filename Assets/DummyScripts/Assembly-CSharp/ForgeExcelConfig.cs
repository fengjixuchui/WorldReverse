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
public class ForgeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15621
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 playerLevelRawNum; // 0x14
	protected bool _isDefaultShow; // 0x18
	protected SimpleSafeUInt32[] _effectiveWorldLevels; // 0x20
	protected SimpleSafeUInt32 forgeTypeRawNum; // 0x28
	protected SimpleSafeUInt32 showItemIdRawNum; // 0x2C
	protected SimpleSafeUInt32 resultItemIdRawNum; // 0x30
	protected SimpleSafeUInt32 resultItemCountRawNum; // 0x34
	protected SimpleSafeUInt32 mainRandomDropIdRawNum; // 0x38
	protected SimpleSafeUInt32 mainForgeRandomIdRawNum; // 0x3C
	protected SimpleSafeUInt32 forgeTimeRawNum; // 0x40
	protected SimpleSafeUInt32 queueNumRawNum; // 0x44
	protected SimpleSafeUInt32 scoinCostRawNum; // 0x48
	protected RandomItemConfig[] _randomItems; // 0x50
	protected IdCountConfig[] _materialItems; // 0x58
	protected SimpleSafeUInt32 priorityRawNum; // 0x60
	protected SimpleSafeUInt32 forgePointRawNum; // 0x64
	protected uint _forgePointNoticeTextMapHash; // 0x68

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AF1B10-0x0000000189AF1B30 */ get => default; /* [XID] */ /* 0x0000000189AF92F0-0x0000000189AF9310 */ protected set {} } // 0x00000001845C2670-0x00000001845C2740 0x00000001845C07C0-0x00000001845C08A0
	public uint playerLevel { /* [XID] */ /* 0x0000000189B007B0-0x0000000189B007D0 */ get => default; /* [XID] */ /* 0x0000000189B07E50-0x0000000189B07E70 */ protected set {} } // 0x00000001845C1CC0-0x00000001845C1D90 0x00000001845BE300-0x00000001845BE3E0
	public bool isDefaultShow { /* [XID] */ /* 0x0000000189B0F610-0x0000000189B0F630 */ get => default; /* [XID] */ /* 0x0000000189B16950-0x0000000189B16970 */ protected set {} } // 0x00000001845C0720-0x00000001845C07C0 0x00000001845C2240-0x00000001845C22F0
	public SimpleSafeUInt32[] effectiveWorldLevels { /* [XID] */ /* 0x0000000189B1DFF0-0x0000000189B1E010 */ get => default; /* [XID] */ /* 0x0000000189B258C0-0x0000000189B258E0 */ protected set {} } // 0x00000001845C0980-0x00000001845C0A20 0x00000001845C0090-0x00000001845C0140
	public uint forgeType { /* [XID] */ /* 0x0000000189B2CD50-0x0000000189B2CD70 */ get => default; /* [XID] */ /* 0x0000000189B341C0-0x0000000189B341E0 */ protected set {} } // 0x00000001845BDD80-0x00000001845BDE50 0x00000001845C0300-0x00000001845C03E0
	public uint showItemId { /* [XID] */ /* 0x0000000189B3BBD0-0x0000000189B3BBF0 */ get => default; /* [XID] */ /* 0x0000000189B43590-0x0000000189B435B0 */ protected set {} } // 0x00000001845C1F10-0x00000001845C1FE0 0x00000001845C1B10-0x00000001845C1BF0
	public uint resultItemId { /* [XID] */ /* 0x0000000189B4AD90-0x0000000189B4ADB0 */ get => default; /* [XID] */ /* 0x0000000189B523A0-0x0000000189B523C0 */ protected set {} } // 0x00000001845C22F0-0x00000001845C23C0 0x00000001845C0220-0x00000001845C0300
	public uint resultItemCount { /* [XID] */ /* 0x0000000189B59D60-0x0000000189B59D80 */ get => default; /* [XID] */ /* 0x0000000189B61490-0x0000000189B614B0 */ protected set {} } // 0x00000001845C1E40-0x00000001845C1F10 0x00000001845BDE50-0x00000001845BDF30
	public uint mainRandomDropId { /* [XID] */ /* 0x0000000189B68F60-0x0000000189B68F80 */ get => default; /* [XID] */ /* 0x0000000189B70340-0x0000000189B70360 */ protected set {} } // 0x00000001845C0650-0x00000001845C0720 0x00000001845C2740-0x00000001845C2820
	public uint mainForgeRandomId { /* [XID] */ /* 0x0000000189B77830-0x0000000189B77850 */ get => default; /* [XID] */ /* 0x0000000189B7EE40-0x0000000189B7EE60 */ protected set {} } // 0x00000001845C03E0-0x00000001845C04B0 0x00000001845BFFB0-0x00000001845C0090
	public uint forgeTime { /* [XID] */ /* 0x0000000189B86980-0x0000000189B869A0 */ get => default; /* [XID] */ /* 0x0000000189B8DB10-0x0000000189B8DB30 */ protected set {} } // 0x00000001845C0580-0x00000001845C0650 0x00000001845C08A0-0x00000001845C0980
	public uint queueNum { /* [XID] */ /* 0x0000000189B95010-0x0000000189B95030 */ get => default; /* [XID] */ /* 0x0000000189B9C760-0x0000000189B9C780 */ protected set {} } // 0x00000001845C1BF0-0x00000001845C1CC0 0x00000001845C1A30-0x00000001845C1B10
	public uint scoinCost { /* [XID] */ /* 0x0000000189BA3E30-0x0000000189BA3E50 */ get => default; /* [XID] */ /* 0x0000000189BAB3A0-0x0000000189BAB3C0 */ protected set {} } // 0x00000001845C04B0-0x00000001845C0580 0x00000001845C20C0-0x00000001845C21A0
	public RandomItemConfig[] randomItems { /* [XID] */ /* 0x0000000189BB2970-0x0000000189BB2990 */ get => default; /* [XID] */ /* 0x0000000189BB9DC0-0x0000000189BB9DE0 */ protected set {} } // 0x00000001845BE3E0-0x00000001845BE480 0x00000001845BDF30-0x00000001845BDFE0
	public IdCountConfig[] materialItems { /* [XID] */ /* 0x0000000189BC1D70-0x0000000189BC1D90 */ get => default; /* [XID] */ /* 0x0000000189BC92E0-0x0000000189BC9300 */ protected set {} } // 0x00000001845C21A0-0x00000001845C2240 0x00000001845BE250-0x00000001845BE300
	public uint priority { /* [XID] */ /* 0x0000000189BD0B10-0x0000000189BD0B30 */ get => default; /* [XID] */ /* 0x0000000189BD8090-0x0000000189BD80B0 */ protected set {} } // 0x00000001845C17E0-0x00000001845C18B0 0x00000001845C0140-0x00000001845C0220
	public uint forgePoint { /* [XID] */ /* 0x0000000189BDFC00-0x0000000189BDFC20 */ get => default; /* [XID] */ /* 0x00000001895EC7B0-0x00000001895EC7D0 */ protected set {} } // 0x00000001845C2460-0x00000001845C2530 0x00000001845C1FE0-0x00000001845C20C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint forgePointNoticeTextMapHash { /* [XID] */ /* 0x00000001895F3D70-0x00000001895F3D90 */ get => default; /* [XID] */ /* 0x00000001895FB630-0x00000001895FB650 */ protected set {} } // 0x00000001845C23C0-0x00000001845C2460 0x00000001845C1D90-0x00000001845C1E40
	public string forgePointNotice { /* [XID] */ /* 0x0000000189602D70-0x0000000189602D90 */ get => default; } // 0x00000001845C18B0-0x00000001845C1A30 

	// Constructors
	public ForgeExcelConfig() {} // 0x00000001845C28C0-0x00000001845C2920

	// Methods
	// [IDTag] // 0x000000018960A750-0x000000018960A790
	// [XID] // 0x000000018960A750-0x000000018960A790
	public virtual bool ParseFromLine(string line) => default; // 0x00000001845BF190-0x00000001845BFFB0
	// [IDTag] // 0x0000000189614E20-0x0000000189614E60
	// [XID] // 0x0000000189614E20-0x0000000189614E60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845BE480-0x00000001845BF190
	// [XID] // 0x000000018961F620-0x000000018961F640
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20D5 */, bool useObjectPool = false /* Metadata: 0x00AF20D9 */) => default; // 0x00000001845C0A20-0x00000001845C17E0
	[BlackList] // 0x0000000189626A20-0x0000000189626A60
	// [XID] // 0x0000000189626A20-0x0000000189626A60
	public virtual void AutoAllocTypeFields() {} // 0x00000001845BDFE0-0x00000001845BE080
	[BlackList] // 0x0000000189631440-0x0000000189631480
	// [XID] // 0x0000000189631440-0x0000000189631480
	public virtual void AutoRecycleTypeFields() {} // 0x00000001845BE080-0x00000001845BE250
	[BlackList] // 0x000000018963BDE0-0x000000018963BE20
	// [XID] // 0x000000018963BDE0-0x000000018963BE20
	public virtual void ReturnToObjectPool() {} // 0x00000001845C2820-0x00000001845C28C0
	[BlackList] // 0x00000001896463A0-0x00000001896463E0
	// [XID] // 0x00000001896463A0-0x00000001896463E0
	public virtual void OnPoolAllocated() {} // 0x00000001845C25D0-0x00000001845C2670
	[BlackList] // 0x0000000189650B50-0x0000000189650B90
	// [XID] // 0x0000000189650B50-0x0000000189650B90
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845C2530-0x00000001845C25D0
}

