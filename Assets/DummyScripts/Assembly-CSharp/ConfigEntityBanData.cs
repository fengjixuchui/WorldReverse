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
public class ConfigEntityBanData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18050
{
	// Fields
	private Dictionary<string, ConfigEntityBlackGrp[]> _entityBanMap; // 0x10

	// Properties
	public Dictionary<string, ConfigEntityBlackGrp[]> entityBanMap { /* [XID] */ /* 0x000000018998AC80-0x000000018998ACA0 */ get => default; /* [XID] */ /* 0x0000000189992550-0x0000000189992570 */ private set {} } // 0x0000000182B89AA0-0x0000000182B89B40 0x0000000182B89090-0x0000000182B89140

	// Constructors
	public ConfigEntityBanData() {} // 0x0000000182B89FF0-0x0000000182B8A050

	// Methods
	// [XID] // 0x000000018999A2B0-0x000000018999A2D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B89D30-0x0000000182B89E10
	// [XID] // 0x00000001899A1950-0x00000001899A1970
	public void InitEmpty() {} // 0x0000000182B896D0-0x0000000182B897A0
	[BlackList] // 0x00000001899A91E0-0x00000001899A9220
	// [XID] // 0x00000001899A91E0-0x00000001899A9220
	public bool FromJson(JSONNode node) => default; // 0x0000000182B89350-0x0000000182B896D0
	// [XID] // 0x00000001899B3C20-0x00000001899B3C40
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182B88AA0-0x0000000182B88C80
	// [XID] // 0x00000001899BB070-0x00000001899BB090
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87E7 */, bool useObjectPool = false /* Metadata: 0x00AF87EB */) => default; // 0x0000000182B897A0-0x0000000182B89AA0
	// [XID] // 0x00000001899C2A00-0x00000001899C2A20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87EC */, bool useObjectPool = false /* Metadata: 0x00AF87F0 */) => default; // 0x0000000182B89140-0x0000000182B89350
	[BlackList] // 0x00000001899CA080-0x00000001899CA0C0
	// [XID] // 0x00000001899CA080-0x00000001899CA0C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B88C80-0x0000000182B88F50
	// [XID] // 0x00000001899D46D0-0x00000001899D46F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B89B40-0x0000000182B89D30
	[BlackList] // 0x00000001899DBDF0-0x00000001899DBE30
	// [XID] // 0x00000001899DBDF0-0x00000001899DBE30
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B88F50-0x0000000182B88FF0
	[BlackList] // 0x00000001899E67B0-0x00000001899E67F0
	// [XID] // 0x00000001899E67B0-0x00000001899E67F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B88FF0-0x0000000182B89090
	[BlackList] // 0x00000001899F0BF0-0x00000001899F0C30
	// [XID] // 0x00000001899F0BF0-0x00000001899F0C30
	public virtual void ReturnToObjectPool() {} // 0x0000000182B89F50-0x0000000182B89FF0
	[BlackList] // 0x00000001899FB830-0x00000001899FB870
	// [XID] // 0x00000001899FB830-0x00000001899FB870
	public virtual void OnPoolAllocated() {} // 0x0000000182B89EB0-0x0000000182B89F50
	[BlackList] // 0x0000000189A05DD0-0x0000000189A05E10
	// [XID] // 0x0000000189A05DD0-0x0000000189A05E10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B89E10-0x0000000182B89EB0
}

