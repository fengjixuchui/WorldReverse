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
public class ConfigGadgetPath : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18082
{
	// Fields
	private Dictionary<string, string[]> _gadgetPaths; // 0x10

	// Properties
	public Dictionary<string, string[]> gadgetPaths { /* [XID] */ /* 0x0000000189B9C3C0-0x0000000189B9C3E0 */ get => default; /* [XID] */ /* 0x0000000189BA39F0-0x0000000189BA3A10 */ private set {} } // 0x00000001842F6630-0x00000001842F66D0 0x00000001842F5DA0-0x00000001842F5E50

	// Constructors
	public ConfigGadgetPath() {} // 0x00000001842F6770-0x00000001842F67D0

	// Methods
	// [XID] // 0x0000000189BAAEA0-0x0000000189BAAEC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842F6410-0x00000001842F64F0
	// [XID] // 0x0000000189BB24D0-0x0000000189BB24F0
	public void InitEmpty() {} // 0x00000001842F5E50-0x00000001842F5F20
	[BlackList] // 0x0000000189BB98E0-0x0000000189BB9920
	// [XID] // 0x0000000189BB98E0-0x0000000189BB9920
	public bool FromJson(JSONNode node) => default; // 0x00000001842F5A20-0x00000001842F5DA0
	// [XID] // 0x0000000189BC46C0-0x0000000189BC46E0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001842F5220-0x00000001842F5400
	// [XID] // 0x0000000189BCC040-0x0000000189BCC060
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A73 */, bool useObjectPool = false /* Metadata: 0x00AF8A77 */) => default; // 0x00000001842F5F20-0x00000001842F6220
	// [XID] // 0x0000000189BD35D0-0x0000000189BD35F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A78 */, bool useObjectPool = false /* Metadata: 0x00AF8A7C */) => default; // 0x00000001842F5810-0x00000001842F5A20
	[BlackList] // 0x0000000189BDAEC0-0x0000000189BDAF00
	// [XID] // 0x0000000189BDAEC0-0x0000000189BDAF00
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001842F5400-0x00000001842F56D0
	// [XID] // 0x00000001895EABB0-0x00000001895EABD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842F6220-0x00000001842F6410
	[BlackList] // 0x00000001895F2090-0x00000001895F20D0
	// [XID] // 0x00000001895F2090-0x00000001895F20D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001842F56D0-0x00000001842F5770
	[BlackList] // 0x00000001895FC8D0-0x00000001895FC910
	// [XID] // 0x00000001895FC8D0-0x00000001895FC910
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842F5770-0x00000001842F5810
	[BlackList] // 0x0000000189607040-0x0000000189607080
	// [XID] // 0x0000000189607040-0x0000000189607080
	public virtual void ReturnToObjectPool() {} // 0x00000001842F66D0-0x00000001842F6770
	[BlackList] // 0x0000000189611980-0x00000001896119C0
	// [XID] // 0x0000000189611980-0x00000001896119C0
	public virtual void OnPoolAllocated() {} // 0x00000001842F6590-0x00000001842F6630
	[BlackList] // 0x000000018961C120-0x000000018961C160
	// [XID] // 0x000000018961C120-0x000000018961C160
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842F64F0-0x00000001842F6590
}

