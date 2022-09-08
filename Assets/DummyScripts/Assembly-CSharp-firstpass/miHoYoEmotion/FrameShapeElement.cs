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
	[Serializable]
	public class FrameShapeElement : ShapeElement, ISerializationCallbackReceiver // TypeDefIndex: 8539
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public TYPE type; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string propertyName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float frameRate; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Texture2D[] mainFrames; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Texture2D[] postFrames; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Texture2D[] blinkFrames; // 0x40
	
		// Properties
		public override float duration { /* [XID] */ /* 0x00000001897CF0F0-0x00000001897CF110 */ get => default; } // 0x0000000187259130-0x0000000187259200 
		public override float postDuration { /* [XID] */ /* 0x0000000189921190-0x00000001899211B0 */ get => default; } // 0x0000000187259200-0x00000001872592D0 
		public override float blinkDuration { /* [XID] */ /* 0x0000000189928B70-0x0000000189928B90 */ get => default; } // 0x0000000187259060-0x0000000187259130 
	
		// Nested types
		public enum TYPE // TypeDefIndex: 8540
		{
			INVALID = -1,
			MOUTH = 0,
			EYE_LEFT = 1,
			EYE_RIGHT = 2
		}
	
		// Constructors
		public FrameShapeElement() {} // 0x0000000187258FA0-0x0000000187259060
	
		// Methods
		// [XID] // 0x00000001898875E0-0x0000000189887600
		public void OnBeforeSerialize() {} // 0x0000000187258DB0-0x0000000187258E50
		// [XID] // 0x0000000189912110-0x0000000189912130
		public void OnAfterDeserialize() {} // 0x0000000187258CE0-0x0000000187258DB0
	}
}
