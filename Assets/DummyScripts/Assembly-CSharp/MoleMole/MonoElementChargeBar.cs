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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoElementChargeBar : MonoUIProxy // TypeDefIndex: 31209
	{
		// Fields
		public Slider barSlider; // 0x40
		public UnityEngine.UI.Text tipText; // 0x48
		public UnityEngine.UI.Text subTitleText; // 0x50
		public RectTransform elementRoot; // 0x58
		public RectTransform pointAnchor; // 0x60
		public const string ElementChargePointPrefabPath = "ART/UI/Menus/Widget/InLevel/ElementCharge_Point"; // Metadata: 0x00B12015
		private const string POINT_HIGHLIGHT = "Point_Highlight"; // Metadata: 0x00B12048
		private List<GameObject> markGOList; // 0x68
		private bool inited; // 0x70
		private int _pointNum; // 0x74
		private int _currindex; // 0x78
		private int currAnim; // 0x7C
	
		// Properties
		public bool showSubTitle { /* [XID] */ /* 0x000000018991FC40-0x000000018991FC60 */ set {} } // 0x0000000183CA1E00-0x0000000183CA1F10
	
		// Constructors
		public MonoElementChargeBar() {} // 0x0000000183CA1D40-0x0000000183CA1E00
	
		// Methods
		// [XID] // 0x00000001899274B0-0x00000001899274D0
		public void SetValue(float value) {} // 0x0000000183CA1C70-0x0000000183CA1D40
		// [XID] // 0x000000018992ECA0-0x000000018992ECC0
		public void Init(float[] values, float max, int currIndex, ElementType elementType) {} // 0x0000000183CA10E0-0x0000000183CA12C0
		// [IDTag] // 0x00000001899360D0-0x0000000189936110
		// [XID] // 0x00000001899360D0-0x0000000189936110
		private void RefreshBarStyle(ElementType elementType) {} // 0x0000000183CA0E00-0x0000000183CA0F00
		// [IDTag] // 0x00000001899407F0-0x0000000189940830
		// [XID] // 0x00000001899407F0-0x0000000189940830
		public void RefreshBarStyle(int triggerId) {} // 0x0000000183CA1BB0-0x0000000183CA1C70
		// [XID] // 0x000000018994B030-0x000000018994B050
		private void OnEnable() {} // 0x0000000183CA17A0-0x0000000183CA1840
		// [XID] // 0x00000001899529D0-0x00000001899529F0
		private void RefreshAnim() {} // 0x0000000183CA12C0-0x0000000183CA1470
		// [XID] // 0x0000000189959F70-0x0000000189959F90
		private void EnablePointHighlight(GameObject point, bool enable) {} // 0x0000000183CA1470-0x0000000183CA15D0
		// [XID] // 0x0000000189961980-0x00000001899619A0
		public void PlayPointAnimEx(int index) {} // 0x0000000183CA1840-0x0000000183CA19B0
		// [XID] // 0x0000000189969030-0x0000000189969050
		public void PlayPointAnim(int index) {} // 0x0000000183CA19B0-0x0000000183CA1BB0
		// [XID] // 0x0000000189970A70-0x0000000189970A90
		private void SetPoint(int i, float percent) {} // 0x0000000183CA0F00-0x0000000183CA1080
		// [XID] // 0x0000000189978470-0x0000000189978490
		private float GetWidth() => default; // 0x0000000183CA0CF0-0x0000000183CA0E00
		// [XID] // 0x000000018997F570-0x000000018997F590
		protected override void OnDestroy() {} // 0x0000000183CA15D0-0x0000000183CA17A0
	}
}
