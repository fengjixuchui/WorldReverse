/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelMonsterData : LevelBaseData<BlockMonsterPage> // TypeDefIndex: 19528
{
	// Fields
	private const float BLOCK_SIZE = 1024f; // Metadata: 0x00AFCA95
	private static Dictionary<uint, ConfigLevelMonsterUnit> _levelMonsterConfigsByEvtPattern; // 0x00
	private static readonly ConfigMetaConfig.PathHash BIGWORLD_EVTPATTERN_MONSTER_CONFIG; // 0x08
	private static Dictionary<uint, ConfigLevelMonsterUnit> _levelMonsterConfigByRandomPool; // 0x18
	private static readonly ConfigMetaConfig.PathHash BIGWORLD_RANDOMPOOL_MONSTER_CONFIG; // 0x20

	// Constructors
	public LevelMonsterData() {} // 0x00000001819ABE60-0x00000001819ABEF0
	static LevelMonsterData() {} // 0x00000001819ABCB0-0x00000001819ABE60

	// Methods
	// [XID] // 0x0000000189B715D0-0x0000000189B715F0
	public static uint GetXZHash(int x, int z) => default; // 0x00000001819AB440-0x00000001819AB500
	// [XID] // 0x0000000189B78B20-0x0000000189B78B40
	public static uint GetBlockHash(uint blockId, float x, float z) => default; // 0x00000001819AB160-0x00000001819AB2F0
	// [XID] // 0x0000000189758910-0x0000000189758930
	public static ConfigLevelMonsterUnit FindMonsterConfig(uint sceneId, uint blockHash, uint groupId, uint mapInstId, uint randomPoolId = 0 /* Metadata: 0x00AFCA8D */) => default; // 0x00000001819AB640-0x00000001819ABA40
	// [XID] // 0x0000000189B87A60-0x0000000189B87A80
	public static void ReloadFromFile() {} // 0x00000001819AB2F0-0x00000001819AB440
	// [XID] // 0x0000000189B8EBF0-0x0000000189B8EC10
	private static void ReadFromFile(Dictionary<uint, ConfigLevelMonsterUnit> levelMonsterConfig, ConfigMetaConfig.PathHash dataPath) {} // 0x00000001819ABA40-0x00000001819ABCB0
	[DebuggerHidden] // 0x0000000189B960C0-0x0000000189B96100
	// [XID] // 0x0000000189B960C0-0x0000000189B96100
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCA91 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001819AB500-0x00000001819AB640
}

