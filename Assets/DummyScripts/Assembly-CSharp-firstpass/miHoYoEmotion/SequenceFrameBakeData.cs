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

namespace miHoYoEmotion
{
	public class SequenceFrameBakeData : SequenceBakeData // TypeDefIndex: 8524
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BakeData _phonemeBakeData; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BakeData _emotionBakeData; // 0x20
	
		// Properties
		public override BakeData phonemeBakeData { /* [XID] */ /* 0x00000001897576A0-0x00000001897576C0 */ get => default; /* [XID] */ /* 0x000000018975EEB0-0x000000018975EED0 */ set {} } // 0x000000018726AED0-0x000000018726AF70 0x000000018726B060-0x000000018726B150
		public override BakeData emotionBakeData { /* [XID] */ /* 0x00000001897662B0-0x00000001897662D0 */ get => default; /* [XID] */ /* 0x000000018976DB40-0x000000018976DB60 */ set {} } // 0x000000018726AE30-0x000000018726AED0 0x000000018726AF70-0x000000018726B060
	
		// Nested types
		[Serializable]
		public class FrameKey // TypeDefIndex: 8525
		{
			// Fields
			public float frameTime; // 0x10
			public Texture2D frame; // 0x18
			public int bindingIndex; // 0x20
	
			// Constructors
			public FrameKey() {} // 0x00000001872589C0-0x0000000187258A20
		}
	
		[Serializable]
		public class FrameBindingIndex // TypeDefIndex: 8526
		{
			// Fields
			public string bindingName; // 0x10
	
			// Constructors
			public FrameBindingIndex() {} // 0x0000000187255000-0x0000000187255060
		}
	
		[Serializable]
		public class FrameBinding // TypeDefIndex: 8527
		{
			// Fields
			public FrameShapeElement.TYPE bindingType; // 0x10
			public FrameKey[] bindingFrames; // 0x18
			public FrameBindingIndex[] bindingIndexes; // 0x20
			[NonSerialized]
			public string preBindingName; // 0x28
			private float _timeCnt; // 0x30
			private int _currFrameCnt; // 0x34
			private int _nextFrameCnt; // 0x38
			private bool _needApply; // 0x3C
	
			// Constructors
			public FrameBinding() {} // 0x00000001872556A0-0x0000000187255720
	
			// Methods
			// [XID] // 0x0000000189B2B040-0x0000000189B2B060
			public void ResetFrame() {} // 0x00000001872554C0-0x0000000187255570
			// [XID] // 0x0000000189B491C0-0x0000000189B491E0
			public void UpdateFrame(float deltaTime) {} // 0x0000000187255570-0x00000001872556A0
			// [XID] // 0x0000000189784310-0x0000000189784330
			public FrameKey Apply() => default; // 0x00000001872552D0-0x00000001872553C0
			// [XID] // 0x0000000189B75BD0-0x0000000189B75BF0
			public FrameBindingIndex GetBindingByKey(FrameKey key) => default; // 0x00000001872553C0-0x00000001872554C0
		}
	
		[Serializable]
		public class BakeData : SequenceBakeData.BakeData // TypeDefIndex: 8528
		{
			// Fields
			public FrameBinding[] bakedBindings; // 0x20
	
			// Constructors
			public BakeData() {} // 0x000000018724CD30-0x000000018724CDE0
		}
	
		// Constructors
		public SequenceFrameBakeData() {} // 0x000000018726AD80-0x000000018726AE30
	
		// Methods
	}
}
