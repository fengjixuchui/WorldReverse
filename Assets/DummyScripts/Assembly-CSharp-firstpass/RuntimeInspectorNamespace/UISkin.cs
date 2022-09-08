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

namespace RuntimeInspectorNamespace
{
	[CreateAssetMenu] // 0x000000018975A080-0x000000018975A0E0
	public class UISkin : ScriptableObject // TypeDefIndex: 10038
	{
		// Fields
		private int m_version; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Font m_font; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_fontSize; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_lineHeight; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_indentAmount; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_windowColor; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_backgroundColor; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_textColor; // 0x54
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_scrollbarColor; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_expandArrowColor; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_inputFieldNormalBackgroundColor; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_inputFieldInvalidBackgroundColor; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_inputFieldTextColor; // 0xA4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_toggleCheckmarkColor; // 0xB4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_buttonBackgroundColor; // 0xC4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_buttonTextColor; // 0xD4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_selectedItemBackgroundColor; // 0xE4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_selectedItemTextColor; // 0xF4
	
		// Properties
		public int Version { /* [XID] */ /* 0x0000000189848960-0x0000000189848980 */ get => default; } // 0x0000000186754D70-0x0000000186754E10 
		public Font Font { /* [XID] */ /* 0x00000001897F8AA0-0x00000001897F8AC0 */ get => default; /* [XID] */ /* 0x00000001896775E0-0x0000000189677600 */ set {} } // 0x0000000186754510-0x00000001867545B0 0x0000000186755330-0x0000000186755420
		public int FontSize { /* [XID] */ /* 0x00000001898078C0-0x00000001898078E0 */ get => default; /* [XID] */ /* 0x0000000189995210-0x0000000189995230 */ set {} } // 0x0000000186754470-0x0000000186754510 0x0000000186755280-0x0000000186755330
		public int LineHeight { /* [XID] */ /* 0x00000001898166B0-0x00000001898166D0 */ get => default; /* [XID] */ /* 0x000000018999CCF0-0x000000018999CD10 */ set {} } // 0x00000001867548C0-0x0000000186754960 0x00000001867557A0-0x0000000186755850
		public int IndentAmount { /* [XID] */ /* 0x0000000189AF9860-0x0000000189AF9880 */ get => default; /* [XID] */ /* 0x000000018982CCF0-0x000000018982CD10 */ set {} } // 0x00000001867545B0-0x0000000186754650 0x0000000186755420-0x00000001867554D0
		public Color WindowColor { /* [XID] */ /* 0x0000000189B7A770-0x0000000189B7A790 */ get => default; /* [XID] */ /* 0x0000000189668300-0x0000000189668320 */ set {} } // 0x0000000186754E10-0x0000000186754EE0 0x0000000186755CE0-0x0000000186755DC0
		public Color BackgroundColor { /* [XID] */ /* 0x00000001899046C0-0x00000001899046E0 */ get => default; /* [XID] */ /* 0x000000018984A450-0x000000018984A470 */ set {} } // 0x0000000186754130-0x0000000186754200 0x0000000186754EE0-0x0000000186754FC0
		public Color TextColor { /* [XID] */ /* 0x0000000189851A40-0x0000000189851A60 */ get => default; /* [XID] */ /* 0x00000001897975D0-0x00000001897975F0 */ set {} } // 0x0000000186754BD0-0x0000000186754CA0 0x0000000186755B10-0x0000000186755BF0
		public Color ScrollbarColor { /* [XID] */ /* 0x00000001898603F0-0x0000000189860410 */ get => default; /* [XID] */ /* 0x00000001898ACE40-0x00000001898ACE60 */ set {} } // 0x0000000186754960-0x0000000186754A30 0x0000000186755850-0x0000000186755930
		public Color ExpandArrowColor { /* [XID] */ /* 0x000000018973B6D0-0x000000018973B6F0 */ get => default; /* [XID] */ /* 0x00000001898765F0-0x0000000189876610 */ set {} } // 0x00000001867543A0-0x0000000186754470 0x00000001867551A0-0x0000000186755280
		public Color InputFieldNormalBackgroundColor { /* [XID] */ /* 0x00000001896646B0-0x00000001896646D0 */ get => default; /* [XID] */ /* 0x00000001899873B0-0x00000001899873D0 */ set {} } // 0x0000000186754720-0x00000001867547F0 0x00000001867555C0-0x00000001867556B0
		public Color InputFieldInvalidBackgroundColor { /* [XID] */ /* 0x000000018988C8A0-0x000000018988C8C0 */ get => default; /* [XID] */ /* 0x0000000189893D60-0x0000000189893D80 */ set {} } // 0x0000000186754650-0x0000000186754720 0x00000001867554D0-0x00000001867555C0
		public Color InputFieldTextColor { /* [XID] */ /* 0x000000018989B4B0-0x000000018989B4D0 */ get => default; /* [XID] */ /* 0x00000001898A2930-0x00000001898A2950 */ set {} } // 0x00000001867547F0-0x00000001867548C0 0x00000001867556B0-0x00000001867557A0
		public Color ToggleCheckmarkColor { /* [XID] */ /* 0x00000001898A9F00-0x00000001898A9F20 */ get => default; /* [XID] */ /* 0x00000001898E9810-0x00000001898E9830 */ set {} } // 0x0000000186754CA0-0x0000000186754D70 0x0000000186755BF0-0x0000000186755CE0
		public Color ButtonBackgroundColor { /* [XID] */ /* 0x00000001898B9340-0x00000001898B9360 */ get => default; /* [XID] */ /* 0x000000018991E030-0x000000018991E050 */ set {} } // 0x0000000186754200-0x00000001867542D0 0x0000000186754FC0-0x00000001867550B0
		public Color ButtonTextColor { /* [XID] */ /* 0x00000001898C7F80-0x00000001898C7FA0 */ get => default; /* [XID] */ /* 0x000000018968E310-0x000000018968E330 */ set {} } // 0x00000001867542D0-0x00000001867543A0 0x00000001867550B0-0x00000001867551A0
		public Color SelectedItemBackgroundColor { /* [XID] */ /* 0x00000001898D7130-0x00000001898D7150 */ get => default; /* [XID] */ /* 0x00000001899ABF90-0x00000001899ABFB0 */ set {} } // 0x0000000186754A30-0x0000000186754B00 0x0000000186755930-0x0000000186755A20
		public Color SelectedItemTextColor { /* [XID] */ /* 0x00000001898E6470-0x00000001898E6490 */ get => default; /* [XID] */ /* 0x00000001898EDE90-0x00000001898EDEB0 */ set {} } // 0x0000000186754B00-0x0000000186754BD0 0x0000000186755A20-0x0000000186755B10
	
		// Constructors
		public UISkin() {} // 0x0000000186753F70-0x0000000186754130
	
		// Methods
		// [ContextMenu] // 0x00000001897ECAD0-0x00000001897ECB20
		// [XID] // 0x00000001897ECAD0-0x00000001897ECB20
		private void Invalidate() {} // 0x0000000186753EC0-0x0000000186753F70
	}
}
