/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AIActionControl : AIBaseControl // TypeDefIndex: 20419
{
	// Fields
	private AIActionControlState _actionState; // 0x18
	private List<AISkillInfo> _validCandidates; // 0x20
	private LCAIBeta _lcai; // 0x28

	// Constructors
	public AIActionControl() {} // Dummy constructor
	public AIActionControl(AIKnowledge knowledge, LCAIBeta lcai) {} // 0x000000018131A220-0x000000018131A2E0

	// Methods
	// [XID] // 0x0000000189654130-0x0000000189654150
	public void ExecuteAction(AIDecision decision) {} // 0x0000000181319410-0x0000000181319D10
	// [IDTag] // 0x0000000189723890-0x00000001897238D0
	// [XID] // 0x0000000189723890-0x00000001897238D0
	private void SelectSkill(AISkillInfo skill) {} // 0x0000000181318D20-0x0000000181318E10
	// [IDTag] // 0x000000018972E010-0x000000018972E050
	// [XID] // 0x000000018972E010-0x000000018972E050
	private void SelectSkill(List<AISkillInfo> skillCandidates, bool skipPrepare = true /* Metadata: 0x00AFDA1F */) {} // 0x00000001813185F0-0x0000000181318D20
	// [XID] // 0x0000000189738830-0x0000000189738850
	private void CastSkill() {} // 0x0000000181318350-0x0000000181318550
	// [XID] // 0x00000001897FE7B0-0x00000001897FE7D0
	private void OnSkillStart() {} // 0x0000000181319D10-0x000000018131A220
	// [XID] // 0x0000000189BDBC20-0x0000000189BDBC40
	private void OnSkillFinish() {} // 0x0000000181317EC0-0x0000000181318280
	// [XID] // 0x000000018974F110-0x000000018974F130
	private void OnSkillFail(bool needTriggerCD = true /* Metadata: 0x00AFDA20 */) {} // 0x0000000181318E10-0x0000000181319410
	// [XID] // 0x00000001897567E0-0x0000000189756800
	public void Clear() {} // 0x0000000181318550-0x00000001813185F0
}

