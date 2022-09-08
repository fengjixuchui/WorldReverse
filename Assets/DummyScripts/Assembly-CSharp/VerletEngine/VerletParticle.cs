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
	public class VerletParticle // TypeDefIndex: 31417
	{
		// Fields
		public ComputeThreadTransform cachedBoneTransform; // 0x10
		public Matrix4x4 refPoseBoneWorldTransform; // 0x9C
		public Quaternion refPoseBoneWorldRotation; // 0xDC
		public bool isEndBone; // 0xEC
		public int boneLineIndex; // 0xF0
		public int childCount; // 0xF4
		public int rootListIndex; // 0xF8
		public bool bBoneTransformValid; // 0xFC
		private string _boneName; // 0x100
		private Transform _boneTransform; // 0x108
		public Vector3 m_InitLocalPosition; // 0x110
		public Quaternion m_InitLocalRotation; // 0x11C
		public Vector3 m_LastLocalPosition; // 0x12C
		public Quaternion m_LastLocalRotation; // 0x138
		public float m_RotateAngleY; // 0x148
		public int m_RootIndex; // 0x14C
		public int m_ParentIndex; // 0x150
		public float m_Damping; // 0x154
		public float m_Elasticity; // 0x158
		public float m_Stiffness; // 0x15C
		public float m_Inert; // 0x160
		public float m_lastDamping; // 0x164
		public float m_lastElasticity; // 0x168
		public float m_lastStiffness; // 0x16C
		public float m_lastInert; // 0x170
		public float m_Radius; // 0x174
		public float m_BoneLength; // 0x178
		public Vector3 m_EndOffset; // 0x17C
		public Vector3 m_Position; // 0x188
		public Vector3 m_PrevPosition; // 0x194
		public Vector3 m_posOffset; // 0x1A0
		public float m_angleDiff; // 0x1AC
		public float m_curveValue; // 0x1B0
		public Vector3 m_appliedWindforce; // 0x1B4
		public float m_windForceMultiplier; // 0x1C0
		private Queue<BonePosHistory> _bonePosHistories; // 0x1C8
		private BonePosHistory _lastHistory; // 0x1D0
	
		// Properties
		public string m_BoneName { get => default; } // 0x0000000185243E20-0x0000000185243E80 
		public Transform m_BoneTransform { get => default; set {} } // 0x0000000185243E80-0x0000000185243EE0 0x0000000185243F40-0x0000000185244030
	
		// Nested types
		public struct BonePosHistory // TypeDefIndex: 31418
		{
			// Fields
			public int frameIndex; // 0x00
			public Vector3 pos; // 0x04
			public Vector3 toPrevDelta; // 0x10
		}
	
		// Constructors
		public VerletParticle() {} // 0x0000000185243BB0-0x0000000185243E20
	
		// Methods
		public void CacheDynamicBoneRootListIndex(Transform[] rootList) {} // 0x00000001852413F0-0x0000000185241630
		public Vector3 GetRestPos_ComputeThread(VerletParticle parent) => default; // 0x0000000185241630-0x00000001852417C0
		public void UpdateKeepShapeToParent_ComputeThread(ref VerletParticle parent, float weight, float boneLenToParent, Vector3 restPos) {} // 0x00000001852425B0-0x0000000185242910
		public void UpdateVerlet_ComputeThread(Vector3 objectMove, Vector3 acceleration, float timeStep, float lastTimestep = -1f /* Metadata: 0x00B126E4 */, float dbTimeStep = -1f /* Metadata: 0x00B126E8 */) {} // 0x0000000185243110-0x0000000185243630
		public override string ToString() => default; // 0x0000000185241E50-0x0000000185241EF0
		public void OnCalcPos() {} // 0x0000000185241B70-0x0000000185241D90
		public BonePosHistory[] GetSortedBonePosHistoryByDeltaDir() => default; // 0x0000000185241A60-0x0000000185241B70
		public void SetParams(float damping, float elasticity, float stiffness, float inert, float radius) {} // 0x0000000185241D90-0x0000000185241E50
		public bool isRoot() => default; // 0x0000000185243EE0-0x0000000185243F40
		public void UpdateVerlet(Vector3 objectMove, Vector3 acceleration, float timeStep, float lastTimestep = -1f /* Metadata: 0x00B126EC */, float dbTimeStep = -1f /* Metadata: 0x00B126F0 */) {} // 0x0000000185243630-0x0000000185243BB0
		public void UpdateKeepLengthToParent(ref VerletParticle parent, float boneLenToParent) {} // 0x00000001852423B0-0x00000001852425B0
		public void UpdateStiffnessToParent(ref VerletParticle parent, float weight, float boneLenToParent) {} // 0x0000000185242C70-0x0000000185243110
		public Vector3 GetRestPos(VerletParticle parent) => default; // 0x00000001852417C0-0x0000000185241A60
		public void UpdateKeepShapeToParent(ref VerletParticle parent, float weight, float boneLenToParent, Vector3 restPos) {} // 0x0000000185242910-0x0000000185242C70
		public void UpdateCollision(List<DynamicBoneColliderBaseMMD> colliders, float objectScale, ref VerletParticle parent) {} // 0x0000000185242250-0x00000001852423B0
		public void UpdateCollisionRayCast(LayerMask colliderMask, float objectScale) {} // 0x0000000185241F90-0x0000000185242250
	}
}
