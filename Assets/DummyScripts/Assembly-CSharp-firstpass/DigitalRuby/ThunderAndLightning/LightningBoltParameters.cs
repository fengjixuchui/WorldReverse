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

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public sealed class LightningBoltParameters // TypeDefIndex: 9631
	{
		// Fields
		private static int randomSeed; // 0x00
		private static readonly List<LightningBoltParameters> cache; // 0x08
		internal int generationWhereForksStop; // 0x10
		internal int forkednessCalculated; // 0x14
		internal LightningBoltQualitySetting quality; // 0x18
		internal float delaySeconds; // 0x1C
		internal int maxLights; // 0x20
		public static float Scale; // 0x10
		public static readonly Dictionary<int, LightningQualityMaximum> QualityMaximums; // 0x18
		public LightningGenerator Generator; // 0x28
		public Vector3 Start; // 0x30
		public Vector3 End; // 0x3C
		public Vector3 StartVariance; // 0x48
		public Vector3 EndVariance; // 0x54
		public Action<LightningCustomTransformStateInfo> CustomTransform; // 0x60
		private int generations; // 0x68
		public float LifeTime; // 0x6C
		public float Delay; // 0x70
		public RangeOfFloats DelayRange; // 0x74
		public float ChaosFactor; // 0x7C
		public float ChaosFactorForks; // 0x80
		public float TrunkWidth; // 0x84
		public float EndWidthMultiplier; // 0x88
		public float Intensity; // 0x8C
		public float GlowIntensity; // 0x90
		public float GlowWidthMultiplier; // 0x94
		public float Forkedness; // 0x98
		public int GenerationWhereForksStopSubtractor; // 0x9C
		public Color32 Color; // 0xA0
		private System.Random random; // 0xA8
		private System.Random currentRandom; // 0xB0
		private System.Random randomOverride; // 0xB8
		public float FadePercent; // 0xC0
		public float FadeInMultiplier; // 0xC4
		public float FadeFullyLitMultiplier; // 0xC8
		public float FadeOutMultiplier; // 0xCC
		private float growthMultiplier; // 0xD0
		public float ForkLengthMultiplier; // 0xD4
		public float ForkLengthVariance; // 0xD8
		public float ForkEndWidthMultiplier; // 0xDC
		public int SmoothingFactor; // 0xE8
	
		// Properties
		public int Generations { /* [XID] */ /* 0x000000018965C310-0x000000018965C330 */ get => default; /* [XID] */ /* 0x0000000189871F30-0x0000000189871F50 */ set {} } // 0x0000000186039900-0x00000001860399A0 0x0000000186039C10-0x0000000186039E40
		public System.Random Random { /* [XID] */ /* 0x00000001896A7540-0x00000001896A7560 */ get => default; /* [XID] */ /* 0x0000000189880DB0-0x0000000189880DD0 */ set {} } // 0x0000000186039B60-0x0000000186039C10 0x000000018603A060-0x000000018603A140
		public System.Random RandomOverride { /* [XID] */ /* 0x0000000189888170-0x0000000189888190 */ get => default; /* [XID] */ /* 0x000000018988F740-0x000000018988F760 */ set {} } // 0x0000000186039AB0-0x0000000186039B60 0x0000000186039FA0-0x000000018603A060
		public float GrowthMultiplier { /* [XID] */ /* 0x0000000189896C60-0x0000000189896C80 */ get => default; /* [XID] */ /* 0x000000018989E0D0-0x000000018989E0F0 */ set {} } // 0x00000001860399A0-0x0000000186039A50 0x0000000186039E40-0x0000000186039F30
		public List<Vector3> Points { /* [XID] */ /* 0x00000001898A5AF0-0x00000001898A5B30 */ get; /* [XID] */ /* 0x00000001898B0190-0x00000001898B01D0 */ set; } // 0x0000000186039A50-0x0000000186039AB0 0x0000000186039F30-0x0000000186039FA0
	
		// Constructors
		static LightningBoltParameters() {} // 0x0000000186039280-0x00000001860397A0
		public LightningBoltParameters() {} // 0x00000001860397A0-0x0000000186039900
	
		// Methods
		// [XID] // 0x000000018976FB10-0x000000018976FB30
		public float ForkMultiplier() => default; // 0x0000000186038D30-0x0000000186038E20
		// [XID] // 0x00000001897C30D0-0x00000001897C30F0
		public Vector3 ApplyVariance(Vector3 pos, Vector3 variance) => default; // 0x0000000186038AA0-0x0000000186038D30
		// [XID] // 0x00000001898C9890-0x00000001898C98B0
		public void Reset() {} // 0x0000000186038FE0-0x0000000186039130
		// [XID] // 0x000000018979D2F0-0x000000018979D310
		public static LightningBoltParameters GetOrCreateParameters() => default; // 0x0000000186038E20-0x0000000186038FE0
		// [XID] // 0x0000000189794D80-0x0000000189794DA0
		public static void ReturnParametersToCache(LightningBoltParameters p) {} // 0x0000000186039130-0x0000000186039280
	}
}
