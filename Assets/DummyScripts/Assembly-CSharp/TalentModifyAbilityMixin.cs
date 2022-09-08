/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TalentModifyAbilityMixin : BaseTalentMixin // TypeDefIndex: 14629
{
	// Fields
	private string _abilityName; // 0x30
	private string _paramSpecial; // 0x38
	private float _paramDelta; // 0x40
	private float _paramRatio; // 0x44

	// Constructors
	public TalentModifyAbilityMixin() {} // 0x00000001843A3D30-0x00000001843A3D90

	// Methods
	// [XID] // 0x00000001899D96D0-0x00000001899D96F0
	public override void Init(ActorTalent instancedTalent, ConfigTalentMixin config) {} // 0x00000001843A39E0-0x00000001843A3CD0
	// [XID] // 0x00000001899E0CF0-0x00000001899E0D10
	public override void Destroy() {} // 0x00000001843A3270-0x00000001843A3310
	// [XID] // 0x0000000189689120-0x0000000189689140
	public void RefreshParam(string abilityName, string paramName, ref float delta, ref float ratio) {} // 0x00000001843A3860-0x00000001843A39E0
	// [XID] // 0x00000001899EFFC0-0x00000001899EFFE0
	private float Evaluate(DynamicArgument param) => default; // 0x00000001843A3310-0x00000001843A3860
}

