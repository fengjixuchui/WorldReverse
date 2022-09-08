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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RoadPoint // TypeDefIndex: 27809
{
	// Fields
	public int index; // 0x10
	public Vector3 position; // 0x14
	public float yaw; // 0x20
	public float climbDir; // 0x24
	public float move_dir; // 0x28
	public float time; // 0x2C
	public float altitude; // 0x30
	public bool insertWhen; // 0x34
	public bool insertWhere; // 0x35
	public bool delay; // 0x36
	public float delayTime; // 0x38
	public bool shift2walk; // 0x3C
	public bool shift2sprint; // 0x3D
	public bool reachX; // 0x3E
	public bool reachY; // 0x3F
	public bool reachZ; // 0x40
	public float reachDim; // 0x44
	public float depth; // 0x48
	public float stamina; // 0x4C
	public uint skillNO; // 0x50
	public float bPX1; // 0x54
	public float bPY1; // 0x58
	public float bPZ1; // 0x5C
	public float scaleX1; // 0x60
	public float scaleY1; // 0x64
	public float scaleZ1; // 0x68
	public float rotateX1; // 0x6C
	public float rotateY1; // 0x70
	public float rotateZ1; // 0x74
	public uint monsterID; // 0x78
	public static Dictionary<string, Vector3> spawnPoints; // 0x00
	public float exceptionTime; // 0x7C
	public const float DEFAULT_EXCEPTION_TIME = 10f; // Metadata: 0x00B0CF27
	public RoadType Type; // 0x80

	// Nested types
	public enum RoadType // TypeDefIndex: 27810
	{
		Null = 0,
		Comments = 1,
		Teleport = 2,
		RunToPos = 3,
		WalkToPos = 4,
		Stop = 5,
		SetYaw = 6,
		WalkByTime = 7,
		RunByTime = 8,
		SprintByTime = 9,
		Jump = 10,
		ClimbByTime = 11,
		ClimbOutByTime = 12,
		Climb2ASL = 13,
		SwitchCamera4ward = 14,
		JoystickSteer = 15,
		JoystickSteerReachDim = 16,
		Delay = 17,
		DoSkill = 18,
		ReleaseSkill = 19,
		Flood = 20,
		Ebb = 21,
		Brick1 = 22,
		Demolish = 23,
		Reset = 24,
		Exhaused = 25,
		Recharge = 26,
		Stamina = 27,
		SpawnMonster = 28,
		Manual = 29
	}

	// Constructors
	public RoadPoint() {} // Dummy constructor
	public RoadPoint(int aIndex, JSONNode jNode) {} // 0x000000018463B630-0x000000018463B720
	static RoadPoint() {} // 0x000000018463B5A0-0x000000018463B630

	// Methods
	// [XID] // 0x00000001896AFC60-0x00000001896AFC80
	private void ParseJNode(JSONNode jNode) {} // 0x0000000184639560-0x000000018463B5A0
}

