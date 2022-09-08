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

public class InterDelay : ISimplePoolObject // TypeDefIndex: 20847
{
	// Fields
	private static SimpleObjectPool<InterDelay> _pool; // 0x00
	private float _delayTime; // 0x10
	private float _timeCnt; // 0x14
	private float _timeCheckPoint; // 0x18
	private BaseInterAction _toDoInteraction; // 0x20

	// Properties
	public BaseInterAction interAction { /* [XID] */ /* 0x0000000189AFB880-0x0000000189AFB8A0 */ get => default; } // 0x00000001818CEF00-0x00000001818CEFA0 
	public float delayTime { /* [XID] */ /* 0x0000000189B19030-0x0000000189B19050 */ get => default; } // 0x00000001818CE9F0-0x00000001818CEAA0 

	// Constructors
	public InterDelay() {} // 0x00000001818CF0C0-0x00000001818CF130
	static InterDelay() {} // 0x00000001818CF050-0x00000001818CF0C0

	// Methods
	// [XID] // 0x0000000189AE4FC0-0x0000000189AE4FE0
	public static InterDelay Get(BaseInterAction interAction) => default; // 0x00000001818CEC50-0x00000001818CED60
	// [XID] // 0x0000000189AEC640-0x0000000189AEC660
	public static void Release(InterDelay delay) {} // 0x00000001818CEE10-0x00000001818CEF00
	// [XID] // 0x0000000189AF40D0-0x0000000189AF40F0
	public void ResetObject() {} // 0x00000001818CEFA0-0x00000001818CF050
	// [XID] // 0x0000000189B02F10-0x0000000189B02F30
	public void Init(BaseInterAction interAction) {} // 0x00000001818CEAA0-0x00000001818CEB90
	// [XID] // 0x0000000189B0A6C0-0x0000000189B0A6E0
	public void Tick() {} // 0x00000001818CEB90-0x00000001818CEC50
	// [XID] // 0x0000000189B11DE0-0x0000000189B11E00
	public bool IsDelayFinish() => default; // 0x00000001818CED60-0x00000001818CEE10
}

