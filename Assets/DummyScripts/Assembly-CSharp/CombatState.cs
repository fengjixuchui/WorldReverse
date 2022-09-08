/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombatState : State<CombatState> // TypeDefIndex: 11328
{
	// Properties
	public override uint audioStateValue { /* [XID] */ /* 0x00000001896A9B20-0x00000001896A9B40 */ get => default; } // 0x00000001833FDCF0-0x00000001833FDDD0 

	// Constructors
	public CombatState() {} // 0x00000001833FE0C0-0x00000001833FE130

	// Methods
	// [XID] // 0x00000001896B0AA0-0x00000001896B0AC0
	public override void Enter(IContext context) {} // 0x00000001833FDFD0-0x00000001833FE0C0
	// [XID] // 0x00000001896B8570-0x00000001896B8590
	public override IState Input(Input input) => default; // 0x00000001833FDB50-0x00000001833FDC70
	// [XID] // 0x00000001896BF620-0x00000001896BF640
	private IState TryTransitByAvailableAvatarCount(Input input) => default; // 0x00000001833FDA40-0x00000001833FDB50
	// [XID] // 0x00000001896C7030-0x00000001896C7050
	private IState TryTransitByEnemyStatus(Input input) => default; // 0x00000001833FD6C0-0x00000001833FD910
	// [XID] // 0x00000001896CE6C0-0x00000001896CE6E0
	private IState TrySetFiercenessRtpcValue(Input input) => default; // 0x00000001833FD910-0x00000001833FDA40
	// [XID] // 0x00000001896D5B70-0x00000001896D5B90
	private void SetEnemeyStates(ConfigAudioMusic config, Persistents persistents) {} // 0x00000001833FDDD0-0x00000001833FDFD0
}

