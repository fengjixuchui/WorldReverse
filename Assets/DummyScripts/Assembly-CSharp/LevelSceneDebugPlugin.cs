/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneDebugPlugin : BaseComponentPlugin // TypeDefIndex: 12079
{
	// Fields
	private const int MSG_BOARD_ID = 70500000; // Metadata: 0x00AEB4A0
	private const float SHOW_MSG_BOARD_DIST = 40f; // Metadata: 0x00AEB4A4
	private const float SHOW_MSG_BOARD_UI_DIST = 2f; // Metadata: 0x00AEB4A8
	private Transform _msgBoardRoot; // 0x58
	private Dictionary<uint, DebugBoardInfo> _tempDebugBoardInfos; // 0x60
	private Dictionary<uint, GadgetEntity> _msgBoardGadgets; // 0x68
	private List<uint> _tempList; // 0x70
	private ObjectPoolWithConfigID<GadgetEntity> _gadgetEntityPool; // 0x78
	private float _lastCheckMsgBoardEntityTime; // 0x80
	private bool _show; // 0x84

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A5AD80-0x0000000189A5ADA0 */ get => default; } // 0x0000000182828BA0-0x0000000182828C40 

	// Constructors
	public LevelSceneDebugPlugin() {} // 0x0000000182828AA0-0x0000000182828BA0

	// Methods
	// [XID] // 0x0000000189A62580-0x0000000189A625A0
	public override void Init() {} // 0x0000000182828210-0x0000000182828300
	// [XID] // 0x0000000189A6A3C0-0x0000000189A6A3E0
	public override void Tick(float deltaTime) {} // 0x00000001828289D0-0x0000000182828AA0
	// [XID] // 0x0000000189A717B0-0x0000000189A717D0
	public override void Destroy() {} // 0x0000000182827210-0x00000001828272E0
	// [XID] // 0x0000000189A79290-0x0000000189A792B0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182828110-0x0000000182828210
	// [XID] // 0x0000000189A80920-0x0000000189A80940
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182828860-0x00000001828289D0
	// [XID] // 0x0000000189A88400-0x0000000189A88420
	private void AddMsgBoardEntity(DebugBoardInfo info) {} // 0x0000000182828450-0x0000000182828860
	// [XID] // 0x0000000189A8FDF0-0x0000000189A8FE10
	private void RemoveMsgBoadEntity(uint id) {} // 0x00000001828270A0-0x0000000182827210
	// [XID] // 0x0000000189A973D0-0x0000000189A973F0
	private void CheckMsgBoardEntity() {} // 0x00000001828272E0-0x0000000182827E60
	// [XID] // 0x0000000189A9E770-0x0000000189A9E790
	private void UpdateKeyboard() {} // 0x0000000182826920-0x00000001828270A0
	// [XID] // 0x0000000189AA6160-0x0000000189AA6180
	private void OnShakeOff() {} // 0x0000000182827E60-0x0000000182827F60
	// [XID] // 0x0000000189AAD7C0-0x0000000189AAD7E0
	private void StopSprint() {} // 0x0000000182827FE0-0x0000000182828110
}

