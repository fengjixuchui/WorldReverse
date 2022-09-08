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
public class LampRegionDataConfig : IAutoAllocRecycle // TypeDefIndex: 15180
{
	// Fields
	protected string _region; // 0x10
	protected SimpleSafeUInt32 factorRawNum; // 0x18

	// Properties
	public string region { /* [XID] */ /* 0x0000000189938730-0x0000000189938750 */ get => default; /* [XID] */ /* 0x00000001899400E0-0x0000000189940100 */ protected set {} } // 0x00000001847724D0-0x0000000184772570 0x0000000184772FE0-0x0000000184773090
	public uint factor { /* [XID] */ /* 0x0000000189947660-0x0000000189947680 */ get => default; /* [XID] */ /* 0x000000018994EE80-0x000000018994EEA0 */ protected set {} } // 0x0000000184773090-0x0000000184773160 0x0000000184772B90-0x0000000184772C70

	// Constructors
	public LampRegionDataConfig() {} // 0x0000000184773340-0x0000000184773490

	// Methods
	// [IDTag] // 0x0000000189956480-0x00000001899564C0
	// [XID] // 0x0000000189956480-0x00000001899564C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184772920-0x0000000184772B90
	// [IDTag] // 0x0000000189960EA0-0x0000000189960EE0
	// [XID] // 0x0000000189960EA0-0x0000000189960EE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001847726F0-0x0000000184772920
	// [XID] // 0x000000018996B450-0x000000018996B470
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0312 */, bool useObjectPool = false /* Metadata: 0x00AF0316 */) => default; // 0x0000000184772C70-0x0000000184772FE0
	[BlackList] // 0x0000000189972F10-0x0000000189972F50
	// [XID] // 0x0000000189972F10-0x0000000189972F50
	public virtual void AutoAllocTypeFields() {} // 0x0000000184772570-0x0000000184772610
	[BlackList] // 0x000000018997CFF0-0x000000018997D030
	// [XID] // 0x000000018997CFF0-0x000000018997D030
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184772610-0x00000001847726F0
	[BlackList] // 0x0000000189987E10-0x0000000189987E50
	// [XID] // 0x0000000189987E10-0x0000000189987E50
	public virtual void ReturnToObjectPool() {} // 0x00000001847732A0-0x0000000184773340
	[BlackList] // 0x0000000189992BB0-0x0000000189992BF0
	// [XID] // 0x0000000189992BB0-0x0000000189992BF0
	public virtual void OnPoolAllocated() {} // 0x0000000184773200-0x00000001847732A0
	[BlackList] // 0x000000018999D570-0x000000018999D5B0
	// [XID] // 0x000000018999D570-0x000000018999D5B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184773160-0x0000000184773200
}

