/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189A0CEE0-0x0000000189A0CF20
	public class MapMarkStyle : ScriptableObject // TypeDefIndex: 19649
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MarkStyle _default; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MarkStyle _localAvatar; // 0x2C
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MarkStyle _companion; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MarkStyle _custom; // 0x54
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MarkStyle _pin; // 0x68
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MarkStyle _quest; // 0x7C
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MarkStyle _transPoint; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MarkStyle _monster; // 0xA4
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MarkStyle _nearHint; // 0xB8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MarkStyle _widget; // 0xCC
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MarkStyle _scenePoint; // 0xE0
		[SerializeField] // 0x0000000189A89220-0x0000000189A89270
		[Space] // 0x0000000189A89220-0x0000000189A89270
		// [Tooltip] // 0x0000000189A89220-0x0000000189A89270
		private List<MarkIconType> _pinMarkIcons; // 0xF8
		[SerializeField] // 0x0000000189A89220-0x0000000189A89270
		[Space] // 0x0000000189A89220-0x0000000189A89270
		// [Tooltip] // 0x0000000189A89220-0x0000000189A89270
		private List<MarkIconType> _customMarkIcons; // 0x100
	
		// Properties
		public List<MarkIconType> pinMarkIcons { /* [XID] */ /* 0x0000000189AACD80-0x0000000189AACDA0 */ get => default; } // 0x0000000184F1ADD0-0x0000000184F1AE80 
		public List<MarkIconType> customMarkIcons { /* [XID] */ /* 0x0000000189AB4650-0x0000000189AB4670 */ get => default; } // 0x0000000184F1AD20-0x0000000184F1ADD0 
	
		// Constructors
		public MapMarkStyle() {} // 0x0000000184F1ACC0-0x0000000184F1AD20
	
		// Methods
		// [XID] // 0x0000000189AA5660-0x0000000189AA5680
		public MarkStyle GetStyle(MarkType markType) => default; // 0x0000000184F1A680-0x0000000184F1A850
		// [XID] // 0x0000000189ABC3E0-0x0000000189ABC400
		public bool IsValidPinMarkIcon(MarkIconType iconType) => default; // 0x0000000184F1AA10-0x0000000184F1ABD0
		// [XID] // 0x0000000189AC3CA0-0x0000000189AC3CC0
		public bool IsValidCustomMarkIcons(MarkIconType iconType) => default; // 0x0000000184F1A850-0x0000000184F1AA10
		// [XID] // 0x0000000189ACB120-0x0000000189ACB140
		public bool IsValidIcon(MarkType markType, MarkIconType iconType) => default; // 0x0000000184F1ABD0-0x0000000184F1ACC0
	}
}
