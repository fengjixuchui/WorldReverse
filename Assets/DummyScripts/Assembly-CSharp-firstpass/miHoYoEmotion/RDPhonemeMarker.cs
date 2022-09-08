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
	public class RDPhonemeMarker // TypeDefIndex: 8509
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int emotionIndex; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int phonemeNumber; // 0x14
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float time; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float value; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string word; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float decibel; // 0x28
	
		// Constructors
		public RDPhonemeMarker() {} // Dummy constructor
		public RDPhonemeMarker(int phonemeNumber, float time, float value, int emotionIndex = 0 /* Metadata: 0x00ADF9E4 */, string word = "" /* Metadata: 0x00ADF9E8 */, float decibel = 0f /* Metadata: 0x00ADF9EC */) {} // 0x00000001872699E0-0x000000018726A2F0
	
		// Methods
		// [XID] // 0x0000000189BD1290-0x0000000189BD12B0
		public RDPhonemeMarker CreateCopy() => default; // 0x00000001872698B0-0x00000001872699E0
	}
}
