/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoEffectPluginElementView : BaseMonoEffectPlugin // TypeDefIndex: 19710
	{
		// Fields
		// [Header] // 0x0000000189B134D0-0x0000000189B13500
		public ElementViewShowType elementViewShowType; // 0x28
		// [Header] // 0x0000000189B1C660-0x0000000189B1C690
		public ElementType elementViewElementType; // 0x2C
		// [Header] // 0x0000000189B25210-0x0000000189B25240
		public float residualDelay; // 0x30
		private float _residualDelay; // 0x34
		private bool _elementVisiable; // 0x38
		private LevelSceneElementViewPlugin _levelElementViewPlugin; // 0x40
	
		// Nested types
		public enum ElementViewShowType // TypeDefIndex: 19711
		{
			AlwaysShow = 0,
			OnlyShowInElementView = 1,
			OnlyShowInNotElementView = 2
		}
	
		// Constructors
		public MonoEffectPluginElementView() {} // 0x0000000184E3EB70-0x0000000184E3EC00
	
		// Methods
		// [XID] // 0x0000000189B2DDB0-0x0000000189B2DDD0
		public override void Awaked() {} // 0x0000000184E3DF90-0x0000000184E3E0E0
		// [XID] // 0x0000000189B35220-0x0000000189B35240
		public override void Init() {} // 0x0000000184E3E570-0x0000000184E3E740
		// [XID] // 0x0000000189B3CB00-0x0000000189B3CB20
		public override void Clear() {} // 0x0000000184E3E0E0-0x0000000184E3E280
		// [XID] // 0x0000000189B447D0-0x0000000189B447F0
		protected virtual void OnStartElementView() {} // 0x0000000184E3E980-0x0000000184E3EA30
		// [XID] // 0x0000000189B4C040-0x0000000189B4C060
		private void OnFinishElementView() {} // 0x0000000184E3E280-0x0000000184E3E330
		// [XID] // 0x0000000189B535A0-0x0000000189B535C0
		public override void Tick(float inDeltaTime) {} // 0x0000000184E3EA90-0x0000000184E3EB70
		// [XID] // 0x0000000189B5ADD0-0x0000000189B5ADF0
		private void UpdateEffect(bool inElementView, bool forceUpdateVisiable = false /* Metadata: 0x00AFCCA3 */) {} // 0x0000000184E3E740-0x0000000184E3E980
		// [XID] // 0x0000000189B62290-0x0000000189B622B0
		private void EffSetElementVisiable(bool isView) {} // 0x0000000184E3E410-0x0000000184E3E570
	}
}
