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
	public class SequenceClipBakeData : SequenceBakeData // TypeDefIndex: 8517
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BakeData _phonemeBakeData; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BakeData _emotionBakeData; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<EyeCtrlData> eyeCtrlList; // 0x28
	
		// Properties
		public override BakeData phonemeBakeData { /* [XID] */ /* 0x00000001896E77B0-0x00000001896E77D0 */ get => default; /* [XID] */ /* 0x00000001899DD320-0x00000001899DD340 */ set {} } // 0x000000018726A920-0x000000018726A9C0 0x000000018726AAB0-0x000000018726ABA0
		public override BakeData emotionBakeData { /* [XID] */ /* 0x00000001896F68B0-0x00000001896F68D0 */ get => default; /* [XID] */ /* 0x00000001896FE000-0x00000001896FE020 */ set {} } // 0x000000018726A880-0x000000018726A920 0x000000018726A9C0-0x000000018726AAB0
	
		// Nested types
		[Serializable]
		public class ClipPathProp : ISerializationCallbackReceiver // TypeDefIndex: 8518
		{
			// Fields
			public string path; // 0x10
			public string prop; // 0x18
	
			// Constructors
			public ClipPathProp() {} // 0x0000000187252500-0x0000000187252630
	
			// Methods
			// [XID] // 0x0000000189705350-0x0000000189705370
			public void OnBeforeSerialize() {} // 0x0000000187252460-0x0000000187252500
			// [XID] // 0x000000018970CA50-0x000000018970CA70
			public void OnAfterDeserialize() {} // 0x0000000187252380-0x0000000187252460
		}
	
		[Serializable]
		public class ClipBinding : ISerializationCallbackReceiver // TypeDefIndex: 8519
		{
			// Fields
			public string elementName; // 0x10
			public Type grpType; // 0x18
	
			// Nested types
			public enum Type // TypeDefIndex: 8520
			{
				INVALID = -1,
				MAIN = 0,
				POST = 1,
				BLINK = 2
			}
	
			// Constructors
			public ClipBinding() {} // 0x0000000187252310-0x0000000187252380
	
			// Methods
			// [XID] // 0x00000001897141F0-0x0000000189714210
			public void OnBeforeSerialize() {} // 0x0000000187252270-0x0000000187252310
			// [XID] // 0x0000000189B6CB20-0x0000000189B6CB40
			public void OnAfterDeserialize() {} // 0x00000001872521A0-0x0000000187252270
			// [XID] // 0x0000000189723030-0x0000000189723050
			public static ClipBinding CreateBinding(string eName, Type bindingGrpType, int index) => default; // 0x0000000187252070-0x00000001872521A0
		}
	
		[Serializable]
		public class ClipBindingGrp // TypeDefIndex: 8521
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public ClipBinding[] bindings; // 0x10
	
			// Constructors
			public ClipBindingGrp() {} // 0x0000000187252000-0x0000000187252070
	
			// Methods
			// [XID] // 0x00000001899542F0-0x0000000189954310
			public void GetByIndex(int index, out ClipBinding clipBinding) {
				clipBinding = default;
			} // 0x0000000187251EF0-0x0000000187252000
		}
	
		[Serializable]
		public class BakeData : SequenceBakeData.BakeData // TypeDefIndex: 8522
		{
			// Fields
			public ClipShapeCurveGrp bakedGrp; // 0x20
			public ClipBindingGrp bakedClipBindingGrp; // 0x28
	
			// Constructors
			public BakeData() {} // 0x000000018724CC70-0x000000018724CD30
		}
	
		[Serializable]
		public class EyeCtrlData : SequenceBakeData.BakeData // TypeDefIndex: 8523
		{
			// Fields
			public float startTime; // 0x20
			public Vector3 leftEyeRot; // 0x24
			public Vector3 rightEyeRot; // 0x30
			public Vector3 leftScale; // 0x3C
			public Vector3 rightScale; // 0x48
			public bool starEye; // 0x54
			public float faceFlush; // 0x58
			public static readonly EyeCtrlData dummyData; // 0x00
	
			// Constructors
			public EyeCtrlData() {} // 0x0000000187252EB0-0x0000000187253000
			static EyeCtrlData() {} // 0x0000000187252E30-0x0000000187252EB0
	
			// Methods
			// [XID] // 0x0000000189739680-0x00000001897396A0
			public void ResetData() {} // 0x0000000187252CF0-0x0000000187252E30
			// [XID] // 0x0000000189679DC0-0x0000000189679DE0
			public void Lerp(EyeCtrlData lastData, EyeCtrlData targetData, float fracment) {} // 0x0000000187252A30-0x0000000187252CF0
		}
	
		// Constructors
		public SequenceClipBakeData() {} // 0x000000018726A7D0-0x000000018726A880
	
		// Methods
	}
}
