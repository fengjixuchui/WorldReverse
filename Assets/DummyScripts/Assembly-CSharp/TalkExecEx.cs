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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TalkExecEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19057
{
	// Fields
	private TalkExecType _type; // 0x10
	private string[] _param; // 0x18

	// Properties
	public TalkExecType type { /* [XID] */ /* 0x0000000189A51510-0x0000000189A51530 */ get => default; /* [XID] */ /* 0x0000000189A58B20-0x0000000189A58B40 */ set {} } // 0x0000000182479020-0x00000001824790C0 0x0000000182478B10-0x0000000182478BC0
	public string[] param { /* [XID] */ /* 0x0000000189A60540-0x0000000189A60560 */ get => default; /* [XID] */ /* 0x0000000189A681D0-0x0000000189A681F0 */ set {} } // 0x0000000182479170-0x0000000182479210 0x00000001824790C0-0x0000000182479170

	// Constructors
	public TalkExecEx() {} // 0x00000001824792B0-0x0000000182479310

	// Methods
	// [XID] // 0x0000000189A6F600-0x0000000189A6F620
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182478E30-0x0000000182478EE0
	// [XID] // 0x0000000189A76D50-0x0000000189A76D70
	public void InitEmpty() {} // 0x0000000182478740-0x0000000182478810
	[BlackList] // 0x0000000189A7E7B0-0x0000000189A7E7F0
	// [XID] // 0x0000000189A7E7B0-0x0000000189A7E7F0
	public bool FromJson(JSONNode node) => default; // 0x00000001824783C0-0x0000000182478740
	// [XID] // 0x0000000189A89310-0x0000000189A89330
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182477A50-0x0000000182477D10
	// [XID] // 0x0000000189A90B50-0x0000000189A90B70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8F9 */, bool useObjectPool = false /* Metadata: 0x00AFB8FD */) => default; // 0x0000000182478810-0x0000000182478B10
	// [XID] // 0x0000000189A982A0-0x0000000189A982C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8FE */, bool useObjectPool = false /* Metadata: 0x00AFB902 */) => default; // 0x0000000182478120-0x00000001824783C0
	[BlackList] // 0x0000000189A9F630-0x0000000189A9F670
	// [XID] // 0x0000000189A9F630-0x0000000189A9F670
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182477D10-0x0000000182477FE0
	// [XID] // 0x0000000189AA9AC0-0x0000000189AA9AE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182478BC0-0x0000000182478E30
	[BlackList] // 0x0000000189AB19A0-0x0000000189AB19E0
	// [XID] // 0x0000000189AB19A0-0x0000000189AB19E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182477FE0-0x0000000182478080
	[BlackList] // 0x0000000189ABC480-0x0000000189ABC4C0
	// [XID] // 0x0000000189ABC480-0x0000000189ABC4C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182478080-0x0000000182478120
	[BlackList] // 0x0000000189AC6B00-0x0000000189AC6B40
	// [XID] // 0x0000000189AC6B00-0x0000000189AC6B40
	public virtual void ReturnToObjectPool() {} // 0x0000000182479210-0x00000001824792B0
	[BlackList] // 0x0000000189AD1270-0x0000000189AD12B0
	// [XID] // 0x0000000189AD1270-0x0000000189AD12B0
	public virtual void OnPoolAllocated() {} // 0x0000000182478F80-0x0000000182479020
	[BlackList] // 0x0000000189ADBFC0-0x0000000189ADC000
	// [XID] // 0x0000000189ADBFC0-0x0000000189ADC000
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182478EE0-0x0000000182478F80
}

