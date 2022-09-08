/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoFPSIndicator : MonoBehaviour // TypeDefIndex: 31325
	{
		// Fields
		public float updateInterval; // 0x18
		public float fpsMin; // 0x1C
		public float fpsMax; // 0x20
		public float fpsAvg; // 0x24
		public string logContext; // 0x28
		private float _time; // 0x30
		private int _frames; // 0x34
		private float _timeleft; // 0x38
		private float _totalTime; // 0x3C
		private int _totalFrames; // 0x40
		private SimpleText _text; // 0x48
		private float _fps; // 0x50
		public static bool profilerTimeTagByAutoTest; // 0x00
	
		// Constructors
		public MonoFPSIndicator() {} // 0x0000000184AD9CC0-0x0000000184AD9D50
		static MonoFPSIndicator() {} // 0x0000000184AD9C60-0x0000000184AD9CC0
	
		// Methods
		// [XID] // 0x000000018985D530-0x000000018985D550
		public void Start() {} // 0x0000000184AD9840-0x0000000184AD9A20
		// [XID] // 0x0000000189864F10-0x0000000189864F30
		public void Update() {} // 0x0000000184AD9A20-0x0000000184AD9C60
	}
}
