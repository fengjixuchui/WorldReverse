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
	public class ClipEmoTrack : EmoTrack // TypeDefIndex: 8466
	{
		// Fields
		protected List<AnimationCurve> _animCurves; // 0x50
		protected List<ClipShapeManager.CurveBinding> _curveBindings; // 0x58
		protected List<float> _curveValues; // 0x60
		protected Dictionary<int, int> _indexRes2IndecCurveDic; // 0x68
		private ClipShapeManager _clipManager; // 0x70
	
		// Nested types
		public struct ClipCell // TypeDefIndex: 8467
		{
			// Fields
			public ClipShapeElement element; // 0x00
			public ClipShapeManager.ClipShapeRuntime shapeRuntime; // 0x08
	
			// Properties
			public bool IsMainClipValid { /* [XID] */ /* 0x00000001895F1D30-0x00000001895F1D50 */ get => default; } // 0x000000018731DDC0-0x000000018731DEB0 
			public float MainClipDuration { /* [XID] */ /* 0x00000001899E5E80-0x00000001899E5EA0 */ get => default; } // 0x000000018731E320-0x000000018731E400 
			public bool IsMainCurveValid { /* [XID] */ /* 0x00000001899ECFE0-0x00000001899ED000 */ get => default; } // 0x000000018731DEB0-0x000000018731DFC0 
			public int MainCurveCnt { /* [XID] */ /* 0x00000001899F4D00-0x00000001899F4D20 */ get => default; } // 0x000000018731E400-0x000000018731E4F0 
			public bool IsPostClipValid { /* [XID] */ /* 0x0000000189A0AD50-0x0000000189A0AD70 */ get => default; } // 0x000000018731DFC0-0x000000018731E0B0 
			public float PostClipDuration { /* [XID] */ /* 0x000000018993B350-0x000000018993B370 */ get => default; } // 0x000000018731E4F0-0x000000018731E5D0 
			public bool IsPostCurveValid { /* [XID] */ /* 0x0000000189A19A00-0x0000000189A19A20 */ get => default; } // 0x000000018731E0B0-0x000000018731E170 
			public int PostCurveCnt { /* [XID] */ /* 0x0000000189A21000-0x0000000189A21020 */ get => default; } // 0x000000018731E5D0-0x000000018731E600 
			public bool IsBlinkClipValid { /* [XID] */ /* 0x0000000189A37520-0x0000000189A37540 */ get => default; } // 0x000000018731DC30-0x000000018731DD00 
			public bool IsBlinkClipBindingValid { /* [XID] */ /* 0x0000000189A3EC70-0x0000000189A3EC90 */ get => default; } // 0x000000018731DB40-0x000000018731DC30 
			public float BlinkClipDuration { /* [XID] */ /* 0x00000001895F51B0-0x00000001895F51D0 */ get => default; } // 0x000000018731D940-0x000000018731DA20 
			public bool IsBlinkCurveValid { /* [XID] */ /* 0x0000000189A4DA50-0x0000000189A4DA70 */ get => default; } // 0x000000018731DD00-0x000000018731DDC0 
			public int BlinkCurveCnt { /* [XID] */ /* 0x0000000189A553E0-0x0000000189A55400 */ get => default; } // 0x000000018731DA20-0x000000018731DB40 
			public bool IsValid { /* [XID] */ /* 0x0000000189763360-0x0000000189763380 */ get => default; } // 0x000000018731E170-0x000000018731E320 
	
			// Methods
			// [XID] // 0x00000001898D2F30-0x00000001898D2F50
			public ClipShapeCurveCell GetMainCurve(int index) => default; // 0x000000018731D5F0-0x000000018731D720
			// [XID] // 0x0000000189A03830-0x0000000189A03850
			public ClipShapeManager.CurveBinding GetMainBinding(int index) => default; // 0x000000018731D4B0-0x000000018731D5F0
			// [XID] // 0x0000000189A283B0-0x0000000189A283D0
			public ClipShapeCurveCell GetPostCurve(int index) => default; // 0x000000018731D860-0x000000018731D940
			// [XID] // 0x0000000189A2FC30-0x0000000189A2FC50
			public ClipShapeManager.CurveBinding GetPostBinding(int index) => default; // 0x000000018731D720-0x000000018731D860
			// [XID] // 0x0000000189A5CB80-0x0000000189A5CBA0
			public ClipShapeCurveCell GetBlinkCurve(int index) => default; // 0x000000018731D200-0x000000018731D4B0
			// [XID] // 0x0000000189A64470-0x0000000189A64490
			public ClipShapeManager.CurveBinding GetBlinkBinding(int index) => default; // 0x000000018731D0C0-0x000000018731D200
		}
	
		// Constructors
		public ClipEmoTrack() {} // 0x0000000187323B60-0x0000000187323C60
	
		// Methods
		// [XID] // 0x00000001899229D0-0x00000001899229F0
		public override void Init(ElementManager manager) {} // 0x0000000187321690-0x0000000187321790
		// [XID] // 0x000000018992A240-0x000000018992A260
		private int GetIndex(int indexRes) => default; // 0x00000001873215A0-0x0000000187321690
		// [XID] // 0x0000000189690AE0-0x0000000189690B00
		private int AddIndex(int indexRes, int indexCurve) => default; // 0x00000001873204A0-0x0000000187320580
		// [XID] // 0x00000001896983A0-0x00000001896983C0
		protected ClipCell GetCellByShape(BaseShape shape) => default; // 0x0000000187321310-0x0000000187321460
		// [XID] // 0x0000000189940710-0x0000000189940730
		protected ClipCell GetCell(string name) => default; // 0x0000000187321460-0x00000001873215A0
		// [XID] // 0x000000018975B8F0-0x000000018975B910
		private bool IsPost(ref ClipCell fromCell, ref ClipCell toCell) => default; // 0x0000000187321840-0x0000000187321A30
		// [XID] // 0x000000018976AAB0-0x000000018976AAD0
		private bool IsToFinal(ref ClipCell fromCell, ref ClipCell toCell) => default; // 0x0000000187321AF0-0x0000000187321CF0
		// [XID] // 0x0000000189956A00-0x0000000189956A20
		public override void PlayDefault(BaseShape shape, string postToPlay = "" /* Metadata: 0x00ADF7EC */) {} // 0x0000000187322850-0x0000000187322B10
		// [XID] // 0x000000018995E4F0-0x000000018995E510
		public override void EnableShape(BaseShape shape, float startTime = 0f /* Metadata: 0x00ADF7F0 */) {} // 0x00000001873210A0-0x0000000187321310
		// [XID] // 0x0000000189644510-0x0000000189644530
		protected void BuildPreCurve(ref ClipCell preCell, ref ClipCell curCell, out float postTime, float defaultPostTime = 0.12f /* Metadata: 0x00ADF7F4 */) {
			postTime = default;
		} // 0x0000000187320750-0x0000000187320CE0
		// [XID] // 0x000000018996D390-0x000000018996D3B0
		protected void MergeCurCurve(ref ClipCell preCell, ref ClipCell curCell, float postTime = 0.12f /* Metadata: 0x00ADF7F8 */) {} // 0x0000000187321CF0-0x0000000187321E50
		// [XID] // 0x0000000189BD5B40-0x0000000189BD5B60
		protected void MergeCurve(ClipShapeCurveCell curveCell, ClipShapeManager.CurveBinding binding, float postTime = 0.12f /* Metadata: 0x00ADF7FC */, bool isToFinal = false /* Metadata: 0x00ADF800 */, bool clearPrecurve = true /* Metadata: 0x00ADF801 */) {} // 0x0000000187321E50-0x00000001873223E0
		// [XID] // 0x000000018997C190-0x000000018997C1B0
		public override void ClearShape() {} // 0x0000000187320F50-0x00000001873210A0
		// [XID] // 0x000000018972BC40-0x000000018972BC60
		protected virtual void ClearInternal() {} // 0x0000000187320DB0-0x0000000187320E90
		// [XID] // 0x000000018998B860-0x000000018998B880
		protected virtual void ClearCurve() {} // 0x0000000187320CE0-0x0000000187320DB0
		// [XID] // 0x0000000189993330-0x0000000189993350
		public override void ClearShapeOnly() {} // 0x0000000187320E90-0x0000000187320F50
		// [XID] // 0x0000000189996AA0-0x0000000189996AC0
		public override void PlayBakedSequence(SequenceBakeData.BakeData bakeData) {} // 0x00000001873223E0-0x0000000187322850
		// [XID] // 0x00000001899A2550-0x00000001899A2570
		protected void SmoothCurvesBeginning(TransitionType transitionType) {} // 0x0000000187322BC0-0x00000001873232E0
		// [XID] // 0x00000001899A9CC0-0x00000001899A9CE0
		public override void StopSequence() {} // 0x00000001873232E0-0x00000001873233A0
		// [XID] // 0x00000001899B17E0-0x00000001899B1800
		protected virtual void PreClearInternal() {} // 0x0000000187322B10-0x0000000187322BC0
		// [XID] // 0x00000001899B8C30-0x00000001899B8C50
		protected virtual bool IsRunning() => default; // 0x0000000187321A30-0x0000000187321AF0
		// [XID] // 0x0000000189750A40-0x0000000189750A60
		public override bool IsPlaying() => default; // 0x0000000187321790-0x0000000187321840
		// [XID] // 0x0000000189757E70-0x0000000189757E90
		protected virtual void UpdateCurveValue() {} // 0x0000000187323830-0x0000000187323A00
		// [XID] // 0x00000001899CF6C0-0x00000001899CF6E0
		public override void Update(float deltaTime) {} // 0x0000000187323A00-0x0000000187323B60
		// [XID] // 0x00000001899D6B70-0x00000001899D6B90
		public override void Apply() {} // 0x0000000187320580-0x0000000187320750
	}
}
