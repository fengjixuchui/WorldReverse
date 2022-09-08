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

namespace Gaia
{
	[Serializable]
	public class ResourceProtoDNA // TypeDefIndex: 9289
	{
		// Fields
		// [Tooltip] // 0x00000001896CB510-0x00000001896CB540
		public float m_width; // 0x10
		// [Tooltip] // 0x00000001896D4350-0x00000001896D4380
		public float m_height; // 0x14
		// [Tooltip] // 0x00000001896DD160-0x00000001896DD190
		public float m_boundsRadius; // 0x18
		// [Tooltip] // 0x00000001896E5F20-0x00000001896E5F50
		public float m_seedThrow; // 0x1C
		// [Tooltip] // 0x00000001896EEE00-0x00000001896EEE30
		public float m_minScale; // 0x20
		// [Tooltip] // 0x00000001896F7CC0-0x00000001896F7CF0
		public float m_maxScale; // 0x24
		// [Tooltip] // 0x0000000189700CE0-0x0000000189700D10
		public bool m_rndScaleInfluence; // 0x28
		// [Tooltip] // 0x0000000189709C60-0x0000000189709C90
		public string m_extParam; // 0x30
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int m_protoIdx; // 0x38
	
		// Constructors
		public ResourceProtoDNA() {} // 0x0000000185A02100-0x0000000185A021A0
	
		// Methods
		// [IDTag] // 0x000000018971A510-0x000000018971A550
		// [XID] // 0x000000018971A510-0x000000018971A550
		public void Update(int protoIdx) {} // 0x0000000185A02050-0x0000000185A02100
		// [IDTag] // 0x0000000189724740-0x0000000189724780
		// [XID] // 0x0000000189724740-0x0000000189724780
		public void Update(int protoIdx, float width, float height) {} // 0x0000000185A01DD0-0x0000000185A01EF0
		// [IDTag] // 0x000000018972EEB0-0x000000018972EEF0
		// [XID] // 0x000000018972EEB0-0x000000018972EEF0
		public void Update(int protoIdx, float width, float height, float minscale, float maxscale) {} // 0x0000000185A01EF0-0x0000000185A02050
		// [IDTag] // 0x00000001897394D0-0x0000000189739510
		// [XID] // 0x00000001897394D0-0x0000000189739510
		public float GetScale(float fitness) => default; // 0x0000000185A01C10-0x0000000185A01CE0
		// [IDTag] // 0x0000000189743E80-0x0000000189743EC0
		// [XID] // 0x0000000189743E80-0x0000000189743EC0
		public float GetScale(float fitness, float random) => default; // 0x0000000185A01CE0-0x0000000185A01DD0
	}
}
