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
public class ConfigFlycloakFashionEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18079
{
	// Fields
	private string _Tail; // 0x10
	private string _FlyStart; // 0x18
	private string _FlyEnd; // 0x20

	// Properties
	public string Tail { /* [XID] */ /* 0x000000018997E480-0x000000018997E4A0 */ get => default; /* [XID] */ /* 0x0000000189985F50-0x0000000189985F70 */ private set {} } // 0x0000000182E26B30-0x0000000182E26BD0 0x0000000182E26700-0x0000000182E267B0
	public string FlyStart { /* [XID] */ /* 0x000000018998DBC0-0x000000018998DBE0 */ get => default; /* [XID] */ /* 0x0000000189995690-0x00000001899956B0 */ private set {} } // 0x0000000182E26660-0x0000000182E26700 0x0000000182E26260-0x0000000182E26310
	public string FlyEnd { /* [XID] */ /* 0x00000001897AE2A0-0x00000001897AE2C0 */ get => default; /* [XID] */ /* 0x00000001899A4A30-0x00000001899A4A50 */ private set {} } // 0x0000000182E27070-0x0000000182E27110 0x0000000182E26BD0-0x0000000182E26C80

	// Constructors
	public ConfigFlycloakFashionEffect() {} // 0x0000000182E276D0-0x0000000182E27730

	// Methods
	// [XID] // 0x00000001899AC4B0-0x00000001899AC4D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E273D0-0x0000000182E274F0
	// [XID] // 0x00000001899B3C00-0x00000001899B3C20
	public void InitEmpty() {} // 0x0000000182E26C80-0x0000000182E26D70
	[BlackList] // 0x00000001899BB030-0x00000001899BB070
	// [XID] // 0x00000001899BB030-0x00000001899BB070
	public bool FromJson(JSONNode node) => default; // 0x0000000182E267B0-0x0000000182E26B30
	// [XID] // 0x00000001899C5B30-0x00000001899C5B50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182E25AA0-0x0000000182E25E40
	// [XID] // 0x00000001899CD1B0-0x00000001899CD1D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A55 */, bool useObjectPool = false /* Metadata: 0x00AF8A59 */) => default; // 0x0000000182E26D70-0x0000000182E27070
	// [XID] // 0x00000001899D46B0-0x00000001899D46D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A5A */, bool useObjectPool = false /* Metadata: 0x00AF8A5E */) => default; // 0x0000000182E26310-0x0000000182E26660
	[BlackList] // 0x00000001899DBDB0-0x00000001899DBDF0
	// [XID] // 0x00000001899DBDB0-0x00000001899DBDF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E25E40-0x0000000182E26110
	// [XID] // 0x00000001899E6790-0x00000001899E67B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E27110-0x0000000182E273D0
	[BlackList] // 0x00000001899EDD80-0x00000001899EDDC0
	// [XID] // 0x00000001899EDD80-0x00000001899EDDC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E26110-0x0000000182E261B0
	[BlackList] // 0x00000001899F8470-0x00000001899F84B0
	// [XID] // 0x00000001899F8470-0x00000001899F84B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E261B0-0x0000000182E26260
	[BlackList] // 0x0000000189A02AD0-0x0000000189A02B10
	// [XID] // 0x0000000189A02AD0-0x0000000189A02B10
	public virtual void ReturnToObjectPool() {} // 0x0000000182E27630-0x0000000182E276D0
	[BlackList] // 0x0000000189A0D120-0x0000000189A0D160
	// [XID] // 0x0000000189A0D120-0x0000000189A0D160
	public virtual void OnPoolAllocated() {} // 0x0000000182E27590-0x0000000182E27630
	[BlackList] // 0x0000000189A17450-0x0000000189A17490
	// [XID] // 0x0000000189A17450-0x0000000189A17490
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E274F0-0x0000000182E27590
}

