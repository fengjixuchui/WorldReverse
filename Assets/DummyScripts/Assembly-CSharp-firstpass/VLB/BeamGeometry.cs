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

namespace VLB
{
	// [AddComponentMenu] // 0x0000000189A551C0-0x0000000189A55230
	[ExecuteInEditMode] // 0x0000000189A551C0-0x0000000189A55230
	// [HelpURL] // 0x0000000189A551C0-0x0000000189A55230
	public class BeamGeometry : MonoBehaviour // TypeDefIndex: 10194
	{
		// Fields
		private const int kNbSegments = 0; // Metadata: 0x00AE709F
		private VolumetricLightBeam m_Master; // 0x18
		private Matrix4x4 m_ColorGradientMatrix; // 0x20
	
		// Properties
		public MeshRenderer meshRenderer { /* [XID] */ /* 0x0000000189A8E750-0x0000000189A8E790 */ get; /* [XID] */ /* 0x0000000189A99180-0x0000000189A991C0 */ private set; } // 0x0000000186E938D0-0x0000000186E93930 0x0000000186E93D20-0x0000000186E93D80
		public MeshFilter meshFilter { /* [XID] */ /* 0x0000000189AA31E0-0x0000000189AA3220 */ get; /* [XID] */ /* 0x0000000189AAD880-0x0000000189AAD8C0 */ private set; } // 0x0000000186E93870-0x0000000186E938D0 0x0000000186E93CC0-0x0000000186E93D20
		public UnityEngine.Material material { /* [XID] */ /* 0x0000000189AB80E0-0x0000000189AB8120 */ get; /* [XID] */ /* 0x0000000189AC2E50-0x0000000189AC2E90 */ private set; } // 0x0000000186E93810-0x0000000186E93870 0x0000000186E93C60-0x0000000186E93CC0
		public Mesh coneMesh { /* [XID] */ /* 0x0000000189ACD7A0-0x0000000189ACD7E0 */ get; /* [XID] */ /* 0x0000000189AD8330-0x0000000189AD8370 */ private set; } // 0x0000000186E937B0-0x0000000186E93810 0x0000000186E93C00-0x0000000186E93C60
		public bool visible { /* [XID] */ /* 0x0000000189AE2A40-0x0000000189AE2A60 */ get => default; /* [XID] */ /* 0x0000000189AEA520-0x0000000189AEA540 */ set {} } // 0x0000000186E93B10-0x0000000186E93C00 0x0000000186E93F80-0x0000000186E94080
		public int sortingLayerID { /* [XID] */ /* 0x0000000189AF1F30-0x0000000189AF1F50 */ get => default; /* [XID] */ /* 0x0000000189AF9940-0x0000000189AF9960 */ set {} } // 0x0000000186E93930-0x0000000186E93A20 0x0000000186E93D80-0x0000000186E93E80
		public int sortingOrder { /* [XID] */ /* 0x00000001897EA4E0-0x00000001897EA500 */ get => default; /* [XID] */ /* 0x0000000189682AE0-0x0000000189682B00 */ set {} } // 0x0000000186E93A20-0x0000000186E93B10 0x0000000186E93E80-0x0000000186E93F80
	
		// Constructors
		public BeamGeometry() {} // 0x0000000186E93740-0x0000000186E937B0
	
		// Methods
		// [XID] // 0x000000018968A6A0-0x000000018968A6C0
		private void Start() {} // 0x0000000186E92650-0x0000000186E92760
		// [XID] // 0x0000000189B16DE0-0x0000000189B16E00
		private void OnDestroy() {} // 0x0000000186E91A20-0x0000000186E91BE0
		// [XID] // 0x00000001896AF580-0x00000001896AF5A0
		public void Initialize(VolumetricLightBeam master, Shader shader) {} // 0x0000000186E914B0-0x0000000186E91A20
		// [XID] // 0x0000000189B25FC0-0x0000000189B25FE0
		public void RegenerateMesh() {} // 0x0000000186E91F70-0x0000000186E92370
		// [XID] // 0x0000000189722E50-0x0000000189722E70
		private void ComputeBounds() {} // 0x0000000186E91210-0x0000000186E914B0
		// [XID] // 0x0000000189B347B0-0x0000000189B347D0
		public void UpdateMaterialAndBounds() {} // 0x0000000186E92760-0x0000000186E93740
		// [XID] // 0x0000000189B3BFD0-0x0000000189B3BFF0
		public void SetClippingPlane(Plane planeWS) {} // 0x0000000186E92460-0x0000000186E92650
		// [XID] // 0x0000000189B43C50-0x0000000189B43C70
		public void SetClippingPlaneOff() {} // 0x0000000186E92370-0x0000000186E92460
		// [XID] // 0x000000018975B870-0x000000018975B890
		private void OnWillRenderObject() {} // 0x0000000186E91BE0-0x0000000186E91F70
	}
}
