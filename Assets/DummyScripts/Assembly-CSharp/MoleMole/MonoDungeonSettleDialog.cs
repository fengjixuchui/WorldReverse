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
	public class MonoDungeonSettleDialog : MonoBehaviour // TypeDefIndex: 30997
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _trialGroup; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _victoryGroup; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _failureGroup; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _countDownGrp; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _countDownLabel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bg; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LabelGrp[] _settleItems; // 0x48
	
		// Properties
		public RectTransform trialGroup { /* [XID] */ /* 0x0000000189685EE0-0x0000000189685F00 */ get => default; } // 0x0000000184693D70-0x0000000184693E10 
		public RectTransform victoryGroup { /* [XID] */ /* 0x000000018968DD10-0x000000018968DD30 */ get => default; } // 0x0000000184693E10-0x0000000184693EB0 
		public RectTransform failureGroup { /* [XID] */ /* 0x0000000189695660-0x0000000189695680 */ get => default; } // 0x0000000184693C30-0x0000000184693CD0 
		public RectTransform countDownGroup { /* [XID] */ /* 0x000000018969CCB0-0x000000018969CCD0 */ get => default; } // 0x0000000184693B90-0x0000000184693C30 
		public LabelGrp[] settleItems { /* [XID] */ /* 0x00000001896A4020-0x00000001896A4040 */ get => default; } // 0x0000000184693CD0-0x0000000184693D70 
		public GameObject bg { /* [XID] */ /* 0x00000001896AB600-0x00000001896AB620 */ get => default; } // 0x0000000184693AF0-0x0000000184693B90 
		public int countDown { /* [XID] */ /* 0x00000001896B2810-0x00000001896B2830 */ set {} } // 0x0000000184693EB0-0x00000001846940C0
	
		// Nested types
		[Serializable]
		public struct LabelGrp // TypeDefIndex: 30998
		{
			// Fields
			public RectTransform group; // 0x00
			public UnityEngine.UI.Text label; // 0x08
		}
	
		// Constructors
		public MonoDungeonSettleDialog() {} // 0x0000000184693A70-0x0000000184693AF0
	
		// Methods
		// [XID] // 0x00000001896B9F30-0x00000001896B9F50
		public Animator GetAnimator() => default; // 0x00000001846939B0-0x0000000184693A70
	}
}
