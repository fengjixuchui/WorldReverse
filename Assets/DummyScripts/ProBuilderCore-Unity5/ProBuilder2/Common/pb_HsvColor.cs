/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_HsvColor // TypeDefIndex: 3365
	{
		// Fields
		public float h; // 0x10
		public float s; // 0x14
		public float v; // 0x18
	
		// Constructors
		public pb_HsvColor() {} // Dummy constructor
		public pb_HsvColor(float h, float s, float v) {} // 0x0000000186BA0170-0x0000000186BA0210
		public pb_HsvColor(float h, float s, float v, float sv_modifier) {} // 0x0000000186BA0210-0x0000000186BA02C0
	
		// Methods
		public static pb_HsvColor FromRGB(Color col) => default; // 0x0000000186B9FF00-0x0000000186B9FFA0
		public override string ToString() => default; // 0x0000000186BA0060-0x0000000186BA0170
		public float SqrDistance(pb_HsvColor InColor) => default; // 0x0000000186B9FFA0-0x0000000186BA0060
	}
}
