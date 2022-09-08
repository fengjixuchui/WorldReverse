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
public class ConfigGlobalToken : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18175
{
	// Fields
	private string _actionTokenGroup; // 0x10

	// Properties
	public string actionTokenGroup { /* [XID] */ /* 0x00000001895FDF00-0x00000001895FDF20 */ get => default; /* [XID] */ /* 0x0000000189605710-0x0000000189605730 */ private set {} } // 0x0000000182D55D40-0x0000000182D55DE0 0x0000000182D55630-0x0000000182D556E0

	// Constructors
	public ConfigGlobalToken() {} // 0x0000000182D56550-0x0000000182D565B0

	// Methods
	// [XID] // 0x000000018960D100-0x000000018960D120
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D56290-0x0000000182D56370
	// [XID] // 0x0000000189614780-0x00000001896147A0
	public void InitEmpty() {} // 0x0000000182D55C70-0x0000000182D55D40
	[BlackList] // 0x000000018961C0C0-0x000000018961C100
	// [XID] // 0x000000018961C0C0-0x000000018961C100
	public bool FromJson(JSONNode node) => default; // 0x0000000182D558F0-0x0000000182D55C70
	// [XID] // 0x00000001896A3E20-0x00000001896A3E40
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D55040-0x0000000182D55220
	// [XID] // 0x0000000189805EE0-0x0000000189805F00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DE9 */, bool useObjectPool = false /* Metadata: 0x00AF8DED */) => default; // 0x0000000182D55DE0-0x0000000182D560E0
	// [XID] // 0x0000000189635B10-0x0000000189635B30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DEE */, bool useObjectPool = false /* Metadata: 0x00AF8DF2 */) => default; // 0x0000000182D556E0-0x0000000182D558F0
	[BlackList] // 0x000000018963D1B0-0x000000018963D1F0
	// [XID] // 0x000000018963D1B0-0x000000018963D1F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D55220-0x0000000182D554F0
	// [XID] // 0x0000000189647790-0x00000001896477B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D560E0-0x0000000182D56290
	[BlackList] // 0x000000018964ED20-0x000000018964ED60
	// [XID] // 0x000000018964ED20-0x000000018964ED60
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D554F0-0x0000000182D55590
	[BlackList] // 0x00000001896595B0-0x00000001896595F0
	// [XID] // 0x00000001896595B0-0x00000001896595F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D55590-0x0000000182D55630
	[BlackList] // 0x0000000189663CE0-0x0000000189663D20
	// [XID] // 0x0000000189663CE0-0x0000000189663D20
	public virtual void ReturnToObjectPool() {} // 0x0000000182D564B0-0x0000000182D56550
	[BlackList] // 0x000000018966E520-0x000000018966E560
	// [XID] // 0x000000018966E520-0x000000018966E560
	public virtual void OnPoolAllocated() {} // 0x0000000182D56410-0x0000000182D564B0
	[BlackList] // 0x0000000189679430-0x0000000189679470
	// [XID] // 0x0000000189679430-0x0000000189679470
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D56370-0x0000000182D56410
}

