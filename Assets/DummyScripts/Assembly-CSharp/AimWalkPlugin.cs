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

public sealed class AimWalkPlugin : BaseComponentPlugin // TypeDefIndex: 11990
{
	// Fields
	private const float AIM_WALK_FILL_SPEED = 2f; // Metadata: 0x00AEB358
	private const float AIM_WALK_DROP_SPEED = 2f; // Metadata: 0x00AEB35C
	private bool _isAimWalking; // 0x58
	private bool _aimWalkChanged; // 0x59
	private float _aimWalkValue; // 0x5C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189705130-0x0000000189705150 */ get => default; } // 0x000000018416E4E0-0x000000018416E580 

	// Constructors
	public AimWalkPlugin() {} // 0x000000018416E470-0x000000018416E4E0

	// Methods
	// [XID] // 0x000000018970C7E0-0x000000018970C800
	public override void Tick(float inDeltaTime) {} // 0x000000018416E1D0-0x000000018416E470
	// [XID] // 0x000000018964B040-0x000000018964B060
	public void StartAimWalking() {} // 0x000000018416E040-0x000000018416E160
	// [XID] // 0x000000018971BA30-0x000000018971BA50
	public void StopAimWalking() {} // 0x000000018416DFA0-0x000000018416E040
}

