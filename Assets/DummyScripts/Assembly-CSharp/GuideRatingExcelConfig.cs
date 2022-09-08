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
public class GuideRatingExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15689
{
	// Fields
	protected SimpleSafeUInt32 channelIDRawNum; // 0x10
	protected SimpleSafeUInt32 subChannelIdRawNum; // 0x14
	protected bool _isChinaServer; // 0x18
	protected GuidePlatformType _platform; // 0x1C
	protected string _url; // 0x20

	// Properties
	public uint channelID { /* [XID] */ /* 0x00000001899B4160-0x00000001899B4180 */ get => default; /* [XID] */ /* 0x00000001899BB5D0-0x00000001899BB5F0 */ protected set {} } // 0x00000001836ABB20-0x00000001836ABBF0 0x00000001836AB290-0x00000001836AB370
	public uint subChannelId { /* [XID] */ /* 0x00000001899C31E0-0x00000001899C3200 */ get => default; /* [XID] */ /* 0x00000001899CA600-0x00000001899CA620 */ protected set {} } // 0x00000001836ABA50-0x00000001836ABB20 0x00000001836AB370-0x00000001836AB450
	public bool isChinaServer { /* [XID] */ /* 0x00000001899D1DC0-0x00000001899D1DE0 */ get => default; /* [XID] */ /* 0x00000001899D91D0-0x00000001899D91F0 */ protected set {} } // 0x00000001836ABBF0-0x00000001836ABC90 0x00000001836ABDD0-0x00000001836ABE80
	public GuidePlatformType platform { /* [XID] */ /* 0x00000001899E0980-0x00000001899E09A0 */ get => default; /* [XID] */ /* 0x00000001899E8480-0x00000001899E84A0 */ protected set {} } // 0x00000001836AA9C0-0x00000001836AAA60 0x00000001836AB450-0x00000001836AB500
	public string url { /* [XID] */ /* 0x00000001899EFAF0-0x00000001899EFB10 */ get => default; /* [XID] */ /* 0x00000001899F7210-0x00000001899F7230 */ protected set {} } // 0x00000001836AB1F0-0x00000001836AB290 0x00000001836ABE80-0x00000001836ABF30

	// Constructors
	public GuideRatingExcelConfig() {} // 0x00000001836ABFD0-0x00000001836AC030

	// Methods
	// [IDTag] // 0x00000001899FE930-0x00000001899FE970
	// [XID] // 0x00000001899FE930-0x00000001899FE970
	public virtual bool ParseFromLine(string line) => default; // 0x00000001836AAE10-0x00000001836AB1F0
	// [IDTag] // 0x0000000189A08E10-0x0000000189A08E50
	// [XID] // 0x0000000189A08E10-0x0000000189A08E50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001836AAA60-0x00000001836AAE10
	// [XID] // 0x0000000189A136A0-0x0000000189A136C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2326 */, bool useObjectPool = false /* Metadata: 0x00AF232A */) => default; // 0x00000001836AB500-0x00000001836ABA50
	[BlackList] // 0x0000000189A1A7D0-0x0000000189A1A810
	// [XID] // 0x0000000189A1A7D0-0x0000000189A1A810
	public virtual void AutoAllocTypeFields() {} // 0x00000001836AA830-0x00000001836AA8D0
	[BlackList] // 0x0000000189A24E10-0x0000000189A24E50
	// [XID] // 0x0000000189A24E10-0x0000000189A24E50
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836AA8D0-0x00000001836AA9C0
	[BlackList] // 0x0000000189A2F3F0-0x0000000189A2F430
	// [XID] // 0x0000000189A2F3F0-0x0000000189A2F430
	public virtual void ReturnToObjectPool() {} // 0x00000001836ABF30-0x00000001836ABFD0
	[BlackList] // 0x0000000189A39B70-0x0000000189A39BB0
	// [XID] // 0x0000000189A39B70-0x0000000189A39BB0
	public virtual void OnPoolAllocated() {} // 0x00000001836ABD30-0x00000001836ABDD0
	[BlackList] // 0x0000000189A44450-0x0000000189A44490
	// [XID] // 0x0000000189A44450-0x0000000189A44490
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836ABC90-0x00000001836ABD30
}

