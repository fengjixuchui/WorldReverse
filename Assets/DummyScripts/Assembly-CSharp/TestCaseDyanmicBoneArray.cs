/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TestCaseDyanmicBoneArray // TypeDefIndex: 27682
{
	// Fields
	public int currentState; // 0x10
	public float currentTime; // 0x14
	public float totalTime; // 0x18
	public float autoFinishTime; // 0x1C
	public Transform transform; // 0x20
	public Hashtable blackboard; // 0x28
	public bool bFinished; // 0x30

	// Constructors
	protected TestCaseDyanmicBoneArray() {} // 0x0000000181FEA8F0-0x0000000181FEA970

	// Methods
	public static T CreateTestCase<T>(Transform monoParent, Hashtable inBlackBoard)
		where T : TestCaseDyanmicBoneArray => default;
	// [XID] // 0x000000018965EF00-0x000000018965EF20
	public void SetMonoTransformParent(Transform monoParent, Hashtable inBlackBoard) {} // 0x0000000181FEA690-0x0000000181FEA760
	// [XID] // 0x00000001896666E0-0x0000000189666700
	public virtual void OnActive() {} // 0x0000000181FEA5F0-0x0000000181FEA690
	// [XID] // 0x000000018966DE20-0x000000018966DE40
	public virtual void Tick() {} // 0x0000000181FEA760-0x0000000181FEA850
	// [XID] // 0x0000000189675C80-0x0000000189675CA0
	public virtual void LateTick() {} // 0x0000000181FEA850-0x0000000181FEA8F0
}

