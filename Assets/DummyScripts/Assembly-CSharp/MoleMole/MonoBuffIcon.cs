/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBuffIcon : MonoSpriteProxy // TypeDefIndex: 31186
	{
		// Fields
		public static Color[] elementColorList; // 0x00
		public static Color buffColor; // 0x08
		public static Color buffColorFrame; // 0x18
		public static Color debuffColor; // 0x28
		public static Color debuffColorFrame; // 0x38
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cdMask; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _countLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _addEffect; // 0x38
		public Image background; // 0x40
		public Image frame; // 0x48
		private ElementStateExcelConfig _elementConfig; // 0x50
		private BuffIconExcelConfig _buffConfig; // 0x58
		private string _currIconName; // 0x60
	
		// Properties
		public Sprite icon { /* [XID] */ /* 0x0000000189981370-0x0000000189981390 */ set {} } // 0x0000000184801250-0x0000000184801310
		public bool showCDMask { /* [XID] */ /* 0x0000000189988B40-0x0000000189988B60 */ set {} } // 0x0000000184801310-0x0000000184801410
		public float cdRatio { /* [XID] */ /* 0x00000001899902E0-0x0000000189990300 */ set {} } // 0x00000001848010C0-0x0000000184801180
		public bool showCount { /* [XID] */ /* 0x0000000189997E70-0x0000000189997E90 */ set {} } // 0x0000000184801410-0x0000000184801510
		public int count { /* [XID] */ /* 0x000000018999F5A0-0x000000018999F5C0 */ set {} } // 0x0000000184801180-0x0000000184801250
	
		// Constructors
		public MonoBuffIcon() {} // 0x0000000184801030-0x00000001848010C0
		static MonoBuffIcon() {} // 0x0000000184800B50-0x0000000184801030
	
		// Methods
		// [XID] // 0x00000001899A70F0-0x00000001899A7110
		public void PlayAddEffect(bool enable) {} // 0x0000000184800A40-0x0000000184800B50
		// [XID] // 0x00000001899AEA20-0x00000001899AEA40
		private void OnDisable() {} // 0x0000000184800970-0x0000000184800A40
		// [IDTag] // 0x00000001899B5D80-0x00000001899B5DC0
		// [XID] // 0x00000001899B5D80-0x00000001899B5DC0
		public void InitData(ElementStateExcelConfig config, bool isSimple, bool isFirst) {} // 0x00000001848002F0-0x0000000184800620
		// [IDTag] // 0x00000001899C0700-0x00000001899C0740
		// [XID] // 0x00000001899C0700-0x00000001899C0740
		public void InitData(BuffIconExcelConfig config, bool isSimple, bool isFirst) {} // 0x00000001847FFFC0-0x00000001848002F0
		// [XID] // 0x00000001899CB170-0x00000001899CB190
		private void HideWhileLoading(bool hide) {} // 0x00000001847FFCB0-0x00000001847FFE20
		// [XID] // 0x00000001899D2680-0x00000001899D26A0
		private void OnLoadSprite(Sprite sprite) {} // 0x00000001847FFE20-0x00000001847FFFC0
		// [XID] // 0x00000001899D9D90-0x00000001899D9DB0
		private void SetBackgroundColor() {} // 0x0000000184800620-0x0000000184800970
	}
}
