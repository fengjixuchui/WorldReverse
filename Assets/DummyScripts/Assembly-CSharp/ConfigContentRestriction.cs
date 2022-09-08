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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigContentRestriction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18807
{
	// Fields
	private string _countryCode; // 0x10
	private SimpleSafeInt32 ageRawNum; // 0x18

	// Properties
	public string countryCode { /* [XID] */ /* 0x00000001898BFBA0-0x00000001898BFBC0 */ get => default; /* [XID] */ /* 0x00000001898C7480-0x00000001898C74A0 */ private set {} } // 0x0000000183A51800-0x0000000183A518A0 0x0000000183A51D70-0x0000000183A51E20
	public int age { /* [XID] */ /* 0x00000001898CEA50-0x00000001898CEA70 */ get => default; /* [XID] */ /* 0x00000001898D6380-0x00000001898D63A0 */ private set {} } // 0x0000000183A518A0-0x0000000183A51970 0x0000000183A52090-0x0000000183A52170

	// Constructors
	public ConfigContentRestriction() {} // 0x0000000183A52460-0x0000000183A524C0

	// Methods
	// [XID] // 0x00000001898DE0A0-0x00000001898DE0C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A52170-0x0000000183A52280
	// [XID] // 0x00000001898E5880-0x00000001898E58A0
	public void InitEmpty() {} // 0x0000000183A51970-0x0000000183A51A70
	[BlackList] // 0x00000001898ED260-0x00000001898ED2A0
	// [XID] // 0x00000001898ED260-0x00000001898ED2A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183A51480-0x0000000183A51800
	// [XID] // 0x00000001898F7D10-0x00000001898F7D30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A50A60-0x0000000183A50D70
	// [XID] // 0x00000001898FF2D0-0x00000001898FF2F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD57 */, bool useObjectPool = false /* Metadata: 0x00AFAD5B */) => default; // 0x0000000183A51A70-0x0000000183A51D70
	// [XID] // 0x0000000189906A30-0x0000000189906A50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD5C */, bool useObjectPool = false /* Metadata: 0x00AFAD60 */) => default; // 0x0000000183A511C0-0x0000000183A51480
	[BlackList] // 0x000000018990E570-0x000000018990E5B0
	// [XID] // 0x000000018990E570-0x000000018990E5B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A50D70-0x0000000183A51040
	// [XID] // 0x0000000189918DE0-0x0000000189918E00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A51E20-0x0000000183A52090
	[BlackList] // 0x00000001899203D0-0x0000000189920410
	// [XID] // 0x00000001899203D0-0x0000000189920410
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A51040-0x0000000183A510E0
	[BlackList] // 0x000000018992AD00-0x000000018992AD40
	// [XID] // 0x000000018992AD00-0x000000018992AD40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A510E0-0x0000000183A511C0
	[BlackList] // 0x0000000189935090-0x00000001899350D0
	// [XID] // 0x0000000189935090-0x00000001899350D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183A523C0-0x0000000183A52460
	[BlackList] // 0x000000018993FB00-0x000000018993FB40
	// [XID] // 0x000000018993FB00-0x000000018993FB40
	public virtual void OnPoolAllocated() {} // 0x0000000183A52320-0x0000000183A523C0
	[BlackList] // 0x0000000189949FC0-0x000000018994A000
	// [XID] // 0x0000000189949FC0-0x000000018994A000
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A52280-0x0000000183A52320
}

