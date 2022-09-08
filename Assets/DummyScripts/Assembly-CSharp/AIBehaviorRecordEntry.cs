/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AIBehaviorRecordEntry // TypeDefIndex: 20504
{
	// Fields
	public string configName; // 0x10
	public string configID; // 0x18
	public Queue<LiveData> data; // 0x20

	// Nested types
	public struct LiveData // TypeDefIndex: 20505
	{
		// Fields
		public float currentTime; // 0x00
		public LiveProperty liveProperty; // 0x04
		public List<string> keyNotes; // 0x28
		public Vector3 currentPos; // 0x30
		public Vector3 bornPos; // 0x3C
		public Vector3? enterCombatPos; // 0x48
		public List<string> neuronStimulated; // 0x58
		public bool inDefendArea; // 0x60
		public bool inWater; // 0x61
		public string tactic; // 0x68
		public string move; // 0x70
		public string action; // 0x78
		public int poseID; // 0x80
		public bool effectVfxPreloaded; // 0x84
		public float distToPlayer; // 0x88
		public string alertness; // 0x90
		public float temperature; // 0x98
		public bool reachAlertThisFrame; // 0x9C
		public uint skillID; // 0xA0
		public SkillStatus skillStatus; // 0xA4
		public List<AISkillInfo> OnAlertSkillsReady; // 0xA8
		public List<AISkillInfo> OnNerveSkillsReady; // 0xB0
		public List<AISkillInfo> CombatSkillsReady; // 0xB8
		public List<AISkillInfo> FreeSkillsReady; // 0xC0
		public List<AISkillInfo> ActionPointSkillsReady; // 0xC8
		public LocoBaseTask locoTask; // 0xD0
		public LocoTaskState locoTaskState; // 0xD8
		public Vector3 locoTaskDestination; // 0xDC
		public int? animAlertness; // 0xE8
		public int? animMotionFlag; // 0xF0
	}

	public struct LiveProperty // TypeDefIndex: 20506
	{
		// Fields
		public bool enableVision; // 0x00
		public float viewRange; // 0x04
		public float fovHorizontal; // 0x08
		public float fovVertical; // 0x0C
		public float feelRange; // 0x10
		public float hearAttractionRange; // 0x14
		public float threatBroadcastRange; // 0x18
		public AILodStrategyType lodStrategy; // 0x1C
	}

	// Constructors
	public AIBehaviorRecordEntry() {} // 0x00000001820F0960-0x00000001820F09F0

	// Methods
	// [XID] // 0x000000018997C7D0-0x000000018997C7F0
	public void AddFrame(LiveData frameData) {} // 0x00000001820F0710-0x00000001820F0960
}

