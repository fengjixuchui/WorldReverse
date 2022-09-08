/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlockMonsterPage : BlockDataPage // TypeDefIndex: 19530
{
	// Fields
	private Dictionary<MonsterConfigIdentifier, ConfigLevelMonsterUnit> _levelMonsterConfigs; // 0x20

	// Constructors
	public BlockMonsterPage() {} // 0x00000001828E9470-0x00000001828E9520

	// Methods
	// [XID] // 0x00000001895E8F10-0x00000001895E8F30
	public ConfigLevelMonsterUnit GetConfig(uint sceneId, uint groupId, uint mapInstId) => default; // 0x00000001828E8D90-0x00000001828E8EF0
	// [XID] // 0x00000001895F0700-0x00000001895F0720
	protected override object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFCA99 */) => default; // 0x00000001828E9360-0x00000001828E9470
	// [XID] // 0x00000001895F8110-0x00000001895F8130
	protected override object SerializeJson(JSONNode node) => default; // 0x00000001828E8EF0-0x00000001828E8FF0
	// [XID] // 0x00000001895FF670-0x00000001895FF690
	protected override void OnSerialized(object obj, ulong path) {} // 0x00000001828E9080-0x00000001828E9360
}

