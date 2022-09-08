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

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningGenerator // TypeDefIndex: 9677
	{
		// Fields
		public static readonly LightningGenerator GeneratorInstance; // 0x00
	
		// Constructors
		public LightningGenerator() {} // 0x0000000186045D30-0x0000000186045D90
		static LightningGenerator() {} // 0x0000000186045C70-0x0000000186045D30
	
		// Methods
		// [XID] // 0x00000001899F3C10-0x00000001899F3C30
		private void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side) {
			side = default;
		} // 0x0000000186044BA0-0x0000000186044E30
		// [XID] // 0x0000000189768400-0x0000000189768420
		protected virtual void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p) {} // 0x0000000186044E30-0x0000000186044FF0
		// [XID] // 0x0000000189941DD0-0x0000000189941DF0
		public bool ShouldCreateFork(LightningBoltParameters p, int generation, int totalGenerations) => default; // 0x0000000186045B30-0x0000000186045C70
		// [XID] // 0x0000000189B6CA00-0x0000000189B6CA20
		public void CreateFork(LightningBolt bolt, LightningBoltParameters p, int generation, int totalGenerations, Vector3 start, Vector3 midPoint) {} // 0x0000000186043FA0-0x0000000186044240
		// [XID] // 0x00000001897457B0-0x00000001897457D0
		public void GenerateLightningBoltStandard(LightningBolt bolt, Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount, LightningBoltParameters p) {} // 0x0000000186044240-0x00000001860448C0
		// [XID] // 0x000000018974D250-0x000000018974D270
		public Vector3 RandomDirection3D(System.Random r) => default; // 0x0000000186045310-0x0000000186045510
		// [XID] // 0x000000018992DAB0-0x000000018992DAD0
		public Vector3 RandomDirection2D(System.Random r) => default; // 0x0000000186045180-0x0000000186045310
		// [XID] // 0x0000000189741B00-0x0000000189741B20
		public Vector3 RandomDirection2DXZ(System.Random r) => default; // 0x0000000186044FF0-0x0000000186045180
		// [XID] // 0x00000001897634C0-0x00000001897634E0
		public void RandomVector(LightningBolt bolt, ref Vector3 start, ref Vector3 end, float offsetAmount, System.Random random, out Vector3 result) {
			result = default;
		} // 0x0000000186045510-0x0000000186045B30
		// [IDTag] // 0x000000018976AC70-0x000000018976ACB0
		// [XID] // 0x000000018976AC70-0x000000018976ACB0
		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters p) {} // 0x00000001860448C0-0x00000001860449C0
		// [IDTag] // 0x0000000189774FF0-0x0000000189775030
		// [XID] // 0x0000000189774FF0-0x0000000189775030
		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters p, out Vector3 start, out Vector3 end) {
			start = default;
			end = default;
		} // 0x00000001860449C0-0x0000000186044BA0
	}
}
