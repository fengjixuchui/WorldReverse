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
public class ConfigHeadControl : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17947
{
	// Fields
	private bool _useHeadControl; // 0x10
	private SimpleSafeFloat maxYawDegreeRawNum; // 0x14
	private SimpleSafeFloat maxPitchDegreeRawNum; // 0x18
	private SimpleSafeFloat speedRawNum; // 0x1C
	private SimpleSafeFloat weightSpeedRawNum; // 0x20
	private bool _useWhiteAnimStates; // 0x24
	private string[] _animStates; // 0x28
	private string[] _dontAnimStates; // 0x30

	// Properties
	public bool useHeadControl { /* [XID] */ /* 0x00000001898E5A00-0x00000001898E5A20 */ get => default; /* [XID] */ /* 0x00000001898ED400-0x00000001898ED420 */ private set {} } // 0x0000000184E74AA0-0x0000000184E74B40 0x0000000184E76590-0x0000000184E76640
	public float maxYawDegree { /* [XID] */ /* 0x00000001898F4C40-0x00000001898F4C60 */ get => default; /* [XID] */ /* 0x00000001898FC410-0x00000001898FC430 */ private set {} } // 0x0000000184E74C20-0x0000000184E74D00 0x0000000184E74B40-0x0000000184E74C20
	public float maxPitchDegree { /* [XID] */ /* 0x000000018996E7A0-0x000000018996E7C0 */ get => default; /* [XID] */ /* 0x000000018990B410-0x000000018990B430 */ private set {} } // 0x0000000184E748F0-0x0000000184E749D0 0x0000000184E762B0-0x0000000184E76390
	public float speed { /* [XID] */ /* 0x00000001899DE030-0x00000001899DE050 */ get => default; /* [XID] */ /* 0x000000018991A8F0-0x000000018991A910 */ private set {} } // 0x0000000184E76730-0x0000000184E76810 0x0000000184E75AF0-0x0000000184E75BD0
	public float weightSpeed { /* [XID] */ /* 0x0000000189801A70-0x0000000189801A90 */ get => default; /* [XID] */ /* 0x00000001899298A0-0x00000001899298C0 */ private set {} } // 0x0000000184E75290-0x0000000184E75370 0x0000000184E75A10-0x0000000184E75AF0
	public bool useWhiteAnimStates { /* [XID] */ /* 0x0000000189930EE0-0x0000000189930F00 */ get => default; /* [XID] */ /* 0x00000001899381F0-0x0000000189938210 */ private set {} } // 0x0000000184E76810-0x0000000184E768B0 0x0000000184E76200-0x0000000184E762B0
	public string[] animStates { /* [XID] */ /* 0x000000018993FBC0-0x000000018993FBE0 */ get => default; /* [XID] */ /* 0x00000001899472E0-0x0000000189947300 */ private set {} } // 0x0000000184E74690-0x0000000184E74730 0x0000000184E768B0-0x0000000184E76960
	public string[] dontAnimStates { /* [XID] */ /* 0x000000018994E9E0-0x000000018994EA00 */ get => default; /* [XID] */ /* 0x0000000189956040-0x0000000189956060 */ private set {} } // 0x0000000184E75970-0x0000000184E75A10 0x0000000184E75370-0x0000000184E75420

	// Constructors
	public ConfigHeadControl() {} // 0x0000000184E772C0-0x0000000184E773A0

	// Methods
	// [XID] // 0x000000018995DAD0-0x000000018995DAF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184E76F30-0x0000000184E770E0
	// [XID] // 0x0000000189965310-0x0000000189965330
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184E76640-0x0000000184E76730
	// [XID] // 0x000000018996C7F0-0x000000018996C810
	public virtual ConfigHeadControl Clone(bool useObjectPool = false /* Metadata: 0x00AF8463 */) => default; // 0x0000000184E76120-0x0000000184E76200
	// [XID] // 0x0000000189974290-0x00000001899742B0
	public virtual int GetHashNum() => default; // 0x0000000184E749D0-0x0000000184E74AA0
	// [XID] // 0x000000018997B980-0x000000018997B9A0
	public virtual void InitEmpty() {} // 0x0000000184E75BD0-0x0000000184E75D30
	[BlackList] // 0x00000001899834D0-0x0000000189983510
	// [XID] // 0x00000001899834D0-0x0000000189983510
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184E75420-0x0000000184E757A0
	// [XID] // 0x000000018998DBE0-0x000000018998DC00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184E73B80-0x0000000184E743C0
	[BlackList] // 0x00000001899956B0-0x00000001899956F0
	// [XID] // 0x00000001899956B0-0x00000001899956F0
	public static ConfigHeadControl ParseFromJson(JSONNode node) => default; // 0x0000000184E76390-0x0000000184E76590
	// [XID] // 0x00000001899A0030-0x00000001899A0050
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8464 */, bool useObjectPool = false /* Metadata: 0x00AF8468 */) => default; // 0x0000000184E75E20-0x0000000184E76120
	// [XID] // 0x00000001899A7C00-0x00000001899A7C20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8469 */, bool useObjectPool = false /* Metadata: 0x00AF846D */) => default; // 0x0000000184E74D00-0x0000000184E75290
	// [XID] // 0x00000001899AF3D0-0x00000001899AF3F0
	public static ConfigHeadControl ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF846E */, bool useObjectPool = false /* Metadata: 0x00AF8472 */) => default; // 0x0000000184E757A0-0x0000000184E75970
	[BlackList] // 0x00000001899B6850-0x00000001899B6890
	// [XID] // 0x00000001899B6850-0x00000001899B6890
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184E743C0-0x0000000184E74690
	// [XID] // 0x00000001899C12D0-0x00000001899C12F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184E76960-0x0000000184E76F30
	[BlackList] // 0x00000001899C88A0-0x00000001899C88E0
	// [XID] // 0x00000001899C88A0-0x00000001899C88E0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184E75D30-0x0000000184E75E20
	[BlackList] // 0x00000001899D3070-0x00000001899D30B0
	// [XID] // 0x00000001899D3070-0x00000001899D30B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184E74730-0x0000000184E747D0
	[BlackList] // 0x00000001899DD4C0-0x00000001899DD500
	// [XID] // 0x00000001899DD4C0-0x00000001899DD500
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184E747D0-0x0000000184E748F0
	[BlackList] // 0x00000001899E7F80-0x00000001899E7FC0
	// [XID] // 0x00000001899E7F80-0x00000001899E7FC0
	public virtual void ReturnToObjectPool() {} // 0x0000000184E77220-0x0000000184E772C0
	[BlackList] // 0x00000001899F2760-0x00000001899F27A0
	// [XID] // 0x00000001899F2760-0x00000001899F27A0
	public virtual void OnPoolAllocated() {} // 0x0000000184E77180-0x0000000184E77220
	[BlackList] // 0x00000001899FCD90-0x00000001899FCDD0
	// [XID] // 0x00000001899FCD90-0x00000001899FCDD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184E770E0-0x0000000184E77180
}

