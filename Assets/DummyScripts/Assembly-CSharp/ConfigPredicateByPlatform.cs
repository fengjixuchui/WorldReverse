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
public class ConfigPredicateByPlatform : ConfigGadgetPredicate, IAutoAllocRecycle // TypeDefIndex: 14964
{
	// Fields
	private bool _isStart; // 0x10

	// Properties
	public bool isStart { /* [XID] */ /* 0x000000018994A680-0x000000018994A6A0 */ get => default; /* [XID] */ /* 0x00000001899520B0-0x00000001899520D0 */ private set {} } // 0x00000001834FDF30-0x00000001834FDFD0 0x00000001834FD7E0-0x00000001834FD890

	// Constructors
	public ConfigPredicateByPlatform() {} // 0x00000001834FE160-0x00000001834FE1C0

	// Methods
	// [XID] // 0x0000000189942ED0-0x0000000189942EF0
	public override bool IsTrue(BaseEntity entity, int param) => default; // 0x00000001834FC770-0x00000001834FC850
	// [XID] // 0x00000001899595F0-0x0000000189959610
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001834FDFD0-0x00000001834FE0C0
	// [XID] // 0x0000000189960F60-0x0000000189960F80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001834FDC80-0x00000001834FDD30
	// [XID] // 0x0000000189968640-0x0000000189968660
	public override ConfigGadgetPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AEFC71 */) => default; // 0x00000001834FD890-0x00000001834FD970
	// [XID] // 0x000000018996FB80-0x000000018996FBA0
	public override int GetHashNum() => default; // 0x00000001834FC6A0-0x00000001834FC770
	// [XID] // 0x0000000189977A40-0x0000000189977A60
	public override void InitEmpty() {} // 0x00000001834FD270-0x00000001834FD310
	[BlackList] // 0x000000018997EBC0-0x000000018997EC00
	// [XID] // 0x000000018997EBC0-0x000000018997EC00
	public override bool FromJson(JSONNode node) => default; // 0x00000001834FCC60-0x00000001834FCFE0
	// [XID] // 0x0000000189989AA0-0x0000000189989AC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001834FBF60-0x00000001834FC160
	[BlackList] // 0x00000001899912D0-0x0000000189991310
	// [XID] // 0x00000001899912D0-0x0000000189991310
	public static new ConfigPredicateByPlatform ParseFromJson(JSONNode node) => default; // 0x00000001834FD9D0-0x00000001834FDC20
	// [XID] // 0x000000018999BE20-0x000000018999BE40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC72 */, bool useObjectPool = false /* Metadata: 0x00AEFC76 */) => default; // 0x00000001834FD4E0-0x00000001834FD7E0
	// [XID] // 0x00000001899A36B0-0x00000001899A36D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC77 */, bool useObjectPool = false /* Metadata: 0x00AEFC7B */) => default; // 0x00000001834FC930-0x00000001834FCB60
	// [XID] // 0x00000001899AB160-0x00000001899AB180
	public static new ConfigPredicateByPlatform ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC7C */, bool useObjectPool = false /* Metadata: 0x00AEFC80 */) => default; // 0x00000001834FCFE0-0x00000001834FD200
	[BlackList] // 0x00000001899B2C10-0x00000001899B2C50
	// [XID] // 0x00000001899B2C10-0x00000001899B2C50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001834FC160-0x00000001834FC430
	// [XID] // 0x00000001899BCF70-0x00000001899BCF90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001834FDD30-0x00000001834FDF30
	[BlackList] // 0x00000001899C49E0-0x00000001899C4A20
	// [XID] // 0x00000001899C49E0-0x00000001899C4A20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001834FD3F0-0x00000001834FD4E0
	[BlackList] // 0x00000001899CEF60-0x00000001899CEFA0
	// [XID] // 0x00000001899CEF60-0x00000001899CEFA0
	public override void AutoAllocTypeFields() {} // 0x00000001834FC430-0x00000001834FC4D0
	[BlackList] // 0x00000001899D93F0-0x00000001899D9430
	// [XID] // 0x00000001899D93F0-0x00000001899D9430
	public override void AutoRecycleTypeFields() {} // 0x00000001834FC4D0-0x00000001834FC580
	[BlackList] // 0x00000001899E3BF0-0x00000001899E3C30
	// [XID] // 0x00000001899E3BF0-0x00000001899E3C30
	public override void ReturnToObjectPool() {} // 0x00000001834FE0C0-0x00000001834FE160
}

