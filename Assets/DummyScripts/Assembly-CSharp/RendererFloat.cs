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
public class RendererFloat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18870
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x00000001897969B0-0x00000001897969D0 */ get => default; /* [XID] */ /* 0x000000018979EAF0-0x000000018979EB10 */ private set {} } // 0x0000000183AEA890-0x0000000183AEA930 0x0000000183AE9F50-0x0000000183AEA000
	public float value { /* [XID] */ /* 0x00000001897A61E0-0x00000001897A6200 */ get => default; /* [XID] */ /* 0x00000001897AD670-0x00000001897AD690 */ private set {} } // 0x0000000183AE9AF0-0x0000000183AE9BD0 0x0000000183AE9A10-0x0000000183AE9AF0

	// Constructors
	public RendererFloat() {} // 0x0000000183AEA9D0-0x0000000183AEAA30

	// Methods
	// [XID] // 0x00000001897B5790-0x00000001897B57B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AEA640-0x0000000183AEA750
	// [XID] // 0x00000001897BD460-0x00000001897BD480
	public void InitEmpty() {} // 0x0000000183AEA000-0x0000000183AEA100
	[BlackList] // 0x00000001897C4800-0x00000001897C4840
	// [XID] // 0x00000001897C4800-0x00000001897C4840
	public bool FromJson(JSONNode node) => default; // 0x0000000183AE9BD0-0x0000000183AE9F50
	// [XID] // 0x00000001897CF190-0x00000001897CF1B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AE8FE0-0x0000000183AE9300
	// [XID] // 0x00000001897D69C0-0x00000001897D69E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1C1 */, bool useObjectPool = false /* Metadata: 0x00AFB1C5 */) => default; // 0x0000000183AEA100-0x0000000183AEA400
	// [XID] // 0x00000001897DE190-0x00000001897DE1B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1C6 */, bool useObjectPool = false /* Metadata: 0x00AFB1CA */) => default; // 0x0000000183AE9750-0x0000000183AE9A10
	[BlackList] // 0x00000001897E5B90-0x00000001897E5BD0
	// [XID] // 0x00000001897E5B90-0x00000001897E5BD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AE9300-0x0000000183AE95D0
	// [XID] // 0x00000001897F0740-0x00000001897F0760
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AEA400-0x0000000183AEA640
	[BlackList] // 0x00000001897F7E20-0x00000001897F7E60
	// [XID] // 0x00000001897F7E20-0x00000001897F7E60
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AE95D0-0x0000000183AE9670
	[BlackList] // 0x0000000189802580-0x00000001898025C0
	// [XID] // 0x0000000189802580-0x00000001898025C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AE9670-0x0000000183AE9750
	[BlackList] // 0x000000018980C8D0-0x000000018980C910
	// [XID] // 0x000000018980C8D0-0x000000018980C910
	public virtual void ReturnToObjectPool() {} // 0x0000000183AEA930-0x0000000183AEA9D0
	[BlackList] // 0x0000000189817280-0x00000001898172C0
	// [XID] // 0x0000000189817280-0x00000001898172C0
	public virtual void OnPoolAllocated() {} // 0x0000000183AEA7F0-0x0000000183AEA890
	[BlackList] // 0x0000000189821C70-0x0000000189821CB0
	// [XID] // 0x0000000189821C70-0x0000000189821CB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AEA750-0x0000000183AEA7F0
}

