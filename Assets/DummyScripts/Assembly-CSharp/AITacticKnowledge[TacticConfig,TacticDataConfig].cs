/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public abstract class AITacticKnowledge<TacticConfig, TacticDataConfig> : Switchable, IAutoAllocRecycle // TypeDefIndex: 20002
	where TacticConfig : ConfigAITacticBaseSetting
{
	// Fields
	protected TacticConfig _config;
	protected TacticDataConfig _currentSetting;
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	protected AITacticCondition _condition;

	// Properties
	public TacticConfig config { get; }
	public TacticDataConfig data { get; }
	protected abstract TacticDataConfig defaultSetting { get; }
	protected abstract Dictionary<SimpleSafeInt32, TacticDataConfig> specifications { get; }
	protected virtual bool forceEnable { get; }

	// Constructors
	protected AITacticKnowledge() {}

	// Methods
	[BlackList] // 0x0000000189811090-0x00000001898110A0
	public override void AutoAllocTypeFields() {}
	[BlackList] // 0x0000000189811090-0x00000001898110A0
	public override void AutoRecycleTypeFields() {}
	[BlackList] // 0x0000000189811090-0x00000001898110A0
	public override void ReturnToObjectPool() {}
	public void LoadData(TacticConfig tacticConfig) {}
	public void SwitchSetting(int poseID) {}
	public bool MandatoryCheck(AIKnowledge knowledge) => default;
	public bool NerveCheck(AIKnowledge knowledge) => default;
}

