/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigJobData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18954
{
	// Fields
	private Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigJob>> _jobMapData; // 0x10

	// Properties
	public Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigJob>> jobMapData { /* [XID] */ /* 0x0000000189903D10-0x0000000189903D30 */ get => default; /* [XID] */ /* 0x000000018990B250-0x000000018990B270 */ private set {} } // 0x0000000183A1E5D0-0x0000000183A1E670 0x0000000183A1EA80-0x0000000183A1EB30

	// Constructors
	public ConfigJobData() {} // 0x0000000183A1EBD0-0x0000000183A1EC30

	// Methods
	// [XID] // 0x0000000189912E80-0x0000000189912EA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A1E860-0x0000000183A1E940
	// [XID] // 0x000000018991A750-0x000000018991A770
	public void InitEmpty() {} // 0x0000000183A1E200-0x0000000183A1E2D0
	[BlackList] // 0x0000000189921F00-0x0000000189921F40
	// [XID] // 0x0000000189921F00-0x0000000189921F40
	public bool FromJson(JSONNode node) => default; // 0x0000000183A1DE80-0x0000000183A1E200
	// [XID] // 0x000000018992C400-0x000000018992C420
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A1D680-0x0000000183A1D860
	// [XID] // 0x0000000189933A00-0x0000000189933A20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB509 */, bool useObjectPool = false /* Metadata: 0x00AFB50D */) => default; // 0x0000000183A1E2D0-0x0000000183A1E5D0
	// [XID] // 0x00000001898D7210-0x00000001898D7230
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB50E */, bool useObjectPool = false /* Metadata: 0x00AFB512 */) => default; // 0x0000000183A1DC70-0x0000000183A1DE80
	[BlackList] // 0x0000000189942650-0x0000000189942690
	// [XID] // 0x0000000189942650-0x0000000189942690
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A1D860-0x0000000183A1DB30
	// [XID] // 0x000000018994CE30-0x000000018994CE50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A1E670-0x0000000183A1E860
	[BlackList] // 0x0000000189954620-0x0000000189954660
	// [XID] // 0x0000000189954620-0x0000000189954660
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A1DB30-0x0000000183A1DBD0
	[BlackList] // 0x000000018995F030-0x000000018995F070
	// [XID] // 0x000000018995F030-0x000000018995F070
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A1DBD0-0x0000000183A1DC70
	[BlackList] // 0x0000000189969680-0x00000001899696C0
	// [XID] // 0x0000000189969680-0x00000001899696C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183A1EB30-0x0000000183A1EBD0
	[BlackList] // 0x00000001899740D0-0x0000000189974110
	// [XID] // 0x00000001899740D0-0x0000000189974110
	public virtual void OnPoolAllocated() {} // 0x0000000183A1E9E0-0x0000000183A1EA80
	[BlackList] // 0x000000018997E300-0x000000018997E340
	// [XID] // 0x000000018997E300-0x000000018997E340
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A1E940-0x0000000183A1E9E0
}

