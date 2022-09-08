/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace VerletEngine
{
	[Serializable]
	public class DynamicBoneWindForce // TypeDefIndex: 31419
	{
		// Fields
		[NonSerialized]
		public bool bNeedAdditiveWindForce; // 0x10
		[NonSerialized]
		public Vector3 cachedAnchorTransformPosition; // 0x14
		[NonSerialized]
		public Vector3 cachedAnchorPlaneNormal; // 0x20
		// [Header] // 0x00000001899722E0-0x0000000189972360
		// [Range] // 0x00000001899722E0-0x0000000189972360
		// [Tooltip] // 0x00000001899722E0-0x0000000189972360
		public float m_windForceMultiplier; // 0x2C
		// [Header] // 0x0000000189982A50-0x0000000189982A80
		public AnimationCurve m_multiplierDistrib; // 0x30
		// [Header] // 0x000000018998BAE0-0x000000018998BB30
		[HideInInspector] // 0x000000018998BAE0-0x000000018998BB30
		public bool m_isStationary; // 0x38
		// [Range] // 0x0000000189997DD0-0x0000000189997E30
		// [Tooltip] // 0x0000000189997DD0-0x0000000189997E30
		public float m_overrideDamping; // 0x3C
		// [Range] // 0x0000000189835F50-0x0000000189835FA0
		// [Tooltip] // 0x0000000189835F50-0x0000000189835FA0
		public float m_overrideElasticity; // 0x40
		// [Range] // 0x0000000189841A10-0x0000000189841A60
		// [Tooltip] // 0x0000000189841A10-0x0000000189841A60
		public float m_overrideStiffness; // 0x44
		// [Header] // 0x00000001899B7520-0x00000001899B75A0
		// [Range] // 0x00000001899B7520-0x00000001899B75A0
		// [Tooltip] // 0x00000001899B7520-0x00000001899B75A0
		public float m_windForceUpLimit; // 0x48
		// [Header] // 0x00000001899C7F60-0x00000001899C7FE0
		// [Header] // 0x00000001899C7F60-0x00000001899C7FE0
		// [Header] // 0x00000001899C7F60-0x00000001899C7FE0
		public AnimationCurve m_uplimitDistrib; // 0x50
		// [Tooltip] // 0x00000001899D9CE0-0x00000001899D9D10
		public float m_maxWind; // 0x58
		// [Tooltip] // 0x00000001899E2BB0-0x00000001899E2BE0
		public AnimationCurve m_windFrequencyDistrib; // 0x60
		private float m_startTime; // 0x68
		public float m_windChangeFrequency; // 0x6C
		public float m_frequencySwingRange; // 0x70
		// [Header] // 0x00000001899EB940-0x00000001899EB980
		[HideInInspector] // 0x00000001899EB940-0x00000001899EB980
		public float m_weatherWindSource; // 0x74
		// [Header] // 0x000000018998BAE0-0x000000018998BB30
		[HideInInspector] // 0x000000018998BAE0-0x000000018998BB30
		public float m_lastAppliedWindForce; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<int> m_endBoneIndex; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<Vector3> m_anchorToBoneDir; // 0x88
		public List<Vector3> computedAnchorToBoneDir; // 0x90
		// [Header] // 0x0000000189A0F4A0-0x0000000189A0F4D0
		public Transform m_anchor; // 0x98
		// [Header] // 0x0000000189A18330-0x0000000189A18360
		public Vector3 m_anchorPlaneNormal; // 0xA0
		private Rigidbody m_rigidbody; // 0xB0
		private float m_speedUpLimit; // 0xB8
		private DynamicBoneArray m_dynamicBoneArray; // 0xC0
	
		// Constructors
		public DynamicBoneWindForce() {} // 0x0000000185232C90-0x0000000185232DD0
	
		// Methods
		public void CacheForComputeThread() {} // 0x00000001852317A0-0x0000000185231A50
		public Vector3 GetWindForceForParticle_ComputeThread(ref Vector3 windForceSource, VerletParticle particle, ref float angleDiff, ref float curveValue) => default; // 0x0000000185231A50-0x0000000185231FC0
		public void Init(DynamicBoneArray dba, bool bKeeyStartTime = false /* Metadata: 0x00B126F4 */) {} // 0x0000000185232830-0x0000000185232AD0
		public Vector3 GetWindForceForParticle(Vector3 windForceSource, VerletParticle particle, ref float angleDiff, ref float curveValue) => default; // 0x0000000185231FC0-0x0000000185232830
		public bool OnUpdate() => default; // 0x0000000185232AD0-0x0000000185232C90
	}
}
