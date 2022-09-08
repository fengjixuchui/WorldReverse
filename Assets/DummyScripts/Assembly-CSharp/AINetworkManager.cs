/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AINetworkManager // TypeDefIndex: 20459
{
	// Fields
	private LCAIManager _aiManager; // 0x10
	private TimerReceiver _syncTimerThreatInfo; // 0x18
	private TimerReceiver _syncTimerSkillCD; // 0x20
	private TimerReceiver _syncTimerAiInfo; // 0x28
	private static readonly float SYNC_INTERVAL_THREATINFO; // 0x00
	private static readonly float SYNC_INTERVAL_SKILLCD; // 0x04
	private static readonly float SYNC_INTERVAL_AIINFO; // 0x08
	private int _prevLocalAvatarEnemyCount; // 0x30

	// Constructors
	public AINetworkManager() {} // Dummy constructor
	public AINetworkManager(LCAIManager aiManager) {} // 0x00000001813DDB60-0x00000001813DDBF0
	static AINetworkManager() {} // 0x00000001813DDAF0-0x00000001813DDB60

	// Methods
	// [XID] // 0x00000001898E1DB0-0x00000001898E1DD0
	public void InitNetworkManager() {} // 0x00000001813DC410-0x00000001813DC690
	// [XID] // 0x0000000189B57D90-0x0000000189B57DB0
	public void OnDestroy() {} // 0x00000001813DC690-0x00000001813DC760
	// [XID] // 0x00000001898F0F20-0x00000001898F0F40
	private bool SendSkillCD() => default; // 0x00000001813DD2F0-0x00000001813DDAF0
	// [XID] // 0x00000001898E9AB0-0x00000001898E9AD0
	private bool SendThreatInfo() => default; // 0x00000001813DCD70-0x00000001813DD2F0
	// [XID] // 0x0000000189B6E180-0x0000000189B6E1A0
	private bool SendAIInfo() => default; // 0x00000001813DC760-0x00000001813DCD70
}

