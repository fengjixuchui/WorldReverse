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
public class ShakeByAinmator : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17687
{
	// Fields
	private SimpleSafeFloat shakeFlagRawNum; // 0x10
	private string[] _hitBoxNames; // 0x18

	// Properties
	public float shakeFlag { /* [XID] */ /* 0x000000018987F510-0x000000018987F530 */ get => default; /* [XID] */ /* 0x00000001895FC950-0x00000001895FC970 */ private set {} } // 0x000000018657BD00-0x000000018657BDE0 0x000000018657B770-0x000000018657B850
	public string[] hitBoxNames { /* [XID] */ /* 0x0000000189604330-0x0000000189604350 */ get => default; /* [XID] */ /* 0x000000018960BAA0-0x000000018960BAC0 */ private set {} } // 0x000000018657A920-0x000000018657A9C0 0x000000018657BC50-0x000000018657BD00

	// Constructors
	public ShakeByAinmator() {} // 0x000000018657C340-0x000000018657C3A0

	// Methods
	// [XID] // 0x00000001896130A0-0x00000001896130C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018657C050-0x000000018657C160
	// [XID] // 0x000000018961A8A0-0x000000018961A8C0
	public void InitEmpty() {} // 0x000000018657B850-0x000000018657B950
	[BlackList] // 0x0000000189621EC0-0x0000000189621F00
	// [XID] // 0x0000000189621EC0-0x0000000189621F00
	public bool FromJson(JSONNode node) => default; // 0x000000018657B3F0-0x000000018657B770
	// [XID] // 0x000000018962C510-0x000000018962C530
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018657A9C0-0x000000018657ACD0
	// [XID] // 0x0000000189634130-0x0000000189634150
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77C5 */, bool useObjectPool = false /* Metadata: 0x00AF77C9 */) => default; // 0x000000018657B950-0x000000018657BC50
	// [XID] // 0x000000018963B980-0x000000018963B9A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77CA */, bool useObjectPool = false /* Metadata: 0x00AF77CE */) => default; // 0x000000018657B120-0x000000018657B3F0
	[BlackList] // 0x0000000189643100-0x0000000189643140
	// [XID] // 0x0000000189643100-0x0000000189643140
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018657ACD0-0x000000018657AFA0
	// [XID] // 0x000000018964D840-0x000000018964D860
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018657BDE0-0x000000018657C050
	[BlackList] // 0x0000000189654FA0-0x0000000189654FE0
	// [XID] // 0x0000000189654FA0-0x0000000189654FE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018657AFA0-0x000000018657B040
	[BlackList] // 0x000000018965F620-0x000000018965F660
	// [XID] // 0x000000018965F620-0x000000018965F660
	public virtual void AutoRecycleTypeFields() {} // 0x000000018657B040-0x000000018657B120
	[BlackList] // 0x000000018966A0E0-0x000000018966A120
	// [XID] // 0x000000018966A0E0-0x000000018966A120
	public virtual void ReturnToObjectPool() {} // 0x000000018657C2A0-0x000000018657C340
	[BlackList] // 0x0000000189674AD0-0x0000000189674B10
	// [XID] // 0x0000000189674AD0-0x0000000189674B10
	public virtual void OnPoolAllocated() {} // 0x000000018657C200-0x000000018657C2A0
	[BlackList] // 0x000000018967F100-0x000000018967F140
	// [XID] // 0x000000018967F100-0x000000018967F140
	public virtual void OnBeforePoolRecycled() {} // 0x000000018657C160-0x000000018657C200
}

