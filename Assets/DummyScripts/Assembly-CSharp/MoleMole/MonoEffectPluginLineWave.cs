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
	public class MonoEffectPluginLineWave : BaseMonoEffectPlugin // TypeDefIndex: 19677
	{
		// Fields
		protected float _ampT; // 0x28
		public Origins origin; // 0x2C
		// [Header] // 0x0000000189739FC0-0x0000000189739FF0
		public bool hitSceneTest; // 0x30
		public HitMask hitLayerMask; // 0x34
		public bool stickToWater; // 0x38
		public bool lineThoughWater; // 0x39
		protected int _layerMask; // 0x3C
		protected static RaycastHit _hitscanHit; // 0x00
		// [Header] // 0x0000000189743320-0x0000000189743350
		public string hitEffectPartternName; // 0x40
		protected int _hitEffectIndex; // 0x48
		protected bool _isHitScene; // 0x4C
		protected bool _forceFireHitEff; // 0x4D
		// [Header] // 0x000000018974C510-0x000000018974C540
		public string hitWaterEffectPatternName; // 0x50
		protected int _hitWaterEffectIndex; // 0x58
		// [Header] // 0x00000001897552A0-0x00000001897552D0
		public string endEffectPartternName; // 0x60
		protected int _endEffectIndex; // 0x68
		protected Vector3 _hitEffLrOffSet; // 0x6C
		protected const float HIT_INVENTIAL = 0.1f; // Metadata: 0x00AFCC4E
		protected float _testHitTimeLeft; // 0x78
		// [Header] // 0x00000001898B5100-0x00000001898B5130
		public int size; // 0x7C
		public EffectPluginDynamicFloat length; // 0x80
		public EffectPluginDynamicFloat amp; // 0x88
		protected float _start; // 0x90
		public LineRenderer lrComp; // 0x98
		private ActorAbilityPlugin _ablityPlugin; // 0xA0
		private bool _firstUpdate; // 0xA8
		protected bool _lastHitWater; // 0xA9
		private Vector3 _pointEffPos; // 0xAC
		private MonoEffectProxy _pointEffProxy; // 0xB8
		private MonoEffectProxy _hitProxy; // 0xC0
		private MonoEffectProxy _endProxy; // 0xC8
		private MonoEffectProxy _hitWaterProxy; // 0xD0
	
		// Nested types
		public enum Origins // TypeDefIndex: 19678
		{
			Start = 0,
			Middle = 1
		}
	
		public enum HitMask // TypeDefIndex: 19679
		{
			Default = 0,
			Scene = 1,
			BulletHit = 2
		}
	
		// Constructors
		public MonoEffectPluginLineWave() {} // 0x0000000184E4DD50-0x0000000184E4DEB0
	
		// Methods
		// [XID] // 0x0000000189766D80-0x0000000189766DA0
		public override void Awaked() {} // 0x0000000184E4BB20-0x0000000184E4BC40
		// [XID] // 0x000000018976E300-0x000000018976E320
		public override void Init() {} // 0x0000000184E4CC30-0x0000000184E4D480
		// [XID] // 0x0000000189775BA0-0x0000000189775BC0
		public override void Tick(float inDeltaTime) {} // 0x0000000184E4D910-0x0000000184E4DD50
		// [XID] // 0x000000018977D370-0x000000018977D390
		public override void Clear() {} // 0x0000000184E4BF80-0x0000000184E4C290
		// [XID] // 0x0000000189784D80-0x0000000189784DA0
		public override void Disabled() {} // 0x0000000184E4C290-0x0000000184E4C440
		// [XID] // 0x000000018978C270-0x000000018978C290
		protected virtual void Points() {} // 0x0000000184E4C440-0x0000000184E4CB50
		// [XID] // 0x0000000189793820-0x0000000189793840
		protected bool HitSceneTest(Vector3 start, Vector3 forward, float range) => default; // 0x0000000184E4BCA0-0x0000000184E4BE00
		// [XID] // 0x000000018979BA30-0x000000018979BA50
		protected void PointEffectPosition(Vector3 point, bool hitScene, bool hitWater = false /* Metadata: 0x00AFCC4D */) {} // 0x0000000184E4BE00-0x0000000184E4BF80
		// [XID] // 0x00000001897A2E20-0x00000001897A2E40
		private void UpdatePointEffect() {} // 0x0000000184E4D480-0x0000000184E4D720
		// [XID] // 0x00000001897AA4C0-0x00000001897AA4E0
		protected bool IsHitWater(Transform hitTran) => default; // 0x0000000184E4D720-0x0000000184E4D8B0
	}
}
