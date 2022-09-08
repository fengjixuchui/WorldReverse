/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class SpawnRuleExtension : MonoBehaviour // TypeDefIndex: 9321
	{
		// Constructors
		public SpawnRuleExtension() {} // 0x0000000186448D90-0x0000000186448DF0
	
		// Methods
		// [XID] // 0x000000018982FBF0-0x000000018982FC10
		public virtual void Initialise() {} // 0x0000000186448AA0-0x0000000186448B40
		// [XID] // 0x00000001898373D0-0x00000001898373F0
		public virtual bool AffectsTextures() => default; // 0x0000000186448940-0x00000001864489E0
		// [XID] // 0x00000001897837B0-0x00000001897837D0
		public virtual bool AffectsDetails() => default; // 0x00000001864488A0-0x0000000186448940
		// [XID] // 0x00000001899C13D0-0x00000001899C13F0
		public virtual float GetFitness(float fitness, ref SpawnInfo spawnInfo) => default; // 0x00000001864489E0-0x0000000186448AA0
		// [XID] // 0x000000018984D6D0-0x000000018984D6F0
		public virtual bool OverridesSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo) => default; // 0x0000000186448B40-0x0000000186448C10
		// [XID] // 0x0000000189854670-0x0000000189854690
		public virtual void Spawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo) {} // 0x0000000186448CD0-0x0000000186448D90
		// [XID] // 0x0000000189A2E0A0-0x0000000189A2E0C0
		public virtual void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo) {} // 0x0000000186448C10-0x0000000186448CD0
	}
}
