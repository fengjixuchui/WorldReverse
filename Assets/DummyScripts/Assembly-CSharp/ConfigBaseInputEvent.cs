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
public class ConfigBaseInputEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19100
{
	// Fields
	private InputActionType _actionType; // 0x10
	private ActionEventType _actionEvent; // 0x14

	// Properties
	public InputActionType actionType { /* [XID] */ /* 0x0000000189B352A0-0x0000000189B352C0 */ get => default; /* [XID] */ /* 0x0000000189B3CB40-0x0000000189B3CB60 */ private set {} } // 0x000000018192E9C0-0x000000018192EA60 0x000000018192DEF0-0x000000018192DFA0
	public ActionEventType actionEvent { /* [XID] */ /* 0x0000000189B44830-0x0000000189B44850 */ get => default; /* [XID] */ /* 0x0000000189B4C120-0x0000000189B4C140 */ private set {} } // 0x000000018192ECA0-0x000000018192ED40 0x000000018192E1F0-0x000000018192E2A0

	// Constructors
	public ConfigBaseInputEvent() {} // 0x000000018192F030-0x000000018192F090

	// Methods
	// [XID] // 0x0000000189B53680-0x0000000189B536A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018192ED40-0x000000018192EE50
	// [XID] // 0x0000000189B5AE50-0x0000000189B5AE70
	public void InitEmpty() {} // 0x000000018192E620-0x000000018192E6C0
	[BlackList] // 0x0000000189B622D0-0x0000000189B62310
	// [XID] // 0x0000000189B622D0-0x0000000189B62310
	public bool FromJson(JSONNode node) => default; // 0x000000018192E2A0-0x000000018192E620
	// [XID] // 0x0000000189B6CB20-0x0000000189B6CB40
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018192D820-0x000000018192DAE0
	// [XID] // 0x0000000189A4C200-0x0000000189A4C220
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBF1F */, bool useObjectPool = false /* Metadata: 0x00AFBF23 */) => default; // 0x000000018192E6C0-0x000000018192E9C0
	// [XID] // 0x0000000189B7B8B0-0x0000000189B7B8D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBF24 */, bool useObjectPool = false /* Metadata: 0x00AFBF28 */) => default; // 0x000000018192DFA0-0x000000018192E1F0
	[BlackList] // 0x0000000189B83220-0x0000000189B83260
	// [XID] // 0x0000000189B83220-0x0000000189B83260
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018192DAE0-0x000000018192DDB0
	// [XID] // 0x0000000189B8D430-0x0000000189B8D450
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018192EA60-0x000000018192ECA0
	[BlackList] // 0x0000000189B94AD0-0x0000000189B94B10
	// [XID] // 0x0000000189B94AD0-0x0000000189B94B10
	public virtual void AutoAllocTypeFields() {} // 0x000000018192DDB0-0x000000018192DE50
	[BlackList] // 0x0000000189B9EE30-0x0000000189B9EE70
	// [XID] // 0x0000000189B9EE30-0x0000000189B9EE70
	public virtual void AutoRecycleTypeFields() {} // 0x000000018192DE50-0x000000018192DEF0
	[BlackList] // 0x0000000189BA9520-0x0000000189BA9560
	// [XID] // 0x0000000189BA9520-0x0000000189BA9560
	public virtual void ReturnToObjectPool() {} // 0x000000018192EF90-0x000000018192F030
	[BlackList] // 0x0000000189BB3A90-0x0000000189BB3AD0
	// [XID] // 0x0000000189BB3A90-0x0000000189BB3AD0
	public virtual void OnPoolAllocated() {} // 0x000000018192EEF0-0x000000018192EF90
	[BlackList] // 0x0000000189BBDF50-0x0000000189BBDF90
	// [XID] // 0x0000000189BBDF50-0x0000000189BBDF90
	public virtual void OnBeforePoolRecycled() {} // 0x000000018192EE50-0x000000018192EEF0
}

