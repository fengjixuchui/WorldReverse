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

namespace CTS
{
	[Serializable]
	public class CTSWeatherManager : MonoBehaviour // TypeDefIndex: 9137
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_snowPower; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_snowMinHeight; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_rainPower; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_maxRainSmoothness; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_season; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_winterTint; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_springTint; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_summerTint; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_autumnTint; // 0x5C
		private bool m_somethingChanged; // 0x6C
	
		// Properties
		public float SnowPower { /* [XID] */ /* 0x00000001898C0890-0x00000001898C08B0 */ get => default; /* [XID] */ /* 0x00000001898C8040-0x00000001898C8060 */ set {} } // 0x0000000187578990-0x0000000187578A40 0x00000001875791D0-0x00000001875792D0
		public float SnowMinHeight { /* [XID] */ /* 0x00000001896C6BB0-0x00000001896C6BD0 */ get => default; /* [XID] */ /* 0x00000001898D71B0-0x00000001898D71D0 */ set {} } // 0x00000001875788E0-0x0000000187578990 0x00000001875790F0-0x00000001875791D0
		public float RainPower { /* [XID] */ /* 0x00000001898DEF50-0x00000001898DEF70 */ get => default; /* [XID] */ /* 0x00000001898E6500-0x00000001898E6520 */ set {} } // 0x0000000187578780-0x0000000187578830 0x0000000187578ED0-0x0000000187578FD0
		public float MaxRainSmoothness { /* [XID] */ /* 0x00000001896D39A0-0x00000001896D39C0 */ get => default; /* [XID] */ /* 0x000000018972D4B0-0x000000018972D4D0 */ set {} } // 0x00000001875786D0-0x0000000187578780 0x0000000187578DB0-0x0000000187578ED0
		public float Season { /* [XID] */ /* 0x0000000189908210-0x0000000189908230 */ get => default; /* [XID] */ /* 0x0000000189904840-0x0000000189904860 */ set {} } // 0x0000000187578830-0x00000001875788E0 0x0000000187578FD0-0x00000001875790F0
		public Color WinterTint { /* [XID] */ /* 0x00000001898CF6E0-0x00000001898CF700 */ get => default; /* [XID] */ /* 0x00000001896300D0-0x00000001896300F0 */ set {} } // 0x0000000187578BE0-0x0000000187578CB0 0x00000001875794D0-0x00000001875795D0
		public Color SpringTint { /* [XID] */ /* 0x000000018991B470-0x000000018991B490 */ get => default; /* [XID] */ /* 0x0000000189922940-0x0000000189922960 */ set {} } // 0x0000000187578A40-0x0000000187578B10 0x00000001875792D0-0x00000001875793D0
		public Color SummerTint { /* [XID] */ /* 0x000000018992A1A0-0x000000018992A1C0 */ get => default; /* [XID] */ /* 0x0000000189637D60-0x0000000189637D80 */ set {} } // 0x0000000187578B10-0x0000000187578BE0 0x00000001875793D0-0x00000001875794D0
		public Color AutumnTint { /* [XID] */ /* 0x0000000189998730-0x0000000189998750 */ get => default; /* [XID] */ /* 0x000000018974B810-0x000000018974B830 */ set {} } // 0x0000000187578600-0x00000001875786D0 0x0000000187578CB0-0x0000000187578DB0
	
		// Constructors
		public CTSWeatherManager() {} // 0x00000001875784C0-0x0000000187578600
	
		// Methods
		// [XID] // 0x0000000189947E30-0x0000000189947E50
		private void Start() {} // 0x00000001875783C0-0x00000001875784C0
		// [XID] // 0x0000000189752C10-0x0000000189752C30
		private void LateUpdate() {} // 0x0000000187578320-0x00000001875783C0
		// [XID] // 0x0000000189956980-0x00000001899569A0
		private void BroadcastUpdates() {} // 0x0000000187578230-0x0000000187578320
	}
}
