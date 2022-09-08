/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCScenePoint : LCBase // TypeDefIndex: 11762
{
	// Fields
	public bool useLocalEntity; // 0x130
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private uint _sceneID; // 0x134
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private uint _pointID; // 0x138
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private ConfigScenePoint _config; // 0x140
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool _unlocked; // 0x148
	private uint _level; // 0x14C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _openTime; // 0x150
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _closeTime; // 0x154
	private bool _isGroupLimit; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018965E8B0-0x000000018965E8D0 */ get => default; } // 0x0000000181C7CF40-0x0000000181C7CFE0 
	public uint sceneID { /* [XID] */ /* 0x000000018965D100-0x000000018965D120 */ get => default; } // 0x0000000181C7BF90-0x0000000181C7C030 
	public uint pointID { /* [XID] */ /* 0x00000001896646B0-0x00000001896646D0 */ get => default; } // 0x0000000181C7BD80-0x0000000181C7BE20 

	// Constructors
	public LCScenePoint() {} // 0x0000000181C7CEA0-0x0000000181C7CF40

	// Methods
	// [IDTag] // 0x000000018966BCF0-0x000000018966BD30
	// [XID] // 0x000000018966BCF0-0x000000018966BD30
	public void Init(uint sceneId, uint pointId, ConfigScenePoint config) {} // 0x0000000181C7BE20-0x0000000181C7BF90
	// [IDTag] // 0x0000000189676A90-0x0000000189676AD0
	// [XID] // 0x0000000189676A90-0x0000000189676AD0
	public override void Init() {} // 0x0000000181C7C240-0x0000000181C7C380
	// [XID] // 0x0000000189681440-0x0000000189681460
	public override void Destroy() {} // 0x0000000181C7AF30-0x0000000181C7B130
	// [XID] // 0x0000000189688F60-0x0000000189688F80
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181C7C030-0x0000000181C7C110
	// [XID] // 0x0000000189690A80-0x0000000189690AA0
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x0000000181C7C4D0-0x0000000181C7C670
	// [XID] // 0x0000000189698340-0x0000000189698360
	public void OpenDungeonEntry() {} // 0x0000000181C7CB80-0x0000000181C7CC80
	// [XID] // 0x0000000189A915A0-0x0000000189A915C0
	public void CloseDungeonEntry() {} // 0x0000000181C7A660-0x0000000181C7A750
	// [XID] // 0x00000001896A6960-0x00000001896A6980
	public void UpdateUnlocked(bool unlocked, bool init, bool isGroupLimit, bool canNotExplore) {} // 0x0000000181C7A9E0-0x0000000181C7AC30
	// [XID] // 0x00000001896AE050-0x00000001896AE070
	public void UpdateToBeExplored(bool unlocked, bool isGroupLimit) {} // 0x0000000181C7A560-0x0000000181C7A660
	// [XID] // 0x00000001898E9A50-0x00000001898E9A70
	public void UpdateUnfreezeGroupLimit(bool unlocked, bool isGroupLimit) {} // 0x0000000181C7BC00-0x0000000181C7BD00
	// [XID] // 0x00000001896BC980-0x00000001896BC9A0
	public void UpdateLevel(uint level, bool init) {} // 0x0000000181C7CD70-0x0000000181C7CEA0
	// [IDTag] // 0x00000001896C3EA0-0x00000001896C3EE0
	// [XID] // 0x00000001896C3EA0-0x00000001896C3EE0
	public void OnTriggerEnter(BaseEntity entity) {} // 0x0000000181C7B130-0x0000000181C7B1E0
	// [IDTag] // 0x00000001896CE680-0x00000001896CE6C0
	// [XID] // 0x00000001896CE680-0x00000001896CE6C0
	public void OnTriggerEnter() {} // 0x0000000181C7B1E0-0x0000000181C7BC00
	// [XID] // 0x00000001896D8A80-0x00000001896D8AA0
	private void OnDungeonQuitPointCB(uint param) {} // 0x0000000181C7CC80-0x0000000181C7CD70
	// [XID] // 0x00000001896E02B0-0x00000001896E02D0
	private void NotifySceneJumpPoint(uint entityRuntimeID, uint pointID, PersonalSceneJumpPoint config) {} // 0x0000000181C7A750-0x0000000181C7A9E0
	// [XID] // 0x00000001896E75E0-0x00000001896E7600
	private void JumpRequestPersonalSceneJumpHomeworld(uint pointID) {} // 0x0000000181C7C110-0x0000000181C7C240
	// [XID] // 0x00000001896EEBE0-0x00000001896EEC00
	private void JumpRequestPersonalSceneJump(uint pointID) {} // 0x0000000181C7C3E0-0x0000000181C7C4D0
	// [IDTag] // 0x00000001896F65C0-0x00000001896F6600
	// [XID] // 0x00000001896F65C0-0x00000001896F6600
	public void OnTriggerExit(BaseEntity entity) {} // 0x0000000181C7C670-0x0000000181C7C720
	// [IDTag] // 0x0000000189700A90-0x0000000189700AD0
	// [XID] // 0x0000000189700A90-0x0000000189700AD0
	public void OnTriggerExit() {} // 0x0000000181C7C720-0x0000000181C7CB10
	// [XID] // 0x000000018970B1D0-0x000000018970B1F0
	private void OnInteraction(uint runtimeID) {} // 0x0000000181C7AC30-0x0000000181C7AF30
}

