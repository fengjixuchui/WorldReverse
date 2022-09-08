/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public sealed class ActorFSMStateReaction : ActorFSMState, IAutoAllocRecycle // TypeDefIndex: 19938
{
	// Fields
	private const float reactionTimeMax = 3f; // Metadata: 0x00AFD0F2
	private float reactionTime; // 0x30

	// Constructors
	public ActorFSMStateReaction() {} // 0x0000000182DEDFC0-0x0000000182DEE030

	// Methods
	[BlackList] // 0x00000001896D65E0-0x00000001896D6620
	// [XID] // 0x00000001896D65E0-0x00000001896D6620
	public override void AutoAllocTypeFields() {} // 0x0000000182DED430-0x0000000182DED4D0
	[BlackList] // 0x00000001896E0E10-0x00000001896E0E50
	// [XID] // 0x00000001896E0E10-0x00000001896E0E50
	public override void AutoRecycleTypeFields() {} // 0x0000000182DED4D0-0x0000000182DED580
	[BlackList] // 0x00000001896EB0C0-0x00000001896EB100
	// [XID] // 0x00000001896EB0C0-0x00000001896EB100
	public override void ReturnToObjectPool() {} // 0x0000000182DEDF20-0x0000000182DEDFC0
	// [XID] // 0x00000001896F57F0-0x00000001896F5810
	public void Init(NpcActor actor, ActorFSMBlackBoard board) {} // 0x0000000182DED690-0x0000000182DED770
	// [XID] // 0x00000001896FCFF0-0x00000001896FD010
	public override void Reason(float deltaTime) {} // 0x0000000182DED770-0x0000000182DED850
	// [XID] // 0x0000000189704480-0x00000001897044A0
	public override void DoBeforeEntering() {} // 0x0000000182DED850-0x0000000182DEDCF0
	// [XID] // 0x000000018970BC70-0x000000018970BC90
	public override void OnResetFreeStyleTrigger() {} // 0x0000000182DED5E0-0x0000000182DED690
	// [XID] // 0x00000001897135C0-0x00000001897135E0
	public override void Act(float deltaTime) {} // 0x0000000182DEDE10-0x0000000182DEDEC0
}

