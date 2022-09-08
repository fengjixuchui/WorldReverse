/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AISkillContainer : IAutoAllocRecycle // TypeDefIndex: 19973
{
	// Fields
	public ConfigAISkillType skillType; // 0x10
	// [PooledField] // 0x0000000189831DC0-0x0000000189831DE0
	public List<AISkillInfo> allSkills; // 0x18
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public List<AISkillInfo> availableSkills; // 0x20

	// Constructors
	public AISkillContainer() {} // 0x00000001812B9140-0x00000001812B91A0

	// Methods
	[BlackList] // 0x00000001896EF720-0x00000001896EF760
	// [XID] // 0x00000001896EF720-0x00000001896EF760
	public virtual void AutoAllocTypeFields() {} // 0x00000001812B8D10-0x00000001812B8DF0
	[BlackList] // 0x00000001896F9DD0-0x00000001896F9E10
	// [XID] // 0x00000001896F9DD0-0x00000001896F9E10
	public virtual void AutoRecycleTypeFields() {} // 0x00000001812B8DF0-0x00000001812B8EB0
	[BlackList] // 0x0000000189704440-0x0000000189704480
	// [XID] // 0x0000000189704440-0x0000000189704480
	public virtual void ReturnToObjectPool() {} // 0x00000001812B90A0-0x00000001812B9140
	[BlackList] // 0x000000018970EF40-0x000000018970EF80
	// [XID] // 0x000000018970EF40-0x000000018970EF80
	public virtual void OnPoolAllocated() {} // 0x00000001812B9000-0x00000001812B90A0
	[BlackList] // 0x0000000189719650-0x0000000189719690
	// [XID] // 0x0000000189719650-0x0000000189719690
	public virtual void OnBeforePoolRecycled() {} // 0x00000001812B8F60-0x00000001812B9000
	// [XID] // 0x0000000189723970-0x0000000189723990
	public void InitContainer(ConfigAISkillType pSkillType) {} // 0x00000001812B8EB0-0x00000001812B8F60
}

