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
	public abstract class LightningBoltPrefabScriptBase : LightningBoltScript // TypeDefIndex: 9655
	{
		// Fields
		private static bool showedManualWarning; // 0x00
		private readonly List<LightningBoltParameters> batchParameters; // 0x130
		private readonly System.Random random; // 0x138
		// [Header] // 0x000000018973C920-0x000000018973C9A0
		// [SingleLineClamp] // 0x000000018973C920-0x000000018973C9A0
		public RangeOfFloats IntervalRange; // 0x140
		// [SingleLineClamp] // 0x000000018974A190-0x000000018974A1D0
		public RangeOfIntegers CountRange; // 0x148
		// [Range] // 0x0000000189752DD0-0x0000000189752E30
		// [Tooltip] // 0x0000000189752DD0-0x0000000189752E30
		public float CountProbabilityModifier; // 0x150
		// [SingleLineClamp] // 0x000000018975EDF0-0x000000018975EE30
		public RangeOfFloats DelayRange; // 0x154
		// [SingleLineClamp] // 0x00000001897678C0-0x0000000189767910
		public RangeOfFloats DurationRange; // 0x15C
		// [Header] // 0x0000000189770930-0x00000001897709B0
		// [SingleLineClamp] // 0x0000000189770930-0x00000001897709B0
		public RangeOfFloats TrunkWidthRange; // 0x164
		// [Range] // 0x000000018977DF80-0x000000018977DFE0
		// [Tooltip] // 0x000000018977DF80-0x000000018977DFE0
		public float LifeTime; // 0x16C
		// [Range] // 0x0000000189789EE0-0x0000000189789F30
		// [Tooltip] // 0x0000000189789EE0-0x0000000189789F30
		public int Generations; // 0x170
		// [Range] // 0x0000000189795DC0-0x0000000189795E10
		// [Tooltip] // 0x0000000189795DC0-0x0000000189795E10
		public float ChaosFactor; // 0x174
		// [Range] // 0x00000001897A2450-0x00000001897A24A0
		// [Tooltip] // 0x00000001897A2450-0x00000001897A24A0
		public float ChaosFactorForks; // 0x178
		// [Range] // 0x00000001897AE3A0-0x00000001897AE400
		// [Tooltip] // 0x00000001897AE3A0-0x00000001897AE400
		public float Intensity; // 0x17C
		// [Range] // 0x00000001897BA8D0-0x00000001897BA920
		// [Tooltip] // 0x00000001897BA8D0-0x00000001897BA920
		public float GlowIntensity; // 0x180
		// [Range] // 0x00000001897C71F0-0x00000001897C7250
		// [Tooltip] // 0x00000001897C71F0-0x00000001897C7250
		public float GlowWidthMultiplier; // 0x184
		// [Range] // 0x00000001897D2DE0-0x00000001897D2E30
		// [Tooltip] // 0x00000001897D2DE0-0x00000001897D2E30
		public float FadePercent; // 0x188
		// [Range] // 0x00000001897DED80-0x00000001897DEDD0
		// [Tooltip] // 0x00000001897DED80-0x00000001897DEDD0
		public float FadeInMultiplier; // 0x18C
		// [Range] // 0x00000001897EAF80-0x00000001897EAFD0
		// [Tooltip] // 0x00000001897EAF80-0x00000001897EAFD0
		public float FadeFullyLitMultiplier; // 0x190
		// [Range] // 0x00000001897F70D0-0x00000001897F7120
		// [Tooltip] // 0x00000001897F70D0-0x00000001897F7120
		public float FadeOutMultiplier; // 0x194
		// [Range] // 0x0000000189803230-0x0000000189803290
		// [Tooltip] // 0x0000000189803230-0x0000000189803290
		public float GrowthMultiplier; // 0x198
		// [Range] // 0x000000018980EFA0-0x000000018980EFF0
		// [Tooltip] // 0x000000018980EFA0-0x000000018980EFF0
		public float EndWidthMultiplier; // 0x19C
		// [Range] // 0x000000018981B050-0x000000018981B0A0
		// [Tooltip] // 0x000000018981B050-0x000000018981B0A0
		public float Forkedness; // 0x1A0
		// [Range] // 0x0000000189826E90-0x0000000189826EE0
		// [Tooltip] // 0x0000000189826E90-0x0000000189826EE0
		public float ForkLengthMultiplier; // 0x1A4
		// [Range] // 0x0000000189832B70-0x0000000189832BC0
		// [Tooltip] // 0x0000000189832B70-0x0000000189832BC0
		public float ForkLengthVariance; // 0x1A8
		// [Range] // 0x000000018983E8B0-0x000000018983E900
		// [Tooltip] // 0x000000018983E8B0-0x000000018983E900
		public float ForkEndWidthMultiplier; // 0x1AC
		// [Range] // 0x000000018984A4D0-0x000000018984A530
		// [Tooltip] // 0x000000018984A4D0-0x000000018984A530
		public int MaximumLightsPerBatch; // 0x1B0
		// [Header] // 0x0000000189855EF0-0x0000000189855F50
		// [Tooltip] // 0x0000000189855EF0-0x0000000189855F50
		public bool ManualMode; // 0x1B4
		// [Header] // 0x0000000189863830-0x0000000189863890
		// [Tooltip] // 0x0000000189863830-0x0000000189863890
		public LightningCustomTransformDelegate CustomTransformHandler; // 0x1B8
		protected Vector3 lightningStartPos; // 0x1C0
		protected Vector3 lightningEndPos; // 0x1CC
		private float nextArc; // 0x1E0
		private float lifeTimeRemaining; // 0x1E4
		public Action<GameObject> destroyCallback; // 0x1E8
	
		// Properties
		public System.Random RandomOverride { /* [XID] */ /* 0x000000018987B1D0-0x000000018987B210 */ get; set; } // 0x000000018603BDC0-0x000000018603BE20 0x000000018603BE20-0x000000018603BE90
	
		// Constructors
		protected LightningBoltPrefabScriptBase() {} // 0x000000018603BBB0-0x000000018603BDC0
	
		// Methods
		// [XID] // 0x000000018988C900-0x000000018988C920
		private void CreateInterval(float offset) {} // 0x000000018603AE00-0x000000018603AEF0
		// [XID] // 0x0000000189893DE0-0x0000000189893E00
		private void CustomTransform(LightningCustomTransformStateInfo state) {} // 0x000000018603B0E0-0x000000018603B1A0
		// [XID] // 0x000000018989B4F0-0x000000018989B510
		private void CallLightning() {} // 0x000000018603ABB0-0x000000018603AE00
		// [XID] // 0x00000001898A2A20-0x00000001898A2A40
		protected void CreateLightningBoltsNow() {} // 0x000000018603AFC0-0x000000018603B0E0
		// [XID] // 0x0000000189945960-0x0000000189945980
		protected override void PopulateParameters(LightningBoltParameters p) {} // 0x000000018603B260-0x000000018603B4F0
		// [XID] // 0x00000001898B1890-0x00000001898B18B0
		protected void OnEnable() {} // 0x000000018603B1A0-0x000000018603B260
		// [XID] // 0x00000001897823E0-0x0000000189782400
		public void SetLifeTime(float time) {} // 0x000000018603B4F0-0x000000018603B5A0
		// [XID] // 0x00000001899EF5B0-0x00000001899EF5D0
		protected override void Update() {} // 0x000000018603B9E0-0x000000018603BBB0
		// [XID] // 0x00000001898C8000-0x00000001898C8020
		public override void CreateLightningBolt(LightningBoltParameters p) {} // 0x000000018603AEF0-0x000000018603AFC0
		// [IDTag] // 0x00000001898CF830-0x00000001898CF870
		// [XID] // 0x00000001898CF830-0x00000001898CF870
		public void Trigger() {} // 0x000000018603B7E0-0x000000018603B880
		// [IDTag] // 0x00000001898DA0B0-0x00000001898DA0F0
		// [XID] // 0x00000001898DA0B0-0x00000001898DA0F0
		public void Trigger(Vector3 start, Vector3 end) {} // 0x000000018603B6B0-0x000000018603B7E0
		// [XID] // 0x0000000189742970-0x0000000189742990
		public virtual void SetLightningPath(Vector3 startPos, Vector3 endPos) {} // 0x000000018603B5A0-0x000000018603B6B0
	}
}
