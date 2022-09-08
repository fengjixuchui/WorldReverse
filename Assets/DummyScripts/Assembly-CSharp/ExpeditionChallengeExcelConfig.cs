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
public class ExpeditionChallengeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15091
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 unlockTimeRawNum; // 0x14
	protected SimpleSafeUInt32 groupIdRawNum; // 0x18
	protected SimpleSafeUInt32 rewardChallengeIndexRawNum; // 0x1C
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x20
	protected uint _challengeNameTextMapHash; // 0x24
	protected uint _challengeDescTextMapHash; // 0x28
	protected string _superElement; // 0x30
	protected SimpleSafeFloat[] _centerPosList; // 0x38
	protected SimpleSafeUInt32 centerRadiusRawNum; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189848520-0x0000000189848540 */ get => default; /* [XID] */ /* 0x000000018984FCA0-0x000000018984FCC0 */ protected set {} } // 0x0000000181A95C90-0x0000000181A95D60 0x0000000181A94B30-0x0000000181A94C10
	public uint unlockTime { /* [XID] */ /* 0x00000001898570E0-0x0000000189857100 */ get => default; /* [XID] */ /* 0x000000018985E2B0-0x000000018985E2D0 */ protected set {} } // 0x0000000181A936E0-0x0000000181A937B0 0x0000000181A932A0-0x0000000181A93380
	public uint groupId { /* [XID] */ /* 0x0000000189865C70-0x0000000189865C90 */ get => default; /* [XID] */ /* 0x000000018986D1B0-0x000000018986D1D0 */ protected set {} } // 0x0000000181A95900-0x0000000181A959D0 0x0000000181A959D0-0x0000000181A95AB0
	public uint rewardChallengeIndex { /* [XID] */ /* 0x00000001898745A0-0x00000001898745C0 */ get => default; /* [XID] */ /* 0x000000018987C180-0x000000018987C1A0 */ protected set {} } // 0x0000000181A956B0-0x0000000181A95780 0x0000000181A94980-0x0000000181A94A60
	public uint rewardId { /* [XID] */ /* 0x0000000189883310-0x0000000189883330 */ get => default; /* [XID] */ /* 0x000000018988AA70-0x000000018988AA90 */ protected set {} } // 0x0000000181A955E0-0x0000000181A956B0 0x0000000181A93030-0x0000000181A93110
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeNameTextMapHash { /* [XID] */ /* 0x0000000189891F80-0x0000000189891FA0 */ get => default; /* [XID] */ /* 0x0000000189899910-0x0000000189899930 */ protected set {} } // 0x0000000181A95D60-0x0000000181A95E00 0x0000000181A94C10-0x0000000181A94CC0
	public string challengeName { /* [XID] */ /* 0x00000001898A0A30-0x00000001898A0A50 */ get => default; } // 0x0000000181A93560-0x0000000181A936E0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint challengeDescTextMapHash { /* [XID] */ /* 0x00000001898A80B0-0x00000001898A80D0 */ get => default; /* [XID] */ /* 0x00000001898AFC10-0x00000001898AFC30 */ protected set {} } // 0x0000000181A95AB0-0x0000000181A95B50 0x0000000181A931F0-0x0000000181A932A0
	public string challengeDesc { /* [XID] */ /* 0x00000001898B7110-0x00000001898B7130 */ get => default; } // 0x0000000181A95780-0x0000000181A95900 
	public string superElement { /* [XID] */ /* 0x00000001898BE880-0x00000001898BE8A0 */ get => default; /* [XID] */ /* 0x00000001898C6050-0x00000001898C6070 */ protected set {} } // 0x0000000181A948E0-0x0000000181A94980 0x0000000181A937B0-0x0000000181A93860
	public SimpleSafeFloat[] centerPosList { /* [XID] */ /* 0x00000001898CD7A0-0x00000001898CD7C0 */ get => default; /* [XID] */ /* 0x00000001898D5330-0x00000001898D5350 */ protected set {} } // 0x0000000181A95540-0x0000000181A955E0 0x0000000181A94830-0x0000000181A948E0
	public uint centerRadius { /* [XID] */ /* 0x00000001898DCC10-0x00000001898DCC30 */ get => default; /* [XID] */ /* 0x00000001898E4640-0x00000001898E4660 */ protected set {} } // 0x0000000181A94A60-0x0000000181A94B30 0x0000000181A93110-0x0000000181A931F0

	// Constructors
	public ExpeditionChallengeExcelConfig() {} // 0x0000000181A95EA0-0x0000000181A95F00

	// Methods
	// [IDTag] // 0x00000001898EC070-0x00000001898EC0B0
	// [XID] // 0x00000001898EC070-0x00000001898EC0B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181A94050-0x0000000181A94830
	// [IDTag] // 0x00000001898F6AA0-0x00000001898F6AE0
	// [XID] // 0x00000001898F6AA0-0x00000001898F6AE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181A93860-0x0000000181A94050
	// [XID] // 0x0000000189901390-0x00000001899013B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0094 */, bool useObjectPool = false /* Metadata: 0x00AF0098 */) => default; // 0x0000000181A94CC0-0x0000000181A95540
	[BlackList] // 0x0000000189908B30-0x0000000189908B70
	// [XID] // 0x0000000189908B30-0x0000000189908B70
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A93380-0x0000000181A93420
	[BlackList] // 0x00000001899134A0-0x00000001899134E0
	// [XID] // 0x00000001899134A0-0x00000001899134E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A93420-0x0000000181A93560
	[BlackList] // 0x000000018991DCF0-0x000000018991DD30
	// [XID] // 0x000000018991DCF0-0x000000018991DD30
	public virtual void ReturnToObjectPool() {} // 0x0000000181A95E00-0x0000000181A95EA0
	[BlackList] // 0x0000000189928550-0x0000000189928590
	// [XID] // 0x0000000189928550-0x0000000189928590
	public virtual void OnPoolAllocated() {} // 0x0000000181A95BF0-0x0000000181A95C90
	[BlackList] // 0x0000000189932B40-0x0000000189932B80
	// [XID] // 0x0000000189932B40-0x0000000189932B80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A95B50-0x0000000181A95BF0
}

