/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.AI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AIHasPathChecker // TypeDefIndex: 20497
{
	// Fields
	public NavMeshQueryFilter queryFilter; // 0x10
	public Vector3 queryDestination; // 0x20
	public NavMeshPath syncQueryPath; // 0x30
	public float syncQueryNextAvailableTime; // 0x38
	public AsyncNavMeshPathQuery asyncQuery; // 0x40
	public bool asyncQueryAvailable; // 0x48

	// Nested types
	public enum QueryStatus // TypeDefIndex: 20498
	{
		NOTHING = 0,
		WAITING = 1,
		DONE = 2,
		FAIL = 3
	}

	// Constructors
	public AIHasPathChecker() {} // Dummy constructor
	public AIHasPathChecker(int areaMaskIn, int agentTypeIDIn) {} // 0x0000000180FD2EB0-0x0000000180FD2FC0

	// Methods
	// [XID] // 0x0000000189802410-0x0000000189802430
	public void Destroy() {} // 0x0000000180FD29F0-0x0000000180FD2AA0
	// [XID] // 0x0000000189809860-0x0000000189809880
	public void RequestPathSync(Vector3 startPos, Vector3 targetPos, float currentTime) {} // 0x0000000180FD2880-0x0000000180FD29F0
	// [XID] // 0x0000000189811010-0x0000000189811030
	public void RequestPathAsync(Vector3 startPos, Vector3 targetPos, NavMeshSurface surface) {} // 0x0000000180FD2C70-0x0000000180FD2EB0
	// [XID] // 0x0000000189818BB0-0x0000000189818BD0
	public QueryStatus UpdateQueryAsync(ref Vector3 endPos) => default; // 0x0000000180FD2AA0-0x0000000180FD2C70
}

