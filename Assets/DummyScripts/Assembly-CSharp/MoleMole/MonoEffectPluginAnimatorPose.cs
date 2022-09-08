/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginAnimatorPose : BaseMonoEffectPlugin // TypeDefIndex: 19684
	{
		// Fields
		private Animator _animator; // 0x28
		private LCPose _lcPose; // 0x30
		private ActorAbilityPlugin _ablityPlugin; // 0x38
		public float valueCheckInterval; // 0x40
		private float _tickTimeLeft; // 0x44
		public bool attachToOwnerPoseID; // 0x48
		public bool attachToOwnerGlobalValue; // 0x49
		public string[] FallowedFloatGlobalValueKeys; // 0x50
		private Dictionary<int, bool> _boolPersistentParams; // 0x58
		private Dictionary<int, int> _intPersistentParams; // 0x60
	
		// Constructors
		public MonoEffectPluginAnimatorPose() {} // 0x000000018469F920-0x000000018469F9C0
	
		// Methods
		// [XID] // 0x00000001896BBD80-0x00000001896BBDA0
		public override void Awaked() {} // 0x000000018469DAD0-0x000000018469DC60
		// [XID] // 0x00000001896C32C0-0x00000001896C32E0
		public override void Init() {} // 0x000000018469E990-0x000000018469ED00
		// [XID] // 0x00000001896CA810-0x00000001896CA830
		public override void Clear() {} // 0x000000018469DE90-0x000000018469E0D0
		// [XID] // 0x00000001896D1EA0-0x00000001896D1EC0
		public override void Tick(float inDeltaTime) {} // 0x000000018469F820-0x000000018469F920
		// [XID] // 0x00000001896D96F0-0x00000001896D9710
		private void OnPoseIDChanged(int fromPose, int toPose) {} // 0x000000018469ED00-0x000000018469EE50
		// [XID] // 0x00000001896E0E90-0x00000001896E0EB0
		private void UpdateFromGlobalValue() {} // 0x000000018469DC60-0x000000018469DE90
		// [XID] // 0x00000001896E80C0-0x00000001896E80E0
		public void SetTrigger(string triggerName) {} // 0x000000018469F720-0x000000018469F820
		// [IDTag] // 0x00000001896EF760-0x00000001896EF7A0
		// [XID] // 0x00000001896EF760-0x00000001896EF7A0
		public void SetBool(string boolName, bool value, bool persistent) {} // 0x000000018469F530-0x000000018469F630
		// [IDTag] // 0x00000001896F9E10-0x00000001896F9E50
		// [XID] // 0x00000001896F9E10-0x00000001896F9E50
		private void SetBool(int boolName, bool value, bool persistent) {} // 0x000000018469EE50-0x000000018469EFE0
		// [IDTag] // 0x0000000189704550-0x0000000189704590
		// [XID] // 0x0000000189704550-0x0000000189704590
		public void SetInt(string intName, int value, bool persistent) {} // 0x000000018469F630-0x000000018469F720
		// [IDTag] // 0x000000018970F000-0x000000018970F040
		// [XID] // 0x000000018970F000-0x000000018970F040
		private void SetInt(int intName, int value, bool persistent) {} // 0x000000018469F0A0-0x000000018469F220
		// [XID] // 0x0000000189719730-0x0000000189719750
		private void ClearPersistentParams() {} // 0x000000018469E200-0x000000018469E2C0
		// [XID] // 0x0000000189720C30-0x0000000189720C50
		private void SyncAnimatorParameters() {} // 0x000000018469E6B0-0x000000018469E990
		// [XID] // 0x00000001897282B0-0x00000001897282D0
		public override void Enabled() {} // 0x000000018469E0D0-0x000000018469E180
		// [XID] // 0x000000018972F990-0x000000018972F9B0
		public void SetAnimatorParameters(Dictionary<int, bool> boolParams, Dictionary<int, int> intParams) {} // 0x000000018469F220-0x000000018469F530
		// [XID] // 0x00000001897373E0-0x0000000189737400
		public void GetAnimatorParameters(ref Dictionary<int, bool> boolParams, ref Dictionary<int, int> intParams) {} // 0x000000018469E2C0-0x000000018469E650
	}
}
