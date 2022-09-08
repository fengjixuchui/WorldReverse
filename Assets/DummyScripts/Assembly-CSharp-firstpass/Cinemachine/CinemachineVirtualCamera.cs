/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001898AA040-0x00000001898AA0C0
	[DisallowMultipleComponent] // 0x00000001898AA040-0x00000001898AA0C0
	// [DocumentationSorting] // 0x00000001898AA040-0x00000001898AA0C0
	[ExecuteInEditMode] // 0x00000001898AA040-0x00000001898AA0C0
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 6791
	{
		// Fields
		[NoSaveDuringPlay] // 0x00000001898BC470-0x00000001898BC4C0
		// [Tooltip] // 0x00000001898BC470-0x00000001898BC4C0
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x00000001898C8160-0x00000001898C81A0
		// [Tooltip] // 0x00000001898C8160-0x00000001898C81A0
		public Transform m_Follow; // 0x80
		// [FormerlySerializedAs] // 0x00000001898D4090-0x00000001898D4100
		[LensSettingsProperty] // 0x00000001898D4090-0x00000001898D4100
		// [Tooltip] // 0x00000001898D4090-0x00000001898D4100
		public LensSettings m_Lens; // 0x88
		public const string PipelineName = "cm"; // Metadata: 0x00ADDE4F
		public static CreatePipelineDelegate CreatePipelineOverride; // 0x00
		public static DestroyPipelineDelegate DestroyPipelineOverride; // 0x08
		private CameraState m_State; // 0xA8
		private CinemachineComponentBase[] m_ComponentPipeline; // 0x178
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		private Transform m_ComponentOwner; // 0x180
	
		// Properties
		public override CameraState State { /* [XID] */ /* 0x00000001899003A0-0x00000001899003C0 */ get => default; } // 0x0000000186CD5B80-0x0000000186CD5DE0 
		public override Transform LookAt { /* [XID] */ /* 0x0000000189907AB0-0x0000000189907AD0 */ get => default; /* [XID] */ /* 0x000000018990F360-0x000000018990F380 */ set {} } // 0x0000000186CD5AD0-0x0000000186CD5B80 0x0000000186CD5EF0-0x0000000186CD5FA0
		public override Transform Follow { /* [XID] */ /* 0x0000000189916C30-0x0000000189916C50 */ get => default; /* [XID] */ /* 0x000000018991E340-0x000000018991E360 */ set {} } // 0x0000000186CD5A20-0x0000000186CD5AD0 0x0000000186CD5E40-0x0000000186CD5EF0
		public bool UserIsDragging { /* [XID] */ /* 0x000000018997F2C0-0x000000018997F300 */ get; set; } // 0x0000000186CD5DE0-0x0000000186CD5E40 0x0000000186CD5FA0-0x0000000186CD6010
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 6792; 0x000000018669A190-0x000000018669A480
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 6793; 0x000000018669AC70-0x000000018669AED0
	
		// Constructors
		public CinemachineVirtualCamera() {} // 0x0000000186CD5880-0x0000000186CD5A20
	
		// Methods
		// [XID] // 0x0000000189925C50-0x0000000189925C70
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186CD4D60-0x0000000186CD52A0
		// [XID] // 0x00000001897A81D0-0x00000001897A81F0
		protected override void OnEnable() {} // 0x0000000186CD4010-0x0000000186CD4210
		// [XID] // 0x0000000189934770-0x0000000189934790
		protected override void OnDestroy() {} // 0x0000000186CD3DE0-0x0000000186CD4010
		// [XID] // 0x00000001897BF960-0x00000001897BF980
		protected override void OnValidate() {} // 0x0000000186CD43F0-0x0000000186CD44A0
		// [XID] // 0x00000001897C7130-0x00000001897C7150
		private void OnTransformChildrenChanged() {} // 0x0000000186CD4350-0x0000000186CD43F0
		// [XID] // 0x000000018994AD90-0x000000018994ADB0
		private void Reset() {} // 0x0000000186CD4A10-0x0000000186CD4AB0
		// [XID] // 0x0000000189B796B0-0x0000000189B796D0
		private void DestroyPipeline() {} // 0x0000000186CD36F0-0x0000000186CD3AC0
		// [XID] // 0x0000000189959D50-0x0000000189959D70
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) => default; // 0x0000000186CD3480-0x0000000186CD36F0
		// [XID] // 0x00000001897737C0-0x00000001897737E0
		public void InvalidateComponentPipeline() {} // 0x0000000186CD3D40-0x0000000186CD3DE0
		// [XID] // 0x00000001897D5D90-0x00000001897D5DB0
		public Transform GetComponentOwner() => default; // 0x0000000186CD3BE0-0x0000000186CD3C90
		// [XID] // 0x0000000189970400-0x0000000189970420
		public CinemachineComponentBase[] GetComponentPipeline() => default; // 0x0000000186CD3C90-0x0000000186CD3D40
		// [XID] // 0x00000001899781E0-0x0000000189978200
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) => default; // 0x0000000186CD3AC0-0x0000000186CD3BE0
		public T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase => default;
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase => default;
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase {}
		// [XID] // 0x0000000189639360-0x0000000189639380
		public void OnPositionDragged(Vector3 delta) {} // 0x0000000186CD4210-0x0000000186CD4350
		// [XID] // 0x0000000189A12380-0x0000000189A123A0
		private void UpdateComponentPipeline() {} // 0x0000000186CD52A0-0x0000000186CD5880
		// [XID] // 0x00000001899A0D90-0x00000001899A0DB0
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) => default; // 0x0000000186CD2ED0-0x0000000186CD3480
		// [XID] // 0x00000001897915F0-0x0000000189791610
		private CinemachineCore.Stage AdvancePipelineStage(ref CameraState state, float deltaTime, CinemachineCore.Stage curStage, int maxStage) => default; // 0x0000000186CD2DA0-0x0000000186CD2ED0
		// [XID] // 0x00000001897648C0-0x00000001897648E0
		private CameraState PullStateFromVirtualCamera(Vector3 worldUp) => default; // 0x0000000186CD44A0-0x0000000186CD4A10
		// [XID] // 0x00000001899B73B0-0x00000001899B73D0
		internal void SetStateRawPosition(Vector3 pos) {} // 0x0000000186CD4AB0-0x0000000186CD4B90
	}
}
