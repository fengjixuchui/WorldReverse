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
public class EntityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15397
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected byte _prefabPathHashPre; // 0x18
	protected uint _prefabPathHashSuffix; // 0x1C
	protected byte _prefabPathRemoteHashPre; // 0x20
	protected uint _prefabPathRemoteHashSuffix; // 0x24
	protected byte _controllerPathHashPre; // 0x28
	protected uint _controllerPathHashSuffix; // 0x2C
	protected byte _controllerPathRemoteHashPre; // 0x30
	protected uint _controllerPathRemoteHashSuffix; // 0x34
	protected SimpleSafeUInt32 campIDRawNum; // 0x38
	protected string _LODPatternName; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x000000018960BF60-0x000000018960BF80 */ get => default; /* [XID] */ /* 0x00000001896134E0-0x0000000189613500 */ protected set {} } // 0x00000001829357D0-0x00000001829358A0 0x0000000182934560-0x0000000182934640
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x000000018961AD20-0x000000018961AD40 */ get => default; /* [XID] */ /* 0x0000000189622320-0x0000000189622340 */ protected set {} } // 0x00000001829336E0-0x0000000182933780 0x0000000182935100-0x00000001829351B0
	public string name { /* [XID] */ /* 0x0000000189629CB0-0x0000000189629CD0 */ get => default; } // 0x0000000182935950-0x0000000182935AD0 
	public byte prefabPathHashPre { /* [XID] */ /* 0x00000001896314C0-0x00000001896314E0 */ get => default; /* [XID] */ /* 0x0000000189638F30-0x0000000189638F50 */ protected set {} } // 0x0000000182933820-0x00000001829338C0 0x0000000182933F30-0x0000000182933FE0
	public uint prefabPathHashSuffix { /* [XID] */ /* 0x00000001896402F0-0x0000000189640310 */ get => default; /* [XID] */ /* 0x0000000189647B50-0x0000000189647B70 */ protected set {} } // 0x00000001829354B0-0x0000000182935550 0x00000001829358A0-0x0000000182935950
	public ulong prefabPathHash { /* [XID] */ /* 0x000000018964F220-0x000000018964F240 */ get => default; } // 0x0000000182934200-0x00000001829342D0 
	public byte prefabPathRemoteHashPre { /* [XID] */ /* 0x0000000189656BB0-0x0000000189656BD0 */ get => default; /* [XID] */ /* 0x000000018965E2D0-0x000000018965E2F0 */ protected set {} } // 0x0000000182933780-0x0000000182933820 0x0000000182935400-0x00000001829354B0
	public uint prefabPathRemoteHashSuffix { /* [XID] */ /* 0x0000000189665A50-0x0000000189665A70 */ get => default; /* [XID] */ /* 0x000000018966D100-0x000000018966D120 */ protected set {} } // 0x00000001829355F0-0x0000000182935690 0x0000000182934640-0x00000001829346F0
	public ulong prefabPathRemoteHash { /* [XID] */ /* 0x0000000189675030-0x0000000189675050 */ get => default; } // 0x0000000182933E60-0x0000000182933F30 
	public byte controllerPathHashPre { /* [XID] */ /* 0x00000001897E0790-0x00000001897E07B0 */ get => default; /* [XID] */ /* 0x0000000189683EB0-0x0000000189683ED0 */ protected set {} } // 0x0000000182934370-0x0000000182934410 0x00000001829344B0-0x0000000182934560
	public uint controllerPathHashSuffix { /* [XID] */ /* 0x000000018968BA50-0x000000018968BA70 */ get => default; /* [XID] */ /* 0x00000001896936A0-0x00000001896936C0 */ protected set {} } // 0x0000000182933FE0-0x0000000182934080 0x0000000182935280-0x0000000182935330
	public ulong controllerPathHash { /* [XID] */ /* 0x000000018969A990-0x000000018969A9B0 */ get => default; } // 0x0000000182934130-0x0000000182934200 
	public byte controllerPathRemoteHashPre { /* [XID] */ /* 0x00000001896A2420-0x00000001896A2440 */ get => default; /* [XID] */ /* 0x00000001896A9600-0x00000001896A9620 */ protected set {} } // 0x00000001829342D0-0x0000000182934370 0x0000000182934FA0-0x0000000182935050
	public uint controllerPathRemoteHashSuffix { /* [XID] */ /* 0x0000000189B7AE80-0x0000000189B7AEA0 */ get => default; /* [XID] */ /* 0x00000001896B8110-0x00000001896B8130 */ protected set {} } // 0x0000000182934410-0x00000001829344B0 0x0000000182935050-0x0000000182935100
	public ulong controllerPathRemoteHash { /* [XID] */ /* 0x00000001896BF1F0-0x00000001896BF210 */ get => default; } // 0x0000000182935330-0x0000000182935400 
	public uint campID { /* [XID] */ /* 0x00000001896C6A50-0x00000001896C6A70 */ get => default; /* [XID] */ /* 0x00000001896CE190-0x00000001896CE1B0 */ protected set {} } // 0x00000001829351B0-0x0000000182935280 0x0000000182933600-0x00000001829336E0
	public string LODPatternName { /* [XID] */ /* 0x00000001896D5760-0x00000001896D5780 */ get => default; /* [XID] */ /* 0x00000001896DCB80-0x00000001896DCBA0 */ protected set {} } // 0x0000000182935550-0x00000001829355F0 0x0000000182934080-0x0000000182934130

	// Constructors
	public EntityExcelConfig() {} // 0x0000000182935B70-0x0000000182935BD0

	// Methods
	// [XID] // 0x00000001896E4550-0x00000001896E4570
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829338C0-0x0000000182933E60
	// [XID] // 0x00000001896EB940-0x00000001896EB960
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF141F */, bool useObjectPool = false /* Metadata: 0x00AF1423 */) => default; // 0x00000001829346F0-0x0000000182934FA0
	[BlackList] // 0x00000001896F2E70-0x00000001896F2EB0
	// [XID] // 0x00000001896F2E70-0x00000001896F2EB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182933460-0x0000000182933500
	[BlackList] // 0x00000001896FD810-0x00000001896FD850
	// [XID] // 0x00000001896FD810-0x00000001896FD850
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182933500-0x0000000182933600
	[BlackList] // 0x0000000189707C30-0x0000000189707C70
	// [XID] // 0x0000000189707C30-0x0000000189707C70
	public virtual void ReturnToObjectPool() {} // 0x0000000182935AD0-0x0000000182935B70
	[BlackList] // 0x0000000189712570-0x00000001897125B0
	// [XID] // 0x0000000189712570-0x00000001897125B0
	public virtual void OnPoolAllocated() {} // 0x0000000182935730-0x00000001829357D0
	[BlackList] // 0x000000018971CC80-0x000000018971CCC0
	// [XID] // 0x000000018971CC80-0x000000018971CCC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182935690-0x0000000182935730
}

