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
public class ConfigControllerSubs : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17735
{
	// Fields
	private string _path; // 0x10
	private string _subsName; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigNormalStateIDInfo> _stateIDs; // 0x20

	// Properties
	public string path { /* [XID] */ /* 0x00000001896DC7A0-0x00000001896DC7C0 */ get => default; /* [XID] */ /* 0x00000001896E4090-0x00000001896E40B0 */ private set {} } // 0x00000001849C57E0-0x00000001849C5880 0x00000001849C5730-0x00000001849C57E0
	public string subsName { /* [XID] */ /* 0x00000001896EB5A0-0x00000001896EB5C0 */ get => default; /* [XID] */ /* 0x00000001896F2950-0x00000001896F2970 */ private set {} } // 0x00000001849C5880-0x00000001849C5920 0x00000001849C4BC0-0x00000001849C4C70
	public Dictionary<string, ConfigNormalStateIDInfo> stateIDs { /* [XID] */ /* 0x00000001896FA1B0-0x00000001896FA1D0 */ get => default; /* [XID] */ /* 0x0000000189701980-0x00000001897019A0 */ private set {} } // 0x00000001849C5E70-0x00000001849C5F10 0x00000001849C5F10-0x00000001849C5FC0

	// Constructors
	public ConfigControllerSubs() {} // 0x00000001849C6060-0x00000001849C60C0

	// Methods
	// [XID] // 0x0000000189709280-0x00000001897092A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849C5C10-0x00000001849C5D30
	// [XID] // 0x0000000189710AB0-0x0000000189710AD0
	public void InitEmpty() {} // 0x00000001849C5340-0x00000001849C5430
	[BlackList] // 0x0000000189717E10-0x0000000189717E50
	// [XID] // 0x0000000189717E10-0x0000000189717E50
	public bool FromJson(JSONNode node) => default; // 0x00000001849C4FC0-0x00000001849C5340
	// [XID] // 0x0000000189722580-0x00000001897225A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001849C43E0-0x00000001849C4780
	// [XID] // 0x0000000189729C40-0x0000000189729C60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7A2D */, bool useObjectPool = false /* Metadata: 0x00AF7A31 */) => default; // 0x00000001849C5430-0x00000001849C5730
	// [XID] // 0x0000000189731300-0x0000000189731320
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7A32 */, bool useObjectPool = false /* Metadata: 0x00AF7A36 */) => default; // 0x00000001849C4C70-0x00000001849C4FC0
	[BlackList] // 0x0000000189738B10-0x0000000189738B50
	// [XID] // 0x0000000189738B10-0x0000000189738B50
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001849C4780-0x00000001849C4A50
	// [XID] // 0x00000001897434D0-0x00000001897434F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849C5920-0x00000001849C5C10
	[BlackList] // 0x000000018974B120-0x000000018974B160
	// [XID] // 0x000000018974B120-0x000000018974B160
	public virtual void AutoAllocTypeFields() {} // 0x00000001849C4A50-0x00000001849C4AF0
	[BlackList] // 0x0000000189755630-0x0000000189755670
	// [XID] // 0x0000000189755630-0x0000000189755670
	public virtual void AutoRecycleTypeFields() {} // 0x00000001849C4AF0-0x00000001849C4BC0
	[BlackList] // 0x000000018975FB10-0x000000018975FB50
	// [XID] // 0x000000018975FB10-0x000000018975FB50
	public virtual void ReturnToObjectPool() {} // 0x00000001849C5FC0-0x00000001849C6060
	[BlackList] // 0x000000018976A070-0x000000018976A0B0
	// [XID] // 0x000000018976A070-0x000000018976A0B0
	public virtual void OnPoolAllocated() {} // 0x00000001849C5DD0-0x00000001849C5E70
	[BlackList] // 0x0000000189774450-0x0000000189774490
	// [XID] // 0x0000000189774450-0x0000000189774490
	public virtual void OnBeforePoolRecycled() {} // 0x00000001849C5D30-0x00000001849C5DD0
}

