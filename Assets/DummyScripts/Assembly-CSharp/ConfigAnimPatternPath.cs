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
public class ConfigAnimPatternPath : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17520
{
	// Fields
	private Dictionary<string, string[]> _animPatternPaths; // 0x10

	// Properties
	public Dictionary<string, string[]> animPatternPaths { /* [XID] */ /* 0x0000000189A440F0-0x0000000189A44110 */ get => default; /* [XID] */ /* 0x0000000189A4B660-0x0000000189A4B680 */ private set {} } // 0x00000001833AF740-0x00000001833AF7E0 0x00000001833AFBB0-0x00000001833AFC60

	// Constructors
	public ConfigAnimPatternPath() {} // 0x00000001833B0110-0x00000001833B0170

	// Methods
	// [XID] // 0x0000000189A52DC0-0x0000000189A52DE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833AFE50-0x00000001833AFF30
	// [XID] // 0x0000000189A5A670-0x0000000189A5A690
	public void InitEmpty() {} // 0x00000001833AF7E0-0x00000001833AF8B0
	[BlackList] // 0x0000000189A61DB0-0x0000000189A61DF0
	// [XID] // 0x0000000189A61DB0-0x0000000189A61DF0
	public bool FromJson(JSONNode node) => default; // 0x00000001833AF3C0-0x00000001833AF740
	// [XID] // 0x0000000189A6C920-0x0000000189A6C940
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833AEBC0-0x00000001833AEDA0
	// [XID] // 0x0000000189A74110-0x0000000189A74130
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF719D */, bool useObjectPool = false /* Metadata: 0x00AF71A1 */) => default; // 0x00000001833AF8B0-0x00000001833AFBB0
	// [XID] // 0x0000000189A7BAA0-0x0000000189A7BAC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF71A2 */, bool useObjectPool = false /* Metadata: 0x00AF71A6 */) => default; // 0x00000001833AF1B0-0x00000001833AF3C0
	[BlackList] // 0x0000000189A833A0-0x0000000189A833E0
	// [XID] // 0x0000000189A833A0-0x0000000189A833E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001833AEDA0-0x00000001833AF070
	// [XID] // 0x0000000189A8DCF0-0x0000000189A8DD10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833AFC60-0x00000001833AFE50
	[BlackList] // 0x0000000189A952B0-0x0000000189A952F0
	// [XID] // 0x0000000189A952B0-0x0000000189A952F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001833AF070-0x00000001833AF110
	[BlackList] // 0x0000000189A9F9B0-0x0000000189A9F9F0
	// [XID] // 0x0000000189A9F9B0-0x0000000189A9F9F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833AF110-0x00000001833AF1B0
	[BlackList] // 0x0000000189AA9DE0-0x0000000189AA9E20
	// [XID] // 0x0000000189AA9DE0-0x0000000189AA9E20
	public virtual void ReturnToObjectPool() {} // 0x00000001833B0070-0x00000001833B0110
	[BlackList] // 0x0000000189AB4910-0x0000000189AB4950
	// [XID] // 0x0000000189AB4910-0x0000000189AB4950
	public virtual void OnPoolAllocated() {} // 0x00000001833AFFD0-0x00000001833B0070
	[BlackList] // 0x0000000189ABF310-0x0000000189ABF350
	// [XID] // 0x0000000189ABF310-0x0000000189ABF350
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833AFF30-0x00000001833AFFD0
}

