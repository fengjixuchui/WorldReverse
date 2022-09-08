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
	public class ClipShapeElement : ShapeElement // TypeDefIndex: 8535
	{
		// Fields
		public AnimationClip mainClip; // 0x18
		public ClipShapeCurveGrp mainCurveGrp; // 0x20
		public AnimationClip postClip; // 0x28
		public ClipShapeCurveGrp postCurveGrp; // 0x30
		public AnimationClip blinkClip; // 0x38
		public ClipShapeCurveGrp blinkCurveGrp; // 0x40
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public float postBlendTime; // 0x48
		public bool isPost; // 0x4C
		public string[] noPost; // 0x50
		public bool isToFinal; // 0x58
		public string[] toFinal; // 0x60
	
		// Properties
		public override float duration { /* [XID] */ /* 0x0000000189883950-0x0000000189883970 */ get => default; } // 0x00000001873247A0-0x0000000187324890 
		public override float postDuration { /* [XID] */ /* 0x000000018988B120-0x000000018988B140 */ get => default; } // 0x0000000187324890-0x0000000187324990 
	
		// Constructors
		public ClipShapeElement() {} // 0x0000000187324730-0x00000001873247A0
	
		// Methods
	}
}
