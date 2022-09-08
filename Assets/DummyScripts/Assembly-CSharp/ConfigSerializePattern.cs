/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ConfigSerializePattern : ISimplePoolObject // TypeDefIndex: 26582
{
	// Fields
	private static SimpleObjectPool<ConfigSerializePattern> _pool; // 0x00
	private ulong _path; // 0x10
	private ConfigLoadAndSerializePattern _parentPattern; // 0x18
	private object _data; // 0x20
	private ByteArray _byteArray; // 0x28
	private SerializeBinHandler _serializeBinHandler; // 0x30
	private JSONNode _node; // 0x38
	private SerializeJsonHandler _serializeJsonHandler; // 0x40
	private Action<object, ulong> _onReadedDataHandler; // 0x48
	private bool _loadFromBin; // 0x50

	// Properties
	public ByteArray byteArray { /* [XID] */ /* 0x0000000189A3F2F0-0x0000000189A3F310 */ get => default; } // 0x00000001810888F0-0x0000000181088990 
	private bool loadFromBin { /* [XID] */ /* 0x0000000189A4E0C0-0x0000000189A4E0E0 */ get => default; } // 0x0000000181089560-0x0000000181089600 

	// Constructors
	public ConfigSerializePattern() {} // 0x0000000181089780-0x0000000181089810
	static ConfigSerializePattern() {} // 0x0000000181089710-0x0000000181089780

	// Methods
	// [XID] // 0x0000000189A28A60-0x0000000189A28A80
	public static ConfigSerializePattern Create(ConfigLoadAndSerializePattern parent, ulong path, SerializeBinHandler serializeBinHandler, SerializeJsonHandler serializeJsonHandler, Action<object, ulong> onReadedDataHandler, bool loadFromBin = true /* Metadata: 0x00B0C58E */) => default; // 0x0000000181088C50-0x0000000181088DE0
	// [XID] // 0x0000000189A30170-0x0000000189A30190
	public static void Release(ConfigSerializePattern pattern) {} // 0x0000000181089060-0x0000000181089150
	// [XID] // 0x0000000189A37B80-0x0000000189A37BA0
	public void SetByteArray(ByteArray b) {} // 0x0000000181088DE0-0x0000000181088E90
	// [XID] // 0x0000000189A46870-0x0000000189A46890
	public void SetJsonNode(JSONNode n) {} // 0x0000000181088A70-0x0000000181088B20
	// [XID] // 0x0000000189A55910-0x0000000189A55930
	public void Init(ConfigLoadAndSerializePattern parent, ulong path, SerializeBinHandler serializeBinHandler, SerializeJsonHandler serializeJsonHandler, Action<object, ulong> onReadedDataHandler, bool loadFromBin = true /* Metadata: 0x00B0C58F */) {} // 0x0000000181088B20-0x0000000181088C50
	// [XID] // 0x0000000189A5D1B0-0x0000000189A5D1D0
	public void ResetObject() {} // 0x0000000181089600-0x0000000181089710
	// [XID] // 0x0000000189A64A90-0x0000000189A64AB0
	public void ReadSerialize(int threadFlag = 1 /* Metadata: 0x00B0C590 */) {} // 0x0000000181088990-0x0000000181088A70
	// [XID] // 0x0000000189A6C210-0x0000000189A6C230
	private void ReadBin(int threadFlag = 1 /* Metadata: 0x00B0C594 */) {} // 0x0000000181089150-0x0000000181089380
	// [XID] // 0x0000000189A73A60-0x0000000189A73A80
	private void ReadJson() {} // 0x0000000181089380-0x0000000181089560
	// [XID] // 0x0000000189A7B520-0x0000000189A7B540
	public bool Flush() => default; // 0x0000000181088E90-0x0000000181089060
}

