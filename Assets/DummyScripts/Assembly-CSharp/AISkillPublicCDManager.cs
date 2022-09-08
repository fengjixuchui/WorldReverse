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

public class AISkillPublicCDManager // TypeDefIndex: 20462
{
	// Fields
	private EntityTimer _timer; // 0x10
	private Dictionary<string, PublicAISkillCD> _publicCDs; // 0x18

	// Nested types
	private class PublicAISkillCD // TypeDefIndex: 20463
	{
		// Fields
		public float timer; // 0x10
		public ConfigPublicAISkillCD config; // 0x18

		// Constructors
		public PublicAISkillCD() {} // 0x00000001813383A0-0x0000000181338410
	}

	// Constructors
	public AISkillPublicCDManager() {} // 0x0000000181342060-0x0000000181342370

	// Methods
	// [XID] // 0x0000000189B8BA80-0x0000000189B8BAA0
	public void Clear() {} // 0x0000000181341A70-0x0000000181341B50
	// [XID] // 0x0000000189B932D0-0x0000000189B932F0
	public void UpdateCD(float inDeltaTime) {} // 0x0000000181341B50-0x0000000181341D20
	// [XID] // 0x0000000189ABE700-0x0000000189ABE720
	public bool CanUseSkill(string pCDName, BaseEntity targetEntity) => default; // 0x0000000181341F00-0x0000000181342060
	// [XID] // 0x00000001899B5C00-0x00000001899B5C20
	public void SetSkillUsed(string pCDName) {} // 0x0000000181341D20-0x0000000181341F00
}

