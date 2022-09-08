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
	public class MonoEffectAfterImage : MonoBehaviour // TypeDefIndex: 19837
	{
		// Fields
		public const int ImageLimit = 20; // Metadata: 0x00AFCF1A
		public AfterImageFollowMode FollowMode; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Animator TargetAnimator; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Transform TargetRoot; // 0x28
		public Transform BoneRoot; // 0x30
		public float TimeLimit; // 0x38
		public int ImageNumber; // 0x3C
		private float _imageLifeTime; // 0x40
		public MaterialProperty[] materialProperty; // 0x48
		public bool useFixedMaterial; // 0x50
		public UnityEngine.Material fixedMaterial; // 0x58
		public bool use2ndFixedMaterial; // 0x60
		public UnityEngine.Material fixedMaterial2nd; // 0x68
		public bool followSelf; // 0x70
		private bool activated; // 0x71
		private float interval; // 0x74
		private float time; // 0x78
		private float[] imageItems; // 0x80
		private int beginPointer; // 0x88
		private int endPointer; // 0x8C
		private int meshNumber; // 0x90
		private Mesh[] attachedMeshesSimple; // 0x98
		private Mesh[,] attachedMeshes; // 0xA0
		private UnityEngine.Material[][] meshMaterials; // 0xA8
		private Matrix4x4[,] meshMaxtrix; // 0xB0
		private Transform[] meshTransform; // 0xB8
		private Vector3[] meshScale; // 0xC0
		private bool meshCleared; // 0xC8
		private MaterialPropertyBlock matPropertyBlock; // 0xD0
		private Vector3 lastTargetPos; // 0xD8
		private MeshFilter[] meshFilters; // 0xE8
		private SkinnedMeshRenderer[] skinnedMeshRenderers; // 0xF0
		private bool init; // 0xF8
		private Dictionary<Transform, Transform> _boneDict; // 0x100
	
		// Properties
		public float ImageLifeTime { /* [XID] */ /* 0x000000018960CE60-0x000000018960CE80 */ get => default; /* [XID] */ /* 0x0000000189614490-0x00000001896144B0 */ set {} } // 0x000000018469BBD0-0x000000018469BC90 0x000000018469BC90-0x000000018469BD40
	
		// Nested types
		public enum AfterImageFollowMode // TypeDefIndex: 19838
		{
			FixedMesh = 0,
			SampleClip = 1,
			TransformAll = 2
		}
	
		[Serializable]
		public struct MaterialProperty // TypeDefIndex: 19839
		{
			// Fields
			public string name; // 0x00
			[NonSerialized]
			[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
			public int nameID; // 0x08
			public AnimationCurve curve; // 0x10
		}
	
		// Constructors
		public MonoEffectAfterImage() {} // 0x000000018469BB20-0x000000018469BBD0
	
		// Methods
		// [XID] // 0x000000018961BE70-0x000000018961BE90
		public void GeneralTransDict() {} // 0x000000018469A460-0x000000018469A5E0
		// [XID] // 0x0000000189623420-0x0000000189623440
		private void AddBoneDict(Transform afterImageTrans, Transform targetTrans) {} // 0x0000000184699FE0-0x000000018469A270
		// [XID] // 0x000000018962AC40-0x000000018962AC60
		private void OnDestroy() {} // 0x000000018469BA50-0x000000018469BB20
		// [XID] // 0x0000000189632340-0x0000000189632360
		public void InitAfterImage() {} // 0x000000018469A5E0-0x000000018469AD50
		// [XID] // 0x0000000189639E30-0x0000000189639E50
		private void Awake() {} // 0x0000000184699050-0x0000000184699110
		// [XID] // 0x0000000189641300-0x0000000189641320
		private void LateUpdate() {} // 0x000000018469B8F0-0x000000018469BA50
		// [XID] // 0x0000000189648C80-0x0000000189648CA0
		private void ClearMesh() {} // 0x000000018469A310-0x000000018469A460
		// [XID] // 0x00000001896502A0-0x00000001896502C0
		private void InUpdate() {} // 0x0000000184699240-0x0000000184699FE0
		// [XID] // 0x0000000189657BF0-0x0000000189657C10
		private void DrawImage(int index) {} // 0x000000018469AD50-0x000000018469B8F0
		// [XID] // 0x000000018965F300-0x000000018965F320
		private UnityEngine.Material GetFixedMaterial() => default; // 0x0000000184699110-0x0000000184699240
		// [XID] // 0x0000000189666BB0-0x0000000189666BD0
		public void ActivateAfterImage(bool clearImages = false /* Metadata: 0x00AFCF19 */) {} // 0x0000000184698F20-0x0000000184699050
		// [XID] // 0x000000018966E1D0-0x000000018966E1F0
		public void DeactivateAfterImage() {} // 0x000000018469A270-0x000000018469A310
	}
}
