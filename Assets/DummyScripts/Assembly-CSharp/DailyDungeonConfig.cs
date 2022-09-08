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
public class DailyDungeonConfig : IAutoAllocRecycle // TypeDefIndex: 15553
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _monday; // 0x18
	protected SimpleSafeUInt32[] _tuesday; // 0x20
	protected SimpleSafeUInt32[] _wednesday; // 0x28
	protected SimpleSafeUInt32[] _thursday; // 0x30
	protected SimpleSafeUInt32[] _friday; // 0x38
	protected SimpleSafeUInt32[] _saturday; // 0x40
	protected SimpleSafeUInt32[] _sunday; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BA28D0-0x0000000189BA28F0 */ get => default; /* [XID] */ /* 0x0000000189BA9D00-0x0000000189BA9D20 */ protected set {} } // 0x00000001831073D0-0x00000001831074A0 0x0000000183106920-0x0000000183106A00
	public SimpleSafeUInt32[] monday { /* [XID] */ /* 0x0000000189BB15D0-0x0000000189BB15F0 */ get => default; /* [XID] */ /* 0x0000000189BB8540-0x0000000189BB8560 */ protected set {} } // 0x00000001831065D0-0x0000000183106670 0x0000000183106670-0x0000000183106720
	public SimpleSafeUInt32[] tuesday { /* [XID] */ /* 0x0000000189BBFE90-0x0000000189BBFEB0 */ get => default; /* [XID] */ /* 0x0000000189BC78E0-0x0000000189BC7900 */ protected set {} } // 0x00000001831071F0-0x0000000183107290 0x00000001831074A0-0x0000000183107550
	public SimpleSafeUInt32[] wednesday { /* [XID] */ /* 0x0000000189BCF450-0x0000000189BCF470 */ get => default; /* [XID] */ /* 0x0000000189BD6820-0x0000000189BD6840 */ protected set {} } // 0x0000000183103E40-0x0000000183103EE0 0x0000000183106520-0x00000001831065D0
	public SimpleSafeUInt32[] thursday { /* [XID] */ /* 0x0000000189BDE540-0x0000000189BDE560 */ get => default; /* [XID] */ /* 0x00000001895EB050-0x00000001895EB070 */ protected set {} } // 0x0000000183107150-0x00000001831071F0 0x00000001831067C0-0x0000000183106870
	public SimpleSafeUInt32[] friday { /* [XID] */ /* 0x00000001895F24B0-0x00000001895F24D0 */ get => default; /* [XID] */ /* 0x00000001895F9EE0-0x00000001895F9F00 */ protected set {} } // 0x0000000183104070-0x0000000183104110 0x0000000183106870-0x0000000183106920
	public SimpleSafeUInt32[] saturday { /* [XID] */ /* 0x0000000189601700-0x0000000189601720 */ get => default; /* [XID] */ /* 0x0000000189608F90-0x0000000189608FB0 */ protected set {} } // 0x0000000183106720-0x00000001831067C0 0x0000000183106470-0x0000000183106520
	public SimpleSafeUInt32[] sunday { /* [XID] */ /* 0x0000000189610750-0x0000000189610770 */ get => default; /* [XID] */ /* 0x0000000189617A50-0x0000000189617A70 */ protected set {} } // 0x0000000183103CF0-0x0000000183103D90 0x0000000183103D90-0x0000000183103E40

	// Constructors
	public DailyDungeonConfig() {} // 0x00000001831075F0-0x0000000183107650

	// Methods
	// [IDTag] // 0x000000018961F660-0x000000018961F6A0
	// [XID] // 0x000000018961F660-0x000000018961F6A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183104110-0x00000001831052B0
	// [IDTag] // 0x0000000189629C30-0x0000000189629C70
	// [XID] // 0x0000000189629C30-0x0000000189629C70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001831052B0-0x0000000183106470
	// [XID] // 0x00000001896346B0-0x00000001896346D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EE9 */, bool useObjectPool = false /* Metadata: 0x00AF1EED */) => default; // 0x0000000183106A00-0x0000000183107150
	[BlackList] // 0x000000018963BE20-0x000000018963BE60
	// [XID] // 0x000000018963BE20-0x000000018963BE60
	public virtual void AutoAllocTypeFields() {} // 0x0000000183103EE0-0x0000000183103F80
	[BlackList] // 0x00000001896463E0-0x0000000189646420
	// [XID] // 0x00000001896463E0-0x0000000189646420
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183103F80-0x0000000183104070
	[BlackList] // 0x0000000189650BB0-0x0000000189650BF0
	// [XID] // 0x0000000189650BB0-0x0000000189650BF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183107550-0x00000001831075F0
	[BlackList] // 0x000000018965B470-0x000000018965B4B0
	// [XID] // 0x000000018965B470-0x000000018965B4B0
	public virtual void OnPoolAllocated() {} // 0x0000000183107330-0x00000001831073D0
	[BlackList] // 0x00000001896659F0-0x0000000189665A30
	// [XID] // 0x00000001896659F0-0x0000000189665A30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183107290-0x0000000183107330
}

