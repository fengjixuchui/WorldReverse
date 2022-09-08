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
public class ConfigFace : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18078
{
	// Fields
	private string _characterName; // 0x10
	private string _baseFaceAnimation; // 0x18
	private string _intervalFaceAnimation; // 0x20
	private SimpleSafeFloat minIntervalRawNum; // 0x28
	private SimpleSafeFloat maxIntervalRawNum; // 0x2C

	// Properties
	public string characterName { /* [XID] */ /* 0x00000001898B5330-0x00000001898B5350 */ get => default; /* [XID] */ /* 0x00000001898BCDE0-0x00000001898BCE00 */ private set {} } // 0x000000018231EB30-0x000000018231EBD0 0x000000018231F1D0-0x000000018231F280
	public string baseFaceAnimation { /* [XID] */ /* 0x0000000189B618A0-0x0000000189B618C0 */ get => default; /* [XID] */ /* 0x00000001898CBBB0-0x00000001898CBBD0 */ private set {} } // 0x000000018231EBD0-0x000000018231EC70 0x000000018231EC70-0x000000018231ED20
	public string intervalFaceAnimation { /* [XID] */ /* 0x00000001898D3390-0x00000001898D33B0 */ get => default; /* [XID] */ /* 0x00000001898DAC20-0x00000001898DAC40 */ private set {} } // 0x000000018231F660-0x000000018231F700 0x000000018231DAC0-0x000000018231DB70
	public float minInterval { /* [XID] */ /* 0x00000001898E2AC0-0x00000001898E2AE0 */ get => default; /* [XID] */ /* 0x00000001898EA5F0-0x00000001898EA610 */ private set {} } // 0x000000018231D9E0-0x000000018231DAC0 0x000000018231F580-0x000000018231F660
	public float maxInterval { /* [XID] */ /* 0x00000001898F1CF0-0x00000001898F1D10 */ get => default; /* [XID] */ /* 0x00000001898F9570-0x00000001898F9590 */ private set {} } // 0x000000018231E5B0-0x000000018231E690 0x000000018231FD80-0x000000018231FE60

	// Constructors
	public ConfigFace() {} // 0x000000018231FF00-0x000000018231FF60

	// Methods
	// [XID] // 0x0000000189900ED0-0x0000000189900EF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018231FAE0-0x000000018231FC40
	// [XID] // 0x0000000189908670-0x0000000189908690
	public void InitEmpty() {} // 0x000000018231F0A0-0x000000018231F1D0
	[BlackList] // 0x000000018990FCD0-0x000000018990FD10
	// [XID] // 0x000000018990FCD0-0x000000018990FD10
	public bool FromJson(JSONNode node) => default; // 0x000000018231ED20-0x000000018231F0A0
	// [XID] // 0x000000018991A8D0-0x000000018991A8F0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018231DB70-0x000000018231E150
	// [XID] // 0x00000001899220C0-0x00000001899220E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A4B */, bool useObjectPool = false /* Metadata: 0x00AF8A4F */) => default; // 0x000000018231F280-0x000000018231F580
	// [XID] // 0x0000000189929840-0x0000000189929860
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A50 */, bool useObjectPool = false /* Metadata: 0x00AF8A54 */) => default; // 0x000000018231E690-0x000000018231EB30
	[BlackList] // 0x0000000189930E80-0x0000000189930EC0
	// [XID] // 0x0000000189930E80-0x0000000189930EC0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018231E150-0x000000018231E420
	// [XID] // 0x000000018993B7B0-0x000000018993B7D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018231F700-0x000000018231FAE0
	[BlackList] // 0x0000000189942810-0x0000000189942850
	// [XID] // 0x0000000189942810-0x0000000189942850
	public virtual void AutoAllocTypeFields() {} // 0x000000018231E420-0x000000018231E4C0
	[BlackList] // 0x000000018994CFF0-0x000000018994D030
	// [XID] // 0x000000018994CFF0-0x000000018994D030
	public virtual void AutoRecycleTypeFields() {} // 0x000000018231E4C0-0x000000018231E5B0
	[BlackList] // 0x0000000189957860-0x00000001899578A0
	// [XID] // 0x0000000189957860-0x00000001899578A0
	public virtual void ReturnToObjectPool() {} // 0x000000018231FE60-0x000000018231FF00
	[BlackList] // 0x0000000189962410-0x0000000189962450
	// [XID] // 0x0000000189962410-0x0000000189962450
	public virtual void OnPoolAllocated() {} // 0x000000018231FCE0-0x000000018231FD80
	[BlackList] // 0x000000018996C790-0x000000018996C7D0
	// [XID] // 0x000000018996C790-0x000000018996C7D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018231FC40-0x000000018231FCE0
}

