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
public class MpPlayStatisticConfig : IAutoAllocRecycle // TypeDefIndex: 15869
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 MpPlayIdRawNum; // 0x14
	protected MpPlayerSettleType _settleType; // 0x18
	protected string[] _settleParam; // 0x20
	protected MpPlayerSettleSyncType _clientSyncType; // 0x28
	protected string _clientSyncParam; // 0x30
	protected uint _mpchallengetitleTextMapHash; // 0x38
	protected uint _mpchallengeTextMapHash; // 0x3C
	protected uint _mpchallengestyleTextMapHash; // 0x40
	protected string _image; // 0x48
	protected SimpleSafeUInt32 priorityRawNum; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899BFEB0-0x00000001899BFED0 */ get => default; /* [XID] */ /* 0x00000001899C7690-0x00000001899C76B0 */ protected set {} } // 0x00000001850DAA30-0x00000001850DAB00 0x00000001850D9980-0x00000001850D9A60
	public uint MpPlayId { /* [XID] */ /* 0x00000001899CEC80-0x00000001899CECA0 */ get => default; /* [XID] */ /* 0x00000001899D63F0-0x00000001899D6410 */ protected set {} } // 0x00000001850D9800-0x00000001850D98D0 0x00000001850D80A0-0x00000001850D8180
	public MpPlayerSettleType settleType { /* [XID] */ /* 0x00000001899DD8A0-0x00000001899DD8C0 */ get => default; /* [XID] */ /* 0x00000001899E56C0-0x00000001899E56E0 */ protected set {} } // 0x00000001850DA650-0x00000001850DA6F0 0x00000001850DA6F0-0x00000001850DA7A0
	public string[] settleParam { /* [XID] */ /* 0x00000001899EC870-0x00000001899EC890 */ get => default; /* [XID] */ /* 0x00000001899F45D0-0x00000001899F45F0 */ protected set {} } // 0x00000001850D9530-0x00000001850D95D0 0x00000001850DA7A0-0x00000001850DA850
	public MpPlayerSettleSyncType clientSyncType { /* [XID] */ /* 0x00000001899FBC50-0x00000001899FBC70 */ get => default; /* [XID] */ /* 0x0000000189A02FF0-0x0000000189A03010 */ protected set {} } // 0x00000001850DA850-0x00000001850DA8F0 0x00000001850D98D0-0x00000001850D9980
	public string clientSyncParam { /* [XID] */ /* 0x0000000189A0A540-0x0000000189A0A560 */ get => default; /* [XID] */ /* 0x0000000189A11E80-0x0000000189A11EA0 */ protected set {} } // 0x00000001850D8000-0x00000001850D80A0 0x00000001850D8180-0x00000001850D8230
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mpchallengetitleTextMapHash { /* [XID] */ /* 0x0000000189A19150-0x0000000189A19170 */ get => default; /* [XID] */ /* 0x0000000189A208F0-0x0000000189A20910 */ protected set {} } // 0x00000001850DA500-0x00000001850DA5A0 0x00000001850D7F50-0x00000001850D8000
	public string mpchallengetitle { /* [XID] */ /* 0x0000000189A27D20-0x0000000189A27D40 */ get => default; } // 0x00000001850D92D0-0x00000001850D9450 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mpchallengeTextMapHash { /* [XID] */ /* 0x0000000189A2F390-0x0000000189A2F3B0 */ get => default; /* [XID] */ /* 0x0000000189A36E10-0x0000000189A36E30 */ protected set {} } // 0x00000001850DA460-0x00000001850DA500 0x00000001850DA5A0-0x00000001850DA650
	public string mpchallenge { /* [XID] */ /* 0x0000000189A3E450-0x0000000189A3E470 */ get => default; } // 0x00000001850D9680-0x00000001850D9800 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mpchallengestyleTextMapHash { /* [XID] */ /* 0x0000000189A45AE0-0x0000000189A45B00 */ get => default; /* [XID] */ /* 0x0000000189A4D260-0x0000000189A4D280 */ protected set {} } // 0x00000001850D9230-0x00000001850D92D0 0x00000001850D8230-0x00000001850D82E0
	public string mpchallengestyle { /* [XID] */ /* 0x0000000189A549B0-0x0000000189A549D0 */ get => default; } // 0x00000001850D7DD0-0x00000001850D7F50 
	public string image { /* [XID] */ /* 0x0000000189A5C420-0x0000000189A5C440 */ get => default; /* [XID] */ /* 0x0000000189A63D90-0x0000000189A63DB0 */ protected set {} } // 0x00000001850D7B80-0x00000001850D7C20 0x00000001850D95D0-0x00000001850D9680
	public uint priority { /* [XID] */ /* 0x0000000189A6B670-0x0000000189A6B690 */ get => default; /* [XID] */ /* 0x0000000189A72DC0-0x0000000189A72DE0 */ protected set {} } // 0x00000001850DA390-0x00000001850DA460 0x00000001850D9450-0x00000001850D9530

	// Constructors
	public MpPlayStatisticConfig() {} // 0x00000001850DABA0-0x00000001850DAC00

	// Methods
	// [IDTag] // 0x0000000189A7A950-0x0000000189A7A990
	// [XID] // 0x0000000189A7A950-0x0000000189A7A990
	public virtual bool ParseFromLine(string line) => default; // 0x00000001850D8A70-0x00000001850D9230
	// [IDTag] // 0x0000000189A84F20-0x0000000189A84F60
	// [XID] // 0x0000000189A84F20-0x0000000189A84F60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001850D82E0-0x00000001850D8A70
	// [XID] // 0x0000000189A8F870-0x0000000189A8F890
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28EC */, bool useObjectPool = false /* Metadata: 0x00AF28F0 */) => default; // 0x00000001850D9A60-0x00000001850DA390
	[BlackList] // 0x0000000189A96E80-0x0000000189A96EC0
	// [XID] // 0x0000000189A96E80-0x0000000189A96EC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001850D7C20-0x00000001850D7CC0
	[BlackList] // 0x0000000189AA11E0-0x0000000189AA1220
	// [XID] // 0x0000000189AA11E0-0x0000000189AA1220
	public virtual void AutoRecycleTypeFields() {} // 0x00000001850D7CC0-0x00000001850D7DD0
	[BlackList] // 0x0000000189AABB30-0x0000000189AABB70
	// [XID] // 0x0000000189AABB30-0x0000000189AABB70
	public virtual void ReturnToObjectPool() {} // 0x00000001850DAB00-0x00000001850DABA0
	[BlackList] // 0x0000000189AB6480-0x0000000189AB64C0
	// [XID] // 0x0000000189AB6480-0x0000000189AB64C0
	public virtual void OnPoolAllocated() {} // 0x00000001850DA990-0x00000001850DAA30
	[BlackList] // 0x0000000189AC0D30-0x0000000189AC0D70
	// [XID] // 0x0000000189AC0D30-0x0000000189AC0D70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001850DA8F0-0x00000001850DA990
}

