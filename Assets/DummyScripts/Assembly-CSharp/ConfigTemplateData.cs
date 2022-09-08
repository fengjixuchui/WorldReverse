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
public class ConfigTemplateData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19000
{
	// Fields
	private string _templateName; // 0x10
	private Dictionary<string, string> _paramDatas; // 0x18

	// Properties
	public string templateName { /* [XID] */ /* 0x000000018980C8B0-0x000000018980C8D0 */ get => default; /* [XID] */ /* 0x0000000189813FF0-0x0000000189814010 */ private set {} } // 0x00000001843CED10-0x00000001843CEDB0 0x00000001843CDF90-0x00000001843CE040
	public Dictionary<string, string> paramDatas { /* [XID] */ /* 0x000000018981BBC0-0x000000018981BBE0 */ get => default; /* [XID] */ /* 0x0000000189823030-0x0000000189823050 */ private set {} } // 0x00000001843CDEF0-0x00000001843CDF90 0x00000001843CE3C0-0x00000001843CE470

	// Constructors
	public ConfigTemplateData() {} // 0x00000001843CEE50-0x00000001843CEEB0

	// Methods
	// [XID] // 0x000000018982AA70-0x000000018982AA90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843CEAC0-0x00000001843CEBD0
	// [XID] // 0x0000000189831F30-0x0000000189831F50
	public void InitEmpty() {} // 0x00000001843CE470-0x00000001843CE550
	[BlackList] // 0x0000000189839560-0x00000001898395A0
	// [XID] // 0x0000000189839560-0x00000001898395A0
	public bool FromJson(JSONNode node) => default; // 0x00000001843CE040-0x00000001843CE3C0
	// [XID] // 0x0000000189843C00-0x0000000189843C20
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001843CD550-0x00000001843CD820
	// [XID] // 0x000000018984B0F0-0x000000018984B110
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6DF */, bool useObjectPool = false /* Metadata: 0x00AFB6E3 */) => default; // 0x00000001843CE550-0x00000001843CE850
	// [XID] // 0x0000000189852380-0x00000001898523A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6E4 */, bool useObjectPool = false /* Metadata: 0x00AFB6E8 */) => default; // 0x00000001843CDC30-0x00000001843CDEF0
	[BlackList] // 0x0000000189859C90-0x0000000189859CD0
	// [XID] // 0x0000000189859C90-0x0000000189859CD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001843CD820-0x00000001843CDAF0
	// [XID] // 0x00000001898641B0-0x00000001898641D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843CE850-0x00000001843CEAC0
	[BlackList] // 0x000000018986B600-0x000000018986B640
	// [XID] // 0x000000018986B600-0x000000018986B640
	public virtual void AutoAllocTypeFields() {} // 0x00000001843CDAF0-0x00000001843CDB90
	[BlackList] // 0x00000001898759C0-0x0000000189875A00
	// [XID] // 0x00000001898759C0-0x0000000189875A00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843CDB90-0x00000001843CDC30
	[BlackList] // 0x0000000189880020-0x0000000189880060
	// [XID] // 0x0000000189880020-0x0000000189880060
	public virtual void ReturnToObjectPool() {} // 0x00000001843CEDB0-0x00000001843CEE50
	[BlackList] // 0x000000018988A350-0x000000018988A390
	// [XID] // 0x000000018988A350-0x000000018988A390
	public virtual void OnPoolAllocated() {} // 0x00000001843CEC70-0x00000001843CED10
	[BlackList] // 0x00000001898948F0-0x0000000189894930
	// [XID] // 0x00000001898948F0-0x0000000189894930
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843CEBD0-0x00000001843CEC70
}

