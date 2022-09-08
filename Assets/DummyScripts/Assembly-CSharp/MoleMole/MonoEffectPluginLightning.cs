/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using DigitalRuby.ThunderAndLightning;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x000000018987D4B0-0x000000018987D500
	public sealed class MonoEffectPluginLightning : BaseMonoEffectPlugin // TypeDefIndex: 19725
	{
		// Fields
		private Vector3 beginPos; // 0x28
		private float lifeTime; // 0x34
		private LightningBoltPrefabScript lightning; // 0x38
		private Transform followerTarget; // 0x40
		private bool isDestroy; // 0x48
		public bool reverse; // 0x49
		public bool fixedTarget; // 0x4A
		public Vector3 offsetTarget; // 0x4C
	
		// Constructors
		public MonoEffectPluginLightning() {} // 0x0000000184E499F0-0x0000000184E49AD0
	
		// Methods
		// [XID] // 0x0000000189888C40-0x0000000189888C60
		public override void Init() {} // 0x0000000184E48C20-0x0000000184E48DF0
		// [XID] // 0x0000000189890040-0x0000000189890060
		private void SetPath(Vector3 beginPos, Vector3 targetPos) {} // 0x0000000184E48F80-0x0000000184E492A0
		// [XID] // 0x0000000189897540-0x0000000189897560
		public override void Tick(float inDeltaTime) {} // 0x0000000184E49750-0x0000000184E499F0
		// [XID] // 0x000000018989EA60-0x000000018989EA80
		public override bool IsToBeDeallocated() => default; // 0x0000000184E48DF0-0x0000000184E48E90
		// [XID] // 0x00000001898A6500-0x00000001898A6520
		public override void Clear() {} // 0x0000000184E48A40-0x0000000184E48B30
		// [XID] // 0x00000001898ADC50-0x00000001898ADC70
		public override void SetTargetPos(Vector3 pos) {} // 0x0000000184E492A0-0x0000000184E49750
	}
}
