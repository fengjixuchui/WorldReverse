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
public class ConfigLightComponent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16387
{
	// Fields
	private string _lightType; // 0x10
	private SimpleSafeFloat rangeRawNum; // 0x18
	private SimpleSafeFloat colorRRawNum; // 0x1C
	private SimpleSafeFloat colorGRawNum; // 0x20
	private SimpleSafeFloat colorBRawNum; // 0x24
	private SimpleSafeFloat angleRawNum; // 0x28
	private SimpleSafeFloat intensityRawNum; // 0x2C
	private SimpleSafeFloat indirectMultRawNum; // 0x30

	// Properties
	public string lightType { /* [XID] */ /* 0x00000001899BCCD0-0x00000001899BCCF0 */ get => default; /* [XID] */ /* 0x00000001899C46E0-0x00000001899C4700 */ private set {} } // 0x000000018518DFE0-0x000000018518E080 0x000000018518E680-0x000000018518E730
	public float range { /* [XID] */ /* 0x00000001899CBF20-0x00000001899CBF40 */ get => default; /* [XID] */ /* 0x00000001899D3450-0x00000001899D3470 */ private set {} } // 0x000000018518D030-0x000000018518D110 0x000000018518D3B0-0x000000018518D490
	public float colorR { /* [XID] */ /* 0x00000001899DA9E0-0x00000001899DAA00 */ get => default; /* [XID] */ /* 0x00000001899E2320-0x00000001899E2340 */ private set {} } // 0x000000018518DAA0-0x000000018518DB80 0x000000018518D1F0-0x000000018518D2D0
	public float colorG { /* [XID] */ /* 0x00000001899E9800-0x00000001899E9820 */ get => default; /* [XID] */ /* 0x00000001899F0F70-0x00000001899F0F90 */ private set {} } // 0x000000018518CA90-0x000000018518CB70 0x000000018518E5A0-0x000000018518E680
	public float colorB { /* [XID] */ /* 0x00000001899F87F0-0x00000001899F8810 */ get => default; /* [XID] */ /* 0x00000001899FFDE0-0x00000001899FFE00 */ private set {} } // 0x000000018518C110-0x000000018518C1F0 0x000000018518D9C0-0x000000018518DAA0
	public float angle { /* [XID] */ /* 0x0000000189A07670-0x0000000189A07690 */ get => default; /* [XID] */ /* 0x0000000189A0EAF0-0x0000000189A0EB10 */ private set {} } // 0x000000018518D2D0-0x000000018518D3B0 0x000000018518DF00-0x000000018518DFE0
	public float intensity { /* [XID] */ /* 0x0000000189A162A0-0x0000000189A162C0 */ get => default; /* [XID] */ /* 0x0000000189A1D800-0x0000000189A1D820 */ private set {} } // 0x000000018518E1C0-0x000000018518E2A0 0x000000018518D110-0x000000018518D1F0
	public float indirectMult { /* [XID] */ /* 0x0000000189A24BB0-0x0000000189A24BD0 */ get => default; /* [XID] */ /* 0x0000000189A2C270-0x0000000189A2C290 */ private set {} } // 0x000000018518F080-0x000000018518F160 0x000000018518E730-0x000000018518E810

	// Constructors
	public ConfigLightComponent() {} // 0x000000018518F200-0x000000018518F310

	// Methods
	// [XID] // 0x0000000189A33960-0x0000000189A33980
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018518ED90-0x000000018518EF40
	// [XID] // 0x0000000189A3B100-0x0000000189A3B120
	public void InitEmpty() {} // 0x000000018518E080-0x000000018518E1C0
	[BlackList] // 0x0000000189A42A50-0x0000000189A42A90
	// [XID] // 0x0000000189A42A50-0x0000000189A42A90
	public bool FromJson(JSONNode node) => default; // 0x000000018518DB80-0x000000018518DF00
	// [XID] // 0x0000000189A4D080-0x0000000189A4D0A0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018518C1F0-0x000000018518CA90
	// [XID] // 0x0000000189A54810-0x0000000189A54830
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39E6 */, bool useObjectPool = false /* Metadata: 0x00AF39EA */) => default; // 0x000000018518E2A0-0x000000018518E5A0
	// [XID] // 0x0000000189A5C280-0x0000000189A5C2A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39EB */, bool useObjectPool = false /* Metadata: 0x00AF39EF */) => default; // 0x000000018518D490-0x000000018518D9C0
	[BlackList] // 0x0000000189A63C50-0x0000000189A63C90
	// [XID] // 0x0000000189A63C50-0x0000000189A63C90
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018518CB70-0x000000018518CE40
	// [XID] // 0x0000000189A6E3E0-0x0000000189A6E400
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018518E810-0x000000018518ED90
	[BlackList] // 0x0000000189A75A10-0x0000000189A75A50
	// [XID] // 0x0000000189A75A10-0x0000000189A75A50
	public virtual void AutoAllocTypeFields() {} // 0x000000018518CE40-0x000000018518CEE0
	[BlackList] // 0x0000000189A801A0-0x0000000189A801E0
	// [XID] // 0x0000000189A801A0-0x0000000189A801E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018518CEE0-0x000000018518D030
	[BlackList] // 0x0000000189A8AEA0-0x0000000189A8AEE0
	// [XID] // 0x0000000189A8AEA0-0x0000000189A8AEE0
	public virtual void ReturnToObjectPool() {} // 0x000000018518F160-0x000000018518F200
	[BlackList] // 0x0000000189A954F0-0x0000000189A95530
	// [XID] // 0x0000000189A954F0-0x0000000189A95530
	public virtual void OnPoolAllocated() {} // 0x000000018518EFE0-0x000000018518F080
	[BlackList] // 0x0000000189A9FBB0-0x0000000189A9FBF0
	// [XID] // 0x0000000189A9FBB0-0x0000000189A9FBF0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018518EF40-0x000000018518EFE0
}

