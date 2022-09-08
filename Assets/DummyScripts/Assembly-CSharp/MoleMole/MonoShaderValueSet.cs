/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoShaderValueSet : MonoBehaviour // TypeDefIndex: 19844
	{
		// Fields
		public TargetMat Material1; // 0x18
		public TargetMat Material2; // 0x98
		public TargetMat Material3; // 0x118
	
		// Nested types
		[Serializable]
		public struct ColorPart // TypeDefIndex: 19845
		{
			// Fields
			public string name; // 0x00
			public Color color; // 0x08
		}
	
		[Serializable]
		public struct FloatPart // TypeDefIndex: 19846
		{
			// Fields
			public string name; // 0x00
			public float value; // 0x08
		}
	
		[Serializable]
		public struct TargetMat // TypeDefIndex: 19847
		{
			// Fields
			public string[] renderNames; // 0x00
			public ColorPart color1; // 0x08
			public ColorPart color2; // 0x20
			public ColorPart color3; // 0x38
			public FloatPart floatValue1; // 0x50
			public FloatPart floatValue2; // 0x60
			public FloatPart floatValue3; // 0x70
		}
	
		// Constructors
		public MonoShaderValueSet() {} // 0x000000018411E050-0x000000018411E0B0
	
		// Methods
		// [XID] // 0x00000001896EC8C0-0x00000001896EC8E0
		public void Start() {} // 0x000000018411DF10-0x000000018411DFB0
		// [XID] // 0x00000001896F40C0-0x00000001896F40E0
		public void Awake() {} // 0x000000018411DE70-0x000000018411DF10
		// [XID] // 0x00000001896FB950-0x00000001896FB970
		public void Update() {} // 0x000000018411DFB0-0x000000018411E050
	}
}
