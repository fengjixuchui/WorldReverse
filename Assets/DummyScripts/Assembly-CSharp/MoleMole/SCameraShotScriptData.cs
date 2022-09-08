/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001899CE6B0-0x00000001899CE700
	public class SCameraShotScriptData : ScriptableObject // TypeDefIndex: 19581
	{
		// Fields
		// [Header] // 0x00000001899D7490-0x00000001899D74D0
		[SerializeField] // 0x00000001899D7490-0x00000001899D74D0
		private float _duration; // 0x18
		// [Header] // 0x00000001899E3510-0x00000001899E3550
		[SerializeField] // 0x00000001899E3510-0x00000001899E3550
		private int _priority; // 0x1C
		// [Header] // 0x00000001899EF280-0x00000001899EF2D0
		[SerializeField] // 0x00000001899EF280-0x00000001899EF2D0
		private bool _isPersistent; // 0x20
		// [Header] // 0x00000001899FB5E0-0x00000001899FB630
		[SerializeField] // 0x00000001899FB5E0-0x00000001899FB630
		private TransType _parentType; // 0x24
		// [Header] // 0x0000000189A070A0-0x0000000189A070F0
		[SerializeField] // 0x0000000189A070A0-0x0000000189A070F0
		private string _parentTransName; // 0x28
		// [Header] // 0x0000000189A12F10-0x0000000189A12F60
		[SerializeField] // 0x0000000189A12F10-0x0000000189A12F60
		public bool _parentOnlyPosRot; // 0x30
		// [Header] // 0x0000000189A1E8E0-0x0000000189A1E930
		[SerializeField] // 0x0000000189A1E8E0-0x0000000189A1E930
		public bool _followParentPos; // 0x31
		// [Header] // 0x0000000189A2A5D0-0x0000000189A2A620
		[SerializeField] // 0x0000000189A2A5D0-0x0000000189A2A620
		private TransType _lookAtType; // 0x34
		// [Header] // 0x0000000189A366B0-0x0000000189A366F0
		[SerializeField] // 0x0000000189A366B0-0x0000000189A366F0
		private string _lookAtTransName; // 0x38
		// [Header] // 0x0000000189A42450-0x0000000189A42490
		[SerializeField] // 0x0000000189A42450-0x0000000189A42490
		private TransType _bodyType; // 0x40
		// [Header] // 0x0000000189A4E450-0x0000000189A4E4A0
		[SerializeField] // 0x0000000189A4E450-0x0000000189A4E4A0
		private string _bodyTransName; // 0x48
		// [Header] // 0x0000000189A5A380-0x0000000189A5A3D0
		[SerializeField] // 0x0000000189A5A380-0x0000000189A5A3D0
		private bool _bodyOffsetTowardsCameraWhenStart; // 0x50
		// [Header] // 0x0000000189A66550-0x0000000189A665A0
		[SerializeField] // 0x0000000189A66550-0x0000000189A665A0
		private bool _bodyOffsetTowardsCameraWhenTick; // 0x51
		// [Header] // 0x0000000189A72720-0x0000000189A72770
		[SerializeField] // 0x0000000189A72720-0x0000000189A72770
		private bool _bodyOffsetTowardsAvatarWhenStart; // 0x52
		// [Header] // 0x0000000189A7E6C0-0x0000000189A7E710
		[SerializeField] // 0x0000000189A7E6C0-0x0000000189A7E710
		private bool _bodyOffsetTowardsAvatarWhenTick; // 0x53
		// [Header] // 0x0000000189A8A880-0x0000000189A8A8D0
		[SerializeField] // 0x0000000189A8A880-0x0000000189A8A8D0
		private bool _isReplacePositionByCurrCamera; // 0x54
		// [Header] // 0x0000000189A966A0-0x0000000189A966E0
		[SerializeField] // 0x0000000189A966A0-0x0000000189A966E0
		private bool _isReplaceForwardByCurrCamera; // 0x55
		// [Header] // 0x0000000189AA24B0-0x0000000189AA2500
		[SerializeField] // 0x0000000189AA24B0-0x0000000189AA2500
		private bool _needControlRotationX; // 0x56
		// [Header] // 0x0000000189AAE550-0x0000000189AAE5A0
		[SerializeField] // 0x0000000189AAE550-0x0000000189AAE5A0
		private bool _needControlRotationY; // 0x57
		// [Header] // 0x0000000189ABAA00-0x0000000189ABAA70
		// [Range] // 0x0000000189ABAA00-0x0000000189ABAA70
		[SerializeField] // 0x0000000189ABAA00-0x0000000189ABAA70
		private float _rotationSpd; // 0x58
		// [Header] // 0x0000000189AC9900-0x0000000189AC9940
		[SerializeField] // 0x0000000189AC9900-0x0000000189AC9940
		private bool _shieldMotionBlur; // 0x5C
		// [Header] // 0x0000000189AD6000-0x0000000189AD6040
		[SerializeField] // 0x0000000189AD6000-0x0000000189AD6040
		private UnityEngine.Object _cinePrefab; // 0x60
		// [Header] // 0x0000000189AE1EF0-0x0000000189AE1F40
		[SerializeField] // 0x0000000189AE1EF0-0x0000000189AE1F40
		private CameraStateBlenderConfig.BlenderConfigParam _blendParam; // 0x68
		private CameraStateBlenderConfig _blendConfig; // 0x70
		// [Header] // 0x0000000189AEE3A0-0x0000000189AEE3E0
		[SerializeField] // 0x0000000189AEE3A0-0x0000000189AEE3E0
		private CameraStateBlenderConfig.BlenderConfigParam _exitParam; // 0x78
		private CameraStateBlenderConfig _exitConfig; // 0x80
	
		// Properties
		public float duration { /* [XID] */ /* 0x0000000189AFA3E0-0x0000000189AFA400 */ get => default; } // 0x0000000184FE9DA0-0x0000000184FE9E50 
		public bool durationByEvent { /* [XID] */ /* 0x0000000189B01940-0x0000000189B01960 */ get => default; } // 0x0000000184FE9CF0-0x0000000184FE9DA0 
		public int priority { /* [XID] */ /* 0x0000000189ADCEC0-0x0000000189ADCEE0 */ get => default; } // 0x0000000184FEA5F0-0x0000000184FEA690 
		public bool isPersistent { /* [XID] */ /* 0x0000000189AF3840-0x0000000189AF3860 */ get => default; } // 0x0000000184FE9FB0-0x0000000184FEA050 
		public TransType parentType { /* [XID] */ /* 0x0000000189B17A00-0x0000000189B17A20 */ get => default; } // 0x0000000184FEA550-0x0000000184FEA5F0 
		public string parentTransName { /* [XID] */ /* 0x000000018981C700-0x000000018981C720 */ get => default; } // 0x0000000184FEA4B0-0x0000000184FEA550 
		public bool parentOnlyPosRot { /* [XID] */ /* 0x0000000189B26BE0-0x0000000189B26C00 */ get => default; } // 0x0000000184FEA410-0x0000000184FEA4B0 
		public bool followParentPos { /* [XID] */ /* 0x000000018962D050-0x000000018962D070 */ get => default; } // 0x0000000184FE9F10-0x0000000184FE9FB0 
		public TransType lookAtType { /* [XID] */ /* 0x0000000189678450-0x0000000189678470 */ get => default; } // 0x0000000184FEA230-0x0000000184FEA2D0 
		public string lookAtTransName { /* [XID] */ /* 0x000000018967FD30-0x000000018967FD50 */ get => default; } // 0x0000000184FEA190-0x0000000184FEA230 
		public TransType bodyType { /* [XID] */ /* 0x00000001896E7660-0x00000001896E7680 */ get => default; } // 0x0000000184FE9BB0-0x0000000184FE9C50 
		public string bodyTransName { /* [XID] */ /* 0x000000018975ED30-0x000000018975ED50 */ get => default; } // 0x0000000184FE9B10-0x0000000184FE9BB0 
		public bool bodyOffsetTowardsCameraWhenStart { /* [XID] */ /* 0x0000000189B535C0-0x0000000189B535E0 */ get => default; } // 0x0000000184FE99D0-0x0000000184FE9A70 
		public bool bodyOffsetTowardsCameraWhenTick { /* [XID] */ /* 0x0000000189B5ADF0-0x0000000189B5AE10 */ get => default; } // 0x0000000184FE9A70-0x0000000184FE9B10 
		public bool bodyOffsetTowardsAvatarWhenStart { /* [XID] */ /* 0x00000001897F7000-0x00000001897F7020 */ get => default; } // 0x0000000184FE9890-0x0000000184FE9930 
		public bool bodyOffsetTowardsAvatarWhenTick { /* [XID] */ /* 0x0000000189B69F50-0x0000000189B69F70 */ get => default; } // 0x0000000184FE9930-0x0000000184FE99D0 
		public bool isReplacePositionByCurrCamera { /* [XID] */ /* 0x0000000189B715B0-0x0000000189B715D0 */ get => default; } // 0x0000000184FEA0F0-0x0000000184FEA190 
		public bool isReplaceForwardByCurrCamera { /* [XID] */ /* 0x0000000189B78AC0-0x0000000189B78AE0 */ get => default; } // 0x0000000184FEA050-0x0000000184FEA0F0 
		public bool needControlRotationX { /* [XID] */ /* 0x0000000189652780-0x00000001896527A0 */ get => default; } // 0x0000000184FEA2D0-0x0000000184FEA370 
		public bool needControlRotationY { /* [XID] */ /* 0x0000000189B87A40-0x0000000189B87A60 */ get => default; } // 0x0000000184FEA370-0x0000000184FEA410 
		public float rotationSpd { /* [XID] */ /* 0x0000000189B8EBD0-0x0000000189B8EBF0 */ get => default; } // 0x0000000184FEA690-0x0000000184FEA740 
		public bool shieldMotionBlur { /* [XID] */ /* 0x0000000189B960A0-0x0000000189B960C0 */ get => default; } // 0x0000000184FEA740-0x0000000184FEA7E0 
		public UnityEngine.Object cinePrefab { /* [XID] */ /* 0x0000000189B89F20-0x0000000189B89F40 */ get => default; } // 0x0000000184FE9C50-0x0000000184FE9CF0 
		public CameraStateBlenderConfig blendConfig { /* [XID] */ /* 0x0000000189BA5090-0x0000000189BA50B0 */ get => default; } // 0x0000000184FE97D0-0x0000000184FE9890 
		public CameraStateBlenderConfig exitConfig { /* [XID] */ /* 0x0000000189634C20-0x0000000189634C40 */ get => default; } // 0x0000000184FE9E50-0x0000000184FE9F10 
	
		// Nested types
		public enum TransType // TypeDefIndex: 19582
		{
			INVALID = -1,
			LOCAL_AVATAR = 0,
			TARGET = 1,
			GROUP_TARGET = 2,
			EXTRA_DUMMY = 3,
			FROM_TARGET = 4
		}
	
		// Constructors
		public SCameraShotScriptData() {} // 0x0000000184FE9700-0x0000000184FE97D0
	
		// Methods
		// [XID] // 0x0000000189BB39F0-0x0000000189BB3A10
		public void UpdateExitPoleType(CameraStateBlenderConfig.PoleType poleType) {} // 0x0000000184FE9640-0x0000000184FE9700
	}
}
