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
	public class WaterFlowMap // TypeDefIndex: 9344
	{
		// Fields
		public float m_dropletVolume; // 0x10
		public float m_dropletAbsorbtionRate; // 0x14
		public int m_waterflowSmoothIterations; // 0x18
		private UnityHeightMap m_heightMap; // 0x20
		private HeightMap m_waterFlowMap; // 0x28
	
		// Constructors
		public WaterFlowMap() {} // 0x0000000185A49D90-0x0000000185A49E10
	
		// Methods
		// [XID] // 0x000000018972D670-0x000000018972D690
		public void CreateWaterFlowMap(Terrain terrain) {} // 0x0000000185A49830-0x0000000185A49A00
		// [XID] // 0x0000000189A28640-0x0000000189A28660
		private void TraceWaterFlow(int startX, int startZ, int width, int height) {} // 0x0000000185A49AF0-0x0000000185A49D90
		// [XID] // 0x000000018973C9A0-0x000000018973C9C0
		public void ExportWaterMapToPath(string path) {} // 0x0000000185A49A00-0x0000000185A49AF0
	}
}
