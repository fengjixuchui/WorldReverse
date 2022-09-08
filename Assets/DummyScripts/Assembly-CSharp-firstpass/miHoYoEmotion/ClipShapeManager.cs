/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	// [RequireComponent] // 0x0000000189B8FAC0-0x0000000189B8FB10
	public class ClipShapeManager : ElementManager // TypeDefIndex: 8474
	{
		// Fields
		public UnityEngine.Material faceMaterial; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<CurveBinding> currModelBindingList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ClipShapeRuntime[] _phonemeShapeRuntimes; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ClipShapeRuntime[] _emotionShapeRuntimes; // 0x68
		protected ClipShapeData _clipShapeData; // 0x70
		protected ClipShapeData _specialClipShapeData; // 0x78
		private bool _runtimeIndexUpdated; // 0x80
	
		// Properties
		public ClipShapeRuntime[] PhonemeShapeRuntimes { /* [XID] */ /* 0x0000000189A8CA90-0x0000000189A8CAB0 */ get => default; } // 0x0000000187325B80-0x0000000187325C20 
		public ClipShapeRuntime[] EmotionShapeRuntimes { /* [XID] */ /* 0x000000018990A880-0x000000018990A8A0 */ get => default; } // 0x0000000187325AE0-0x0000000187325B80 
		public ClipShapeData SpecialClipShapeData { /* [XID] */ /* 0x0000000189BC7F30-0x0000000189BC7F50 */ get => default; } // 0x0000000187325C20-0x0000000187325CC0 
	
		// Nested types
		[Serializable]
		public class CurveBinding // TypeDefIndex: 8475
		{
			// Fields
			public static readonly Dictionary<string, int> PROP_NAME_2_PROP_ID; // 0x00
			public static readonly Dictionary<int, string> PROP_ID_2_PROP_NAME; // 0x08
			public BindingType bindingType; // 0x10
			public Transform bindingTrans; // 0x18
			public Renderer bindingRender; // 0x20
			public EyeKey bindingEyeKey; // 0x28
			public int propertyID; // 0x30
			public float originValue; // 0x34
			private static Vector3 _tempEuler; // 0x10
			private static Vector3 _tempScale; // 0x1C
			private MaterialPropertyBlock _prop; // 0x38
			private int _propNameID; // 0x40
	
			// Nested types
			public enum BindingType // TypeDefIndex: 8476
			{
				INVALID = -1,
				BLEND_SHAPE = 0,
				TRANS_POS_X = 1,
				TRANS_POS_Y = 2,
				TRANS_POS_Z = 3,
				TRANS_EULER_X = 4,
				TRANS_EULER_Y = 5,
				TRANS_EULER_Z = 6,
				TRANS_SCALE_X = 7,
				TRANS_SCALE_Y = 8,
				TRANS_SCALE_Z = 9,
				MAT_FLOAT = 10,
				EYE_LEFT_POS_X = 11,
				EYE_LEFT_POS_Y = 12,
				EYE_LEFT_POS_Z = 13,
				EYE_RIGHT_POS_X = 14,
				EYE_RIGHT_POS_Y = 15,
				EYE_RIGHT_POS_Z = 16,
				EYE_LEFT_ROT_X = 17,
				EYE_LEFT_ROT_Y = 18,
				EYE_LEFT_ROT_Z = 19,
				EYE_RIGHT_ROT_X = 20,
				EYE_RIGHT_ROT_Y = 21,
				EYE_RIGHT_ROT_Z = 22,
				EYE_LEFT_SCALE_X = 23,
				EYE_LEFT_SCALE_Y = 24,
				EYE_LEFT_SCALE_Z = 25,
				EYE_RIGHT_SCALE_X = 26,
				EYE_RIGHT_SCALE_Y = 27,
				EYE_RIGHT_SCALE_Z = 28,
				EYE_BALL_LEFT_POS_X = 29,
				EYE_BALL_LEFT_POS_Y = 30,
				EYE_BALL_LEFT_POS_Z = 31,
				EYE_BALL_RIGHT_POS_X = 32,
				EYE_BALL_RIGHT_POS_Y = 33,
				EYE_BALL_RIGHT_POS_Z = 34,
				EYE_BALL_LEFT_ROT_X = 35,
				EYE_BALL_LEFT_ROT_Y = 36,
				EYE_BALL_LEFT_ROT_Z = 37,
				EYE_BALL_RIGHT_ROT_X = 38,
				EYE_BALL_RIGHT_ROT_Y = 39,
				EYE_BALL_RIGHT_ROT_Z = 40,
				EYE_BALL_LEFT_SCALE_X = 41,
				EYE_BALL_LEFT_SCALE_Y = 42,
				EYE_BALL_LEFT_SCALE_Z = 43,
				EYE_BALL_RIGHT_SCALE_X = 44,
				EYE_BALL_RIGHT_SCALE_Y = 45,
				EYE_BALL_RIGHT_SCALE_Z = 46,
				TEETH_UP_ROT_X = 47,
				TEETH_UP_ROT_Y = 48,
				TEETH_UP_ROT_Z = 49,
				TEETH_DOWN_ROT_X = 50,
				TEETH_DOWN_ROT_Y = 51,
				TEETH_DOWN_ROT_Z = 52,
				TEETH_UP_SCALE_X = 53,
				TEETH_UP_SCALE_Y = 54,
				TEETH_UP_SCALE_Z = 55,
				TEETH_DOWN_SCALE_X = 56,
				TEETH_DOWN_SCALE_Y = 57,
				TEETH_DOWN_SCALE_Z = 58,
				TEETH_DOWN_POS_X = 59,
				TEETH_DOWN_POS_Y = 60,
				TEETH_DOWN_POS_Z = 61,
				GO_ACTIVE = 62
			}
	
			// Constructors
			public CurveBinding() {} // 0x00000001873290B0-0x0000000187329120
			static CurveBinding() {} // 0x0000000187328F30-0x00000001873290B0
	
			// Methods
			// [XID] // 0x0000000189609600-0x0000000189609620
			public bool Equals(CurveBinding binding) => default; // 0x0000000187327F60-0x0000000187328110
			// [XID] // 0x00000001896A67A0-0x00000001896A67C0
			public void Apply(float value) {} // 0x0000000187326EB0-0x0000000187327F60
			// [XID] // 0x0000000189BC6BB0-0x0000000189BC6BD0
			public float GetValue() => default; // 0x00000001873281C0-0x0000000187328F30
			// [XID] // 0x000000018961FD90-0x000000018961FDB0
			public float GetOriginValue() => default; // 0x0000000187328110-0x00000001873281C0
		}
	
		[Serializable]
		public class CurveBindingGrp // TypeDefIndex: 8477
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public List<int> curveBindings; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public ClipShapeManager clipShapeManager; // 0x18
			public Dictionary<int, int> IndexRes2IndexRuntimeDic; // 0x20
	
			// Constructors
			public CurveBindingGrp() {} // 0x0000000187326E00-0x0000000187326EB0
	
			// Methods
			// [XID] // 0x0000000189636700-0x0000000189636720
			public CurveBinding GetCurveBinding(int indexOfIndex) => default; // 0x0000000187326830-0x0000000187326980
			// [XID] // 0x0000000189636E40-0x0000000189636E60
			public void PutCurveBinding(CurveBinding binding) {} // 0x0000000187326A70-0x0000000187326CA0
			// [XID] // 0x00000001896453B0-0x00000001896453D0
			public int GetIndex(int indexRes) => default; // 0x0000000187326980-0x0000000187326A70
			// [XID] // 0x000000018964CDF0-0x000000018964CE10
			public void UpdateRuntimeIndex(ClipShapeCurveGrp shapeCurveGrp) {} // 0x0000000187326CA0-0x0000000187326E00
		}
	
		[Serializable]
		public class ClipShapeRuntime : ElementManager.BaseShapeRuntime // TypeDefIndex: 8479
		{
			// Fields
			public CurveBindingGrp mainBindingGrp; // 0x18
			public CurveBindingGrp postBindingGrp; // 0x20
			public CurveBindingGrp blinkBindingGrp; // 0x28
	
			// Constructors
			public ClipShapeRuntime() {} // 0x0000000187325DF0-0x0000000187325E90
	
			// Methods
			// [XID] // 0x000000018970A050-0x000000018970A070
			public void UpdateRuntimeIndex(ClipShapeElement shapeElement) {} // 0x0000000187325CC0-0x0000000187325DF0
		}
	
		// Constructors
		public ClipShapeManager() {} // 0x0000000187325A30-0x0000000187325AE0
	
		// Methods
		// [XID] // 0x0000000189A93E70-0x0000000189A93E90
		public void ResetBlendShape() {} // 0x0000000187324D80-0x0000000187324F30
		// [XID] // 0x0000000189815110-0x0000000189815130
		protected override void Start() {} // 0x0000000187324F30-0x0000000187324FF0
		// [XID] // 0x00000001896C5BD0-0x00000001896C5BF0
		protected override void OnEnable() {} // 0x0000000187324CE0-0x0000000187324D80
		// [XID] // 0x00000001896D4770-0x00000001896D4790
		public override void InitEmoAnim() {} // 0x0000000187324BF0-0x0000000187324CE0
		// [XID] // 0x0000000189B01130-0x0000000189B01150
		public override void UpdateShapeData() {} // 0x0000000187325620-0x0000000187325880
		// [XID] // 0x000000018965AB70-0x000000018965AB90
		protected override void UpdateShapeRuntime() {} // 0x0000000187325880-0x0000000187325A30
		// [XID] // 0x00000001895FA440-0x00000001895FA460
		private void UpdateRuntimeIndex() {} // 0x00000001873251D0-0x0000000187325620
		// [XID] // 0x0000000189601DF0-0x0000000189601E10
		public CurveBinding GetCurveBindingByBakedClipBinding(SequenceClipBakeData.ClipBinding clipBinding, ClipShapeCurveCell curveCell) => default; // 0x0000000187324990-0x0000000187324BF0
	}
}
