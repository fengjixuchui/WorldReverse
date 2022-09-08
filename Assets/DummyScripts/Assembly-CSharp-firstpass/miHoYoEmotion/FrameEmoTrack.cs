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
	public class FrameEmoTrack : EmoTrack // TypeDefIndex: 8469
	{
		// Fields
		protected FrameCell _tickCell; // 0x50
		private SequenceFrameBakeData.FrameBinding[] _bakedBindings; // 0x60
		private float _frameBakedCnt; // 0x68
		private float _frameBakedLength; // 0x6C
	
		// Properties
		private float frameBakedCnt { /* [XID] */ /* 0x0000000189AA0370-0x0000000189AA0390 */ get => default; } // 0x0000000187258860-0x0000000187258910 
		private float frameBakedLength { /* [XID] */ /* 0x0000000189AA7B20-0x0000000189AA7B40 */ get => default; } // 0x0000000187258910-0x00000001872589C0 
	
		// Nested types
		public struct FrameElementCell // TypeDefIndex: 8470
		{
			// Fields
			public FrameShapeElement element; // 0x00
			public FrameShapeManager.FrameShapeRuntime shapeRuntime; // 0x08
			private int _frameCnt; // 0x10
			private bool _frameChanged; // 0x14
			private float _frameTime; // 0x18
			private float _timeCnt; // 0x1C
			private List<Texture2D> _frames; // 0x20
	
			// Methods
			// [XID] // 0x0000000189B117C0-0x0000000189B117E0
			public void ClearFrame() {} // 0x00000001872568E0-0x0000000187256A20
			// [XID] // 0x0000000189B18A30-0x0000000189B18A50
			public void AddFrame(Texture2D frame) {} // 0x00000001872566F0-0x0000000187256800
			// [XID] // 0x0000000189B200F0-0x0000000189B20110
			public bool Update(float deltaTime) => default; // 0x0000000187256A20-0x0000000187256A50
			// [XID] // 0x000000018989D360-0x000000018989D380
			public void Apply() {} // 0x0000000187256800-0x00000001872568E0
		}
	
		public struct FrameCell // TypeDefIndex: 8471
		{
			// Fields
			private Dictionary<int, int> _indexDic; // 0x00
			private List<FrameElementCell> _elementCells; // 0x08
	
			// Properties
			public List<FrameElementCell> elementCells { /* [XID] */ /* 0x0000000189B3D790-0x0000000189B3D7B0 */ get => default; } // 0x00000001872564F0-0x00000001872565C0 
			public int elementCnt { /* [XID] */ /* 0x0000000189B456A0-0x0000000189B456C0 */ get => default; } // 0x00000001872565C0-0x00000001872566F0 
	
			// Methods
			// [XID] // 0x0000000189B2EA30-0x0000000189B2EA50
			public void AddIndex(FrameShapeElement.TYPE type, int index) {} // 0x0000000187255AC0-0x0000000187255C30
			// [XID] // 0x0000000189B36240-0x0000000189B36260
			public int GetIndex(FrameShapeElement.TYPE type) => default; // 0x0000000187256090-0x0000000187256270
			// [XID] // 0x0000000189B4CC10-0x0000000189B4CC30
			public FrameElementCell GetElementCell(int index) => default; // 0x0000000187255F30-0x0000000187256090
			// [XID] // 0x0000000189B542A0-0x0000000189B542C0
			public void ClearCell() {} // 0x0000000187255D70-0x0000000187255F30
			// [XID] // 0x0000000189670070-0x0000000189670090
			public void SetElementCell(int index, FrameElementCell elementCell) {} // 0x0000000187256270-0x0000000187256440
			// [XID] // 0x0000000189B633B0-0x0000000189B633D0
			public int AddElement(FrameShapeElement element, FrameShapeManager.FrameShapeRuntime shapeRuntime) => default; // 0x0000000187255980-0x0000000187255AC0
			// [XID] // 0x0000000189B6ACF0-0x0000000189B6AD10
			public bool Update(float deltaTime) => default; // 0x0000000187256440-0x00000001872564F0
			// [XID] // 0x0000000189B723C0-0x0000000189B723E0
			public void Apply() {} // 0x0000000187255C30-0x0000000187255D70
		}
	
		// Constructors
		public FrameEmoTrack() {} // 0x00000001872587F0-0x0000000187258860
	
		// Methods
		// [XID] // 0x00000001896B6400-0x00000001896B6420
		protected FrameCell GetCell(BaseShape shape) => default; // 0x0000000187257EB0-0x0000000187258070
		// [XID] // 0x0000000189AB6D20-0x0000000189AB6D40
		public override void EnableShape(BaseShape shape, float startTime = 0f /* Metadata: 0x00ADF806 */) {} // 0x0000000187257CE0-0x0000000187257EB0
		// [XID] // 0x0000000189ABE760-0x0000000189ABE780
		protected virtual void BuildFrames(ref FrameCell preCell, ref FrameCell curCell, ref FrameCell tickCell) {} // 0x00000001872575F0-0x00000001872579E0
		// [XID] // 0x0000000189AC6270-0x0000000189AC6290
		public override void ClearShape() {} // 0x0000000187257B50-0x0000000187257CE0
		// [XID] // 0x0000000189ACD9A0-0x0000000189ACD9C0
		protected void ClearInternal() {} // 0x00000001872579E0-0x0000000187257A90
		// [XID] // 0x0000000189AD5770-0x0000000189AD5790
		public override void ClearShapeOnly() {} // 0x0000000187257A90-0x0000000187257B50
		// [XID] // 0x0000000189AB9390-0x0000000189AB93B0
		public override void PlayBakedSequence(SequenceBakeData.BakeData bakeData) {} // 0x0000000187258070-0x0000000187258220
		// [XID] // 0x0000000189945420-0x0000000189945440
		private void UpdateTickCel(float deltaTime) {} // 0x0000000187258630-0x0000000187258700
		// [XID] // 0x0000000189AEBF30-0x0000000189AEBF50
		private void ApplyTickCell() {} // 0x0000000187257490-0x0000000187257530
		// [XID] // 0x0000000189AF3970-0x0000000189AF3990
		private void UpdateBakedBindings(float deltaTime) {} // 0x00000001872584D0-0x0000000187258630
		// [XID] // 0x0000000189B58180-0x0000000189B581A0
		private void ApplyBakedBindings() {} // 0x00000001872572F0-0x0000000187257490
		// [XID] // 0x0000000189B84ED0-0x0000000189B84EF0
		public override void Update(float deltaTime) {} // 0x0000000187258700-0x00000001872587F0
		// [XID] // 0x0000000189B09E10-0x0000000189B09E30
		public override void Apply() {} // 0x0000000187257530-0x00000001872575F0
	}
}
