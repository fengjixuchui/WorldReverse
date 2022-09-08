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
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAIFlySetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17411
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeInt32[] _floatingPoses; // 0x18
	public static Action<ConfigAIFlySetting, bool> postProcessData; // 0x00
	public static Action<ConfigAIFlySetting> postInitEmpty; // 0x08
	[BlackList] // 0x0000000189BBCB10-0x0000000189BBCB60
	[JsonIgnore] // 0x0000000189BBCB10-0x0000000189BBCB60
	// [PooledField] // 0x0000000189BBCB10-0x0000000189BBCB60
	public List<int> floatingPoseList; // 0x20

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189BD96E0-0x0000000189BD9700 */ get => default; /* [XID] */ /* 0x00000001895E6190-0x00000001895E61B0 */ private set {} } // 0x00000001827745F0-0x0000000182774690 0x0000000182774E60-0x0000000182774F10
	public SimpleSafeInt32[] floatingPoses { /* [XID] */ /* 0x00000001895EDB50-0x00000001895EDB70 */ get => default; /* [XID] */ /* 0x00000001895F5450-0x00000001895F5470 */ private set {} } // 0x0000000182773EB0-0x0000000182773F50 0x0000000182774690-0x0000000182774740

	// Constructors
	public ConfigAIFlySetting() {} // 0x00000001827756B0-0x0000000182775720
	static ConfigAIFlySetting() {} // 0x00000001827754D0-0x00000001827756B0

	// Methods
	// [XID] // 0x00000001895FC9D0-0x00000001895FC9F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182775180-0x0000000182775290
	// [XID] // 0x00000001896043B0-0x00000001896043D0
	public void InitEmpty() {} // 0x0000000182774810-0x0000000182774960
	[BlackList] // 0x000000018960BB40-0x000000018960BB80
	// [XID] // 0x000000018960BB40-0x000000018960BB80
	public bool FromJson(JSONNode node) => default; // 0x00000001827741F0-0x00000001827745F0
	// [XID] // 0x0000000189616140-0x0000000189616160
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001827737E0-0x0000000182773A90
	// [XID] // 0x000000018961D930-0x000000018961D950
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DA5 */, bool useObjectPool = false /* Metadata: 0x00AF6DA9 */) => default; // 0x0000000182774960-0x0000000182774CE0
	// [XID] // 0x0000000189624DD0-0x0000000189624DF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DAA */, bool useObjectPool = false /* Metadata: 0x00AF6DAE */) => default; // 0x0000000182773F50-0x00000001827741F0
	[BlackList] // 0x000000018962C5B0-0x000000018962C5F0
	// [XID] // 0x000000018962C5B0-0x000000018962C5F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182773A90-0x0000000182773D60
	// [XID] // 0x0000000189637380-0x00000001896373A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182774F10-0x0000000182775180
	[BlackList] // 0x000000018963E8E0-0x000000018963E920
	// [XID] // 0x000000018963E8E0-0x000000018963E920
	public virtual void OnPoolAllocated() {} // 0x0000000182775390-0x0000000182775430
	[BlackList] // 0x00000001896491C0-0x0000000189649200
	// [XID] // 0x00000001896491C0-0x0000000189649200
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182775290-0x0000000182775390
	// [XID] // 0x0000000189653820-0x0000000189653840
	private static void OnPostInitEmpty(ConfigAIFlySetting data) {} // 0x0000000182774740-0x0000000182774810
	// [XID] // 0x000000018965B0F0-0x000000018965B110
	private static void OnPostProcessDataCallback(ConfigAIFlySetting data, bool useObjectPool) {} // 0x0000000182774CE0-0x0000000182774E60
	[BlackList] // 0x0000000189662560-0x00000001896625A0
	// [XID] // 0x0000000189662560-0x00000001896625A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182773D60-0x0000000182773E00
	[BlackList] // 0x000000018966CCA0-0x000000018966CCE0
	// [XID] // 0x000000018966CCA0-0x000000018966CCE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182773E00-0x0000000182773EB0
	[BlackList] // 0x0000000189677B90-0x0000000189677BD0
	// [XID] // 0x0000000189677B90-0x0000000189677BD0
	public virtual void ReturnToObjectPool() {} // 0x0000000182775430-0x00000001827754D0
}

