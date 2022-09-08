/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCodexCreaturePage : MonoUIProxy // TypeDefIndex: 30492
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _creatureScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _creatureInfo; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noInfoGroup; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _creatureGroup; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _killedNumGroup; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _previewGroup; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tipsGroup; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _title; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _collectedNum; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _creatureName; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _creatureDesc; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _noInfoTitle; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _noInfoDesc; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _killedNumText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _previewTitle; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _previewName; // 0xC0
	
		// Properties
		public MonoSimpleReusableList creatureScroller { /* [XID] */ /* 0x0000000189846490-0x00000001898464B0 */ get => default; } // 0x0000000184BA2340-0x0000000184BA23E0 
		public RectTransform creatureInfo { /* [XID] */ /* 0x000000018984DA60-0x000000018984DA80 */ get => default; } // 0x0000000184BA21F0-0x0000000184BA2290 
		public RectTransform noInfoGroup { /* [XID] */ /* 0x0000000189854AE0-0x0000000189854B00 */ get => default; } // 0x0000000184BA25E0-0x0000000184BA2680 
		public RectTransform creatureGroup { /* [XID] */ /* 0x000000018985C340-0x000000018985C360 */ get => default; } // 0x0000000184BA2150-0x0000000184BA21F0 
		public RectTransform killedNumGroup { /* [XID] */ /* 0x0000000189863C80-0x0000000189863CA0 */ get => default; } // 0x0000000184BA23E0-0x0000000184BA2480 
		public RectTransform previewGroup { /* [XID] */ /* 0x000000018986AF90-0x000000018986AFB0 */ get => default; } // 0x0000000184BA27F0-0x0000000184BA2890 
		public RectTransform tipsGroup { /* [XID] */ /* 0x0000000189872360-0x0000000189872380 */ get => default; } // 0x0000000184BA2C50-0x0000000184BA2CF0 
		public Text title { /* [XID] */ /* 0x0000000189879FB0-0x0000000189879FD0 */ get => default; } // 0x0000000184BA2CF0-0x0000000184BA2DA0 
		public Text collectedNum { /* [XID] */ /* 0x0000000189881110-0x0000000189881130 */ get => default; } // 0x0000000184BA1FF0-0x0000000184BA20A0 
		public Text creatureName { /* [XID] */ /* 0x00000001898886E0-0x0000000189888700 */ get => default; } // 0x0000000184BA2290-0x0000000184BA2340 
		public Text creatureDesc { /* [XID] */ /* 0x000000018988FAC0-0x000000018988FAE0 */ get => default; } // 0x0000000184BA20A0-0x0000000184BA2150 
		public Text noInfoTitle { /* [XID] */ /* 0x0000000189896FA0-0x0000000189896FC0 */ get => default; } // 0x0000000184BA2680-0x0000000184BA2730 
		public Text noInfoDesc { /* [XID] */ /* 0x000000018989E500-0x000000018989E520 */ get => default; } // 0x0000000184BA2530-0x0000000184BA25E0 
		public Text killedNumText { /* [XID] */ /* 0x00000001898A6020-0x00000001898A6040 */ get => default; } // 0x0000000184BA2480-0x0000000184BA2530 
		public Text previewTitle { /* [XID] */ /* 0x00000001898AD5B0-0x00000001898AD5D0 */ get => default; } // 0x0000000184BA2A00-0x0000000184BA2AB0 
		public Text previewName { /* [XID] */ /* 0x00000001898B4B50-0x00000001898B4B70 */ get => default; } // 0x0000000184BA2890-0x0000000184BA2940 
		public MonoUIContainer backBtn { /* [XID] */ /* 0x00000001898BC6A0-0x00000001898BC6C0 */ get => default; } // 0x0000000184BA1CF0-0x0000000184BA1DB0 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x00000001898C3C60-0x00000001898C3C80 */ get => default; } // 0x0000000184BA1F30-0x0000000184BA1FF0 
		public MonoUIContainer previewBtn { /* [XID] */ /* 0x00000001898CB4E0-0x00000001898CB500 */ get => default; } // 0x0000000184BA2730-0x0000000184BA27F0 
		public MonoUIContainer previewReturnBtn { /* [XID] */ /* 0x00000001898D2BF0-0x00000001898D2C10 */ get => default; } // 0x0000000184BA2940-0x0000000184BA2A00 
		public MonoUIContainer tipsBtn { /* [XID] */ /* 0x00000001898DA500-0x00000001898DA520 */ get => default; } // 0x0000000184BA2B90-0x0000000184BA2C50 
		public MonoUIContainer visibleToggle { /* [XID] */ /* 0x00000001898E21F0-0x00000001898E2210 */ get => default; } // 0x0000000184BA2DA0-0x0000000184BA2E60 
		public MonoReusableList tabList { /* [XID] */ /* 0x00000001898E9DD0-0x00000001898E9DF0 */ get => default; } // 0x0000000184BA2AB0-0x0000000184BA2B90 
		public Button btnTabPrev { /* [XID] */ /* 0x00000001898F1500-0x00000001898F1520 */ get => default; } // 0x0000000184BA1E70-0x0000000184BA1F30 
		public Button btnTabNext { /* [XID] */ /* 0x00000001898F8CA0-0x00000001898F8CC0 */ get => default; } // 0x0000000184BA1DB0-0x0000000184BA1E70 
	
		// Constructors
		public MonoCodexCreaturePage() {} // 0x0000000184BA1C20-0x0000000184BA1CF0
	}
}
