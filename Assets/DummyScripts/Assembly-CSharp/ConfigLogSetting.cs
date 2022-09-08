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
public class ConfigLogSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18112
{
	// Fields
	private bool _sendEngineLogToServer; // 0x10

	// Properties
	public bool sendEngineLogToServer { /* [XID] */ /* 0x0000000189832C80-0x0000000189832CA0 */ get => default; /* [XID] */ /* 0x000000018971C660-0x000000018971C680 */ private set {} } // 0x0000000180E61ED0-0x0000000180E61F70 0x0000000180E62310-0x0000000180E623C0

	// Constructors
	public ConfigLogSetting() {} // 0x0000000180E62840-0x0000000180E628B0

	// Methods
	// [XID] // 0x0000000189723B70-0x0000000189723B90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180E62570-0x0000000180E62660
	// [XID] // 0x000000018972B210-0x000000018972B230
	public void InitEmpty() {} // 0x0000000180E61F70-0x0000000180E62010
	[BlackList] // 0x0000000189732A40-0x0000000189732A80
	// [XID] // 0x0000000189732A40-0x0000000189732A80
	public bool FromJson(JSONNode node) => default; // 0x0000000180E61B50-0x0000000180E61ED0
	// [XID] // 0x000000018973D590-0x000000018973D5B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180E613B0-0x0000000180E61570
	// [XID] // 0x0000000189744A70-0x0000000189744A90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B77 */, bool useObjectPool = false /* Metadata: 0x00AF8B7B */) => default; // 0x0000000180E62010-0x0000000180E62310
	// [XID] // 0x000000018974C740-0x000000018974C760
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B7C */, bool useObjectPool = false /* Metadata: 0x00AF8B80 */) => default; // 0x0000000180E61980-0x0000000180E61B50
	[BlackList] // 0x00000001897539C0-0x0000000189753A00
	// [XID] // 0x00000001897539C0-0x0000000189753A00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180E61570-0x0000000180E61840
	// [XID] // 0x000000018975DEB0-0x000000018975DED0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180E623C0-0x0000000180E62570
	[BlackList] // 0x00000001897655B0-0x00000001897655F0
	// [XID] // 0x00000001897655B0-0x00000001897655F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000180E61840-0x0000000180E618E0
	[BlackList] // 0x000000018976FD70-0x000000018976FDB0
	// [XID] // 0x000000018976FD70-0x000000018976FDB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180E618E0-0x0000000180E61980
	[BlackList] // 0x000000018977A420-0x000000018977A460
	// [XID] // 0x000000018977A420-0x000000018977A460
	public virtual void ReturnToObjectPool() {} // 0x0000000180E627A0-0x0000000180E62840
	[BlackList] // 0x0000000189784EE0-0x0000000189784F20
	// [XID] // 0x0000000189784EE0-0x0000000189784F20
	public virtual void OnPoolAllocated() {} // 0x0000000180E62700-0x0000000180E627A0
	[BlackList] // 0x000000018978F300-0x000000018978F340
	// [XID] // 0x000000018978F300-0x000000018978F340
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180E62660-0x0000000180E62700
}

