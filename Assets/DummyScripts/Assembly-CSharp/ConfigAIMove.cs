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
public class ConfigAIMove : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17410
{
	// Fields
	private bool _enable; // 0x10
	private MoveCategoryAI _moveCategory; // 0x14
	private bool _useNavMesh; // 0x18
	private string _navMeshAgentName; // 0x20
	private SimpleSafeFloat almostReachedDistanceWalkRawNum; // 0x28
	private SimpleSafeFloat almostReachedDistanceRunRawNum; // 0x2C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISnakelikeMove _snakelikeMoveSetting; // 0x30

	// Properties
	public bool enable { /* [XID] */ /* 0x000000018986C1C0-0x000000018986C1E0 */ get => default; /* [XID] */ /* 0x0000000189ADF470-0x0000000189ADF490 */ set {} } // 0x0000000183DFAD40-0x0000000183DFADE0 0x0000000183DFB5C0-0x0000000183DFB670
	public MoveCategoryAI moveCategory { /* [XID] */ /* 0x0000000189AE6C70-0x0000000189AE6C90 */ get => default; /* [XID] */ /* 0x0000000189B49DD0-0x0000000189B49DF0 */ set {} } // 0x0000000183DFAE90-0x0000000183DFAF30 0x0000000183DFA310-0x0000000183DFA3C0
	public bool useNavMesh { /* [XID] */ /* 0x0000000189AF5DD0-0x0000000189AF5DF0 */ get => default; /* [XID] */ /* 0x0000000189AFD290-0x0000000189AFD2B0 */ private set {} } // 0x0000000183DFB7C0-0x0000000183DFB860 0x0000000183DFB670-0x0000000183DFB720
	public string navMeshAgentName { /* [XID] */ /* 0x000000018971E9A0-0x000000018971E9C0 */ get => default; /* [XID] */ /* 0x0000000189B0C290-0x0000000189B0C2B0 */ private set {} } // 0x0000000183DFBD60-0x0000000183DFBE00 0x0000000183DFADE0-0x0000000183DFAE90
	public float almostReachedDistanceWalk { /* [XID] */ /* 0x0000000189B13870-0x0000000189B13890 */ get => default; /* [XID] */ /* 0x0000000189B1AEC0-0x0000000189B1AEE0 */ private set {} } // 0x0000000183DFB430-0x0000000183DFB510 0x0000000183DFA8E0-0x0000000183DFA9C0
	public float almostReachedDistanceRun { /* [XID] */ /* 0x0000000189A35B40-0x0000000189A35B60 */ get => default; /* [XID] */ /* 0x0000000189B29AE0-0x0000000189B29B00 */ private set {} } // 0x0000000183DFB050-0x0000000183DFB130 0x0000000183DFC0B0-0x0000000183DFC190
	public ConfigAISnakelikeMove snakelikeMoveSetting { /* [XID] */ /* 0x000000018990D920-0x000000018990D940 */ get => default; /* [XID] */ /* 0x0000000189B38730-0x0000000189B38750 */ private set {} } // 0x0000000183DFB720-0x0000000183DFB7C0 0x0000000183DFB510-0x0000000183DFB5C0

	// Constructors
	public ConfigAIMove() {} // 0x0000000183DFC230-0x0000000183DFC300

	// Methods
	// [XID] // 0x0000000189717020-0x0000000189717040
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DFBE00-0x0000000183DFBF70
	// [XID] // 0x0000000189B47A60-0x0000000189B47A80
	public void InitEmpty() {} // 0x0000000183DFAF30-0x0000000183DFB050
	[BlackList] // 0x0000000189B4F1F0-0x0000000189B4F230
	// [XID] // 0x0000000189B4F1F0-0x0000000189B4F230
	public bool FromJson(JSONNode node) => default; // 0x0000000183DFA9C0-0x0000000183DFAD40
	// [XID] // 0x0000000189B59A20-0x0000000189B59A40
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183DF9700-0x0000000183DF9E10
	// [XID] // 0x0000000189B611D0-0x0000000189B611F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D9B */, bool useObjectPool = false /* Metadata: 0x00AF6D9F */) => default; // 0x0000000183DFB130-0x0000000183DFB430
	// [XID] // 0x0000000189B68A40-0x0000000189B68A60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DA0 */, bool useObjectPool = false /* Metadata: 0x00AF6DA4 */) => default; // 0x0000000183DFA3C0-0x0000000183DFA8E0
	[BlackList] // 0x0000000189B6FFA0-0x0000000189B6FFE0
	// [XID] // 0x0000000189B6FFA0-0x0000000189B6FFE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DF9E10-0x0000000183DFA0E0
	// [XID] // 0x0000000189B7A510-0x0000000189B7A530
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DFB860-0x0000000183DFBD60
	[BlackList] // 0x0000000189B81C70-0x0000000189B81CB0
	// [XID] // 0x0000000189B81C70-0x0000000189B81CB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183DFA0E0-0x0000000183DFA180
	[BlackList] // 0x0000000189B8BF40-0x0000000189B8BF80
	// [XID] // 0x0000000189B8BF40-0x0000000189B8BF80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183DFA180-0x0000000183DFA310
	[BlackList] // 0x0000000189B96400-0x0000000189B96440
	// [XID] // 0x0000000189B96400-0x0000000189B96440
	public virtual void ReturnToObjectPool() {} // 0x0000000183DFC190-0x0000000183DFC230
	[BlackList] // 0x0000000189BA0970-0x0000000189BA09B0
	// [XID] // 0x0000000189BA0970-0x0000000189BA09B0
	public virtual void OnPoolAllocated() {} // 0x0000000183DFC010-0x0000000183DFC0B0
	[BlackList] // 0x0000000189BAAFE0-0x0000000189BAB020
	// [XID] // 0x0000000189BAAFE0-0x0000000189BAB020
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183DFBF70-0x0000000183DFC010
}

