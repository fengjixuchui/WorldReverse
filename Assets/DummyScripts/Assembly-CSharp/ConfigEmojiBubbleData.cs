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
public class ConfigEmojiBubbleData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17941
{
	// Fields
	private string _name; // 0x10
	private string[] _effects; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x0000000189B353A0-0x0000000189B353C0 */ get => default; /* [XID] */ /* 0x0000000189B3CCC0-0x0000000189B3CCE0 */ private set {} } // 0x00000001843D8AB0-0x00000001843D8B50 0x00000001843D80C0-0x00000001843D8170
	public string[] effects { /* [XID] */ /* 0x00000001899104F0-0x0000000189910510 */ get => default; /* [XID] */ /* 0x0000000189B4C200-0x0000000189B4C220 */ private set {} } // 0x00000001843D8550-0x00000001843D85F0 0x00000001843D79D0-0x00000001843D7A80

	// Constructors
	public ConfigEmojiBubbleData() {} // 0x00000001843D8BF0-0x00000001843D8C50

	// Methods
	// [XID] // 0x0000000189B53840-0x0000000189B53860
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843D8860-0x00000001843D8970
	// [XID] // 0x0000000189B5B0B0-0x0000000189B5B0D0
	public void InitEmpty() {} // 0x00000001843D8170-0x00000001843D8250
	[BlackList] // 0x0000000189B62530-0x0000000189B62570
	// [XID] // 0x0000000189B62530-0x0000000189B62570
	public bool FromJson(JSONNode node) => default; // 0x00000001843D7D40-0x00000001843D80C0
	// [XID] // 0x0000000189B6CDC0-0x0000000189B6CDE0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001843D72F0-0x00000001843D75C0
	// [XID] // 0x0000000189B74570-0x0000000189B74590
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8427 */, bool useObjectPool = false /* Metadata: 0x00AF842B */) => default; // 0x00000001843D8250-0x00000001843D8550
	// [XID] // 0x0000000189B7BB90-0x0000000189B7BBB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF842C */, bool useObjectPool = false /* Metadata: 0x00AF8430 */) => default; // 0x00000001843D7A80-0x00000001843D7D40
	[BlackList] // 0x0000000189B83460-0x0000000189B834A0
	// [XID] // 0x0000000189B83460-0x0000000189B834A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001843D75C0-0x00000001843D7890
	// [XID] // 0x0000000189B8D6D0-0x0000000189B8D6F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843D85F0-0x00000001843D8860
	[BlackList] // 0x0000000189B94C90-0x0000000189B94CD0
	// [XID] // 0x0000000189B94C90-0x0000000189B94CD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001843D7890-0x00000001843D7930
	[BlackList] // 0x0000000189B9F050-0x0000000189B9F090
	// [XID] // 0x0000000189B9F050-0x0000000189B9F090
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843D7930-0x00000001843D79D0
	[BlackList] // 0x0000000189BA97C0-0x0000000189BA9800
	// [XID] // 0x0000000189BA97C0-0x0000000189BA9800
	public virtual void ReturnToObjectPool() {} // 0x00000001843D8B50-0x00000001843D8BF0
	[BlackList] // 0x0000000189BB3CF0-0x0000000189BB3D30
	// [XID] // 0x0000000189BB3CF0-0x0000000189BB3D30
	public virtual void OnPoolAllocated() {} // 0x00000001843D8A10-0x00000001843D8AB0
	[BlackList] // 0x0000000189BBE0F0-0x0000000189BBE130
	// [XID] // 0x0000000189BBE0F0-0x0000000189BBE130
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843D8970-0x00000001843D8A10
}

